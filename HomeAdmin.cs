using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;

namespace MusicShop
{
    public partial class HomeAdmin : Form
    {
        private readonly string loggedInAdminUsername; // za username
        private readonly string loggedInAdminFirstName; // za ime
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        MySqlConnection mySqlConnection;

        public HomeAdmin(string loggedInAdminUsername, string loggedInAdminFirstName)
        {
            InitializeComponent();
            this.loggedInAdminUsername = loggedInAdminUsername;
            this.loggedInAdminFirstName = loggedInAdminFirstName;
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            // na dropdownu prikazuje ime trenutnog korisnika
            flowLayoutPanel1.Height = 60;
            flowLayoutPanel1.BringToFront();
            TrenutniKorisnik.Text = "Dobrodošli, " + loggedInAdminFirstName + "!";

            try
            {
                using (mySqlConnection = new MySqlConnection(mySqlCon))
                {
                    mySqlConnection.Open();
                    string query_adminId = "SELECT admin_id FROM admin WHERE username = @username";
                    using (MySqlCommand command_adminId = new MySqlCommand(query_adminId, mySqlConnection))
                    {
                        command_adminId.Parameters.AddWithValue("@username", loggedInAdminUsername);
                        object result = command_adminId.ExecuteScalar();

                        if (result != null)
                        {
                            int adminId = Convert.ToInt32(result);

                            string query_wallet = "SELECT wallet FROM admin WHERE admin_id = @admin_id";
                            using (MySqlCommand command_wallet = new MySqlCommand(query_wallet, mySqlConnection))
                            {
                                command_wallet.Parameters.AddWithValue("@admin_id", adminId);
                                object walletResult = command_wallet.ExecuteScalar();

                                if (walletResult != null)
                                {
                                    iznos_novcanika.Text = walletResult.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Nije pronađeno stanje novčanika za trenutno prijavljenog admina.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nije pronađen admin s korisničkim imenom: " + loggedInAdminUsername);
                        }
                    }

                    // učitavanje slika iz baze
                    GetProductsFromDb();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvatanja stanja novčanika: " + ex.Message);
            }
        }

        public void UpdateAdminData()
        {
            TrenutniKorisnik.Text = "Dobrodošli, " + loggedInAdminFirstName + "!";
        }

        private void GetProductsFromDb()
        {
            try
            {
                string query = "SELECT instrument_image, instrument_name, instrument_price FROM instruments";
                using (MySqlCommand command = new(query, mySqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Izvlačenje podataka iz baze
                            string instrumentName = reader.GetString("instrument_name");
                            double instrumentPrice = reader.GetDouble("instrument_price");

                            long len = reader.GetBytes(0, 0, null, 0, 0);
                            byte[] array = new byte[Convert.ToInt32(len) + 1];
                            reader.GetBytes(0, 0, array, 0, Convert.ToInt32(len));
                            PictureBox pic = new PictureBox();
                            MemoryStream memory = new(array);
                            Bitmap bitmap = new(memory);
                            pic.Dock = DockStyle.Fill;
                            //pic.Height = 230;
                            //pic.Width = 230;
                            //pic.BackgroundImageLayout = ImageLayout.Stretch;
                            //pic.Margin = new Padding(10);

                            
                            pic.BackgroundImage = bitmap;

                            //table layout panel
                            TableLayoutPanel table = new TableLayoutPanel();
                            table.Dock = DockStyle.Fill;
                            table.RowCount = 3;
                            table.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
                            table.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
                            table.RowStyles.Add(new RowStyle(SizeType.Percent, 15));
                            table.BackColor = Color.Blue;
                            table.Controls.Add(pic, 0, 1);

                            Label price = new Label();
                            price.Text = reader["instrument_price"].ToString();
                            price.BackColor = Color.White;
                            price.Width = 50;
                            price.Dock = DockStyle.Bottom;

                            Label name = new Label();
                            name.Text = reader["instrument_name"].ToString();
                            name.BackColor = Color.White;
                            name.Dock = DockStyle.Top;
                            name.TextAlign = ContentAlignment.MiddleCenter;

                            // stavljamo na panel
                            InstrumentiPanel.Controls.Add(table);
                            //pic.Controls.Add(price);
                            //pic.Controls.Add(name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvaćanja podataka iz baze: " + ex.Message);
            }
        }





        private void Down_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Height == 455)
            {
                flowLayoutPanel1.Height = 65;
            }
            else
            {
                flowLayoutPanel1.Height = 455;
            }
        }

        private void Korisnici_Click(object sender, EventArgs e)
        {
            // novi screen u kojem se prikazuju korisnici
            Users users = new(loggedInAdminUsername, loggedInAdminFirstName);
            this.Hide();
            users.Show();
        }

        private void Odjava_Click(object sender, EventArgs e)
        {
            Login login = new();
            this.Close();
            login.Show();
        }

        private void Novcanik_Click(object sender, EventArgs e)
        {
            WalletAdmin novcanik = new(loggedInAdminUsername, loggedInAdminFirstName);
            this.Hide();
            novcanik.Show();
        }

        private void UrediPodatke_Click(object sender, EventArgs e)
        {
            DetailsAdmin detailsAdmin = new(loggedInAdminUsername, loggedInAdminFirstName);
            detailsAdmin.Show();
            this.Hide();
        }

        private void Proizvodi_Click(object sender, EventArgs e)
        {
            InsertProduct insertProduct = new(loggedInAdminUsername, loggedInAdminFirstName);
            insertProduct.Show();
            this.Hide();
        }
    }
}
