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
    public partial class InsertProduct : Form
    {
        private readonly string loggedInAdminUsername;
        private readonly string loggedInAdminFirstName;
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        MySqlConnection mySqlConnection;
        public InsertProduct(string loggedInAdminUsername, string loggedInAdminFirstName)
        {
            this.loggedInAdminFirstName = loggedInAdminFirstName;
            this.loggedInAdminUsername = loggedInAdminUsername;
            InitializeComponent();
        }

        private void Ponisti_Click(object sender, EventArgs e)
        {
            HomeAdmin homeAdmin = new(loggedInAdminUsername, loggedInAdminFirstName);
            homeAdmin.Show();
            this.Close();
        }

        private void DodajProizvod_Click(object sender, EventArgs e)
        {
            try
            {
                string kategorija = Kategorija.Text;
                string naziv = TextBoxNaziv.Text;
                double cijena = Convert.ToDouble(TextBoxCijena.Text);

                MemoryStream memoryStream = new();
                pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
                byte[] slika = memoryStream.ToArray();

                mySqlConnection = new MySqlConnection(mySqlCon);
                using (mySqlConnection)
                {
                    mySqlConnection.Open();
                    string query = "insert into instruments(instrument_category, instrument_name, instrument_price, instrument_image) values(@category, @name, @price, @image)";
                    MySqlCommand command = new(query, mySqlConnection);
                    command.Parameters.Add("@category", MySqlDbType.VarChar).Value = kategorija;
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = naziv;
                    command.Parameters.Add("@price", MySqlDbType.Double).Value = cijena;
                    command.Parameters.Add("@image", MySqlDbType.Blob).Value = slika;
                    int status = command.ExecuteNonQuery();
                    if (status > 0)
                    {
                        MessageBox.Show("Proizvod je uspješno dodan!");
                        mySqlConnection.Close();
                        HomeAdmin home = new(loggedInAdminUsername, loggedInAdminFirstName);
                        home.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom dodavanja proizvoda.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OdaberiSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            openFileDialog.Filter = "Odaberite sliku(*.JPG;*.PNG)|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
