using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class EditInstrumentData : Form
    {
        private readonly string loggedInAdminUsername;
        private readonly string loggedInAdminFirstName;
        private readonly int instrumentId;
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        MySqlConnection mySqlConnection;
        public EditInstrumentData(string loggedInAdminUsername, string loggedInAdminFirstName, int instrumentId)
        {
            this.loggedInAdminFirstName = loggedInAdminFirstName;
            this.loggedInAdminUsername = loggedInAdminUsername;
            this.instrumentId = instrumentId;
            InitializeComponent();
        }

        private void EditInstrumentData_Load(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection = new(mySqlCon);
                using (mySqlConnection)
                {
                    mySqlConnection.Open();
                    // dohvatiti instrument_id
                    string query = "select * from instruments where instrument_id = @instrument_id";
                    using MySqlCommand command = new(query, mySqlConnection);

                    command.Parameters.AddWithValue("@instrument_id", instrumentId);

                    using MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string name = reader["instrument_name"].ToString();
                        double price = reader.GetDouble("instrument_price");
                        string category = reader["instrument_category"].ToString();
                        byte[] imageData = (byte[])reader["instrument_image"];
                        MemoryStream memory = new(imageData);
                        Image image = Image.FromStream(memory);

                        PictureBox pic = new();
                        pic.Image = image;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Dock = DockStyle.Fill;
                        TrenutniNaziv.Text = name;
                        TrenutnaCijena.Text = Convert.ToString(price);
                        TrenutnaKategorija.Text = category;
                        StaraSlika.Controls.Add(pic);
                    }
                    else
                    {
                        MessageBox.Show("Proizvod nije pronađen.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvaćanja podataka: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void Ponisti_Click(object sender, EventArgs e)
        {
            Products products = new(loggedInAdminUsername, loggedInAdminFirstName);
            products.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            openFileDialog.Filter = "Odaberite sliku(*.JPG;*.PNG)|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                NovaSlika.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void AzurirajPodatke_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection = new(mySqlCon);
                using (mySqlConnection)
                {
                    mySqlConnection.Open();
                    StringBuilder updateQuery = new("update instruments set ");

                    // Provjerite koje su vrijednosti korisnik unio i dodajte ih u SQL upit
                    List<string> updateFields = new List<string>();
                    if (!string.IsNullOrEmpty(Kategorija.Text))
                    {
                        updateFields.Add("instrument_category = @category");
                    }
                    if (!string.IsNullOrEmpty(TextBoxNaziv.Text))
                    {
                        updateFields.Add("instrument_name = @name");
                    }
                    if (!string.IsNullOrEmpty(TextBoxCijena.Text))
                    {
                        updateFields.Add("instrument_price = @price");
                    }
                    if (NovaSlika.Image != null)
                    {
                        updateFields.Add("instrument_image = @image");
                    }

                    if (updateFields.Count == 0)
                    {
                        MessageBox.Show("Nema podataka za ažuriranje.");
                        return;
                    }

                    updateQuery.Append(string.Join(", ", updateFields));
                    updateQuery.Append(" where instrument_id = @instrument_id");

                    using (MySqlCommand command = new(updateQuery.ToString(), mySqlConnection))
                    {
                        if (!string.IsNullOrEmpty(Kategorija.Text))
                        {
                            command.Parameters.AddWithValue("@category", Kategorija.Text);
                        }
                        if (!string.IsNullOrEmpty(TextBoxNaziv.Text))
                        {
                            command.Parameters.AddWithValue("@name", TextBoxNaziv.Text);
                        }
                        if (!string.IsNullOrEmpty(TextBoxCijena.Text))
                        {
                            double novaCijena;
                            if (!double.TryParse(TextBoxCijena.Text, out novaCijena))
                            {
                                MessageBox.Show("Cijena nije u valjanom formatu.");
                                return;
                            }
                            command.Parameters.AddWithValue("@price", novaCijena);
                        }
                        if (NovaSlika.Image != null)
                        {
                            MemoryStream memoryStream = new();
                            NovaSlika.Image.Save(memoryStream, NovaSlika.Image.RawFormat);
                            byte[] slika = memoryStream.ToArray();
                            command.Parameters.AddWithValue("@image", slika);
                        }

                        command.Parameters.AddWithValue("@instrument_id", instrumentId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Proizvod je uspješno ažuriran!");
                            Products products = new(loggedInAdminUsername, loggedInAdminFirstName);
                            products.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nema podataka za ažuriranje ili nijedno polje nije uneseno.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom ažuriranja podataka: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
    }
}
