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
using System.Diagnostics.Eventing.Reader;

namespace MusicShop
{
    public partial class HomeAdmin : Form
    {
        private readonly string loggedInAdminUsername; // za username
        private readonly string loggedInAdminFirstName; // za ime
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        MySqlConnection mySqlConnection;
        private string selectedCategory;

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
                    using (MySqlCommand command_adminId = new(query_adminId, mySqlConnection))
                    {
                        command_adminId.Parameters.AddWithValue("@username", loggedInAdminUsername);
                        object result = command_adminId.ExecuteScalar();

                        if (result != null)
                        {
                            int adminId = Convert.ToInt32(result);

                            string query_wallet = "SELECT wallet FROM admin WHERE admin_id = @admin_id";
                            using (MySqlCommand command_wallet = new(query_wallet, mySqlConnection))
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
                // povlači sve iz baze
                // tu dodati uvijet ako smo u kategoriji
                mySqlConnection = new(mySqlCon);
                mySqlConnection.Open();
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

                            byte[] imageData = (byte[])reader["instrument_image"];
                            MemoryStream memory = new(imageData);
                            Image image = Image.FromStream(memory);

                            PictureBox pic = new();
                            pic.Image = image;
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic.Dock = DockStyle.Fill;
                            //table layout panel
                            TableLayoutPanel tableForPicture = new();
                            tableForPicture.RowCount = 3;
                            tableForPicture.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                            tableForPicture.RowStyles.Add(new RowStyle(SizeType.Percent, 76));
                            tableForPicture.RowStyles.Add(new RowStyle(SizeType.Percent, 14));
                            tableForPicture.Height = 430;
                            tableForPicture.Width = 350;
                            tableForPicture.BackColor = Color.Peru;
                            tableForPicture.Margin = new Padding(0, 0, 40, 30);
                            // dodavanje slike u drugi redak
                            tableForPicture.Controls.Add(pic, 0, 1);

                            Label name = new();
                            name.Text = reader["instrument_name"].ToString();
                            name.Dock = DockStyle.Fill;
                            name.TextAlign = ContentAlignment.MiddleCenter;
                            name.Font = new Font("Gabriola", 16, FontStyle.Bold);
                            // dodavanje naziva instrumenta u prvi redak
                            tableForPicture.Controls.Add(name, 0, 0);

                            FlowLayoutPanel buttonPanel = new();
                            buttonPanel.Dock = DockStyle.Fill;
                            buttonPanel.FlowDirection = FlowDirection.LeftToRight; // Postavljanje smjera na desno
                            tableForPicture.Controls.Add(buttonPanel, 0, 2);

                            Label price = new();
                            price.Text = reader["instrument_price"].ToString() + " €";
                            price.TextAlign = ContentAlignment.TopCenter;
                            price.Width = 205;
                            price.Height = 50;
                            price.ForeColor = Color.GreenYellow;
                            price.Font = new Font("Gabriola", 18, FontStyle.Bold);
                            buttonPanel.Controls.Add(price);

                            Button buy = new();
                            buy.Text = "KUPI";
                            buy.Font = new Font("Gabriola", 11, FontStyle.Bold);
                            buy.Size = new Size(120, 50);
                            buy.BackColor = Color.Bisque;
                            buttonPanel.Controls.Add(buy);

                            // stavljamo na panel
                            InstrumentiPanel.AutoScroll = true;
                            InstrumentiPanel.Controls.Add(tableForPicture);
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
            Products products = new(loggedInAdminUsername, loggedInAdminFirstName);
            products.Show();
            this.Hide();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Nodes.Count == 0) // provjera ako je odabrani list u treeviewu dio istog
            {
                selectedCategory = e.Node.Text;
                FilterComboBox_SelectedIndexChanged(sender, e);
            }
        }
        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sort = FilterComboBox.Text;
                InstrumentiPanel.Controls.Clear();
                mySqlConnection = new MySqlConnection(mySqlCon);
                using (mySqlConnection)
                {
                    mySqlConnection.Open();
                    string query = "";
                    MySqlCommand command;
                    // provjeravam da li je odabran instrument u tree viewu
                    if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "Svi proizvodi")
                    {
                        // ako je odabran instrument, koristim ga kao kriterij za sortiranje
                        query = "SELECT instrument_image, instrument_name, instrument_price FROM instruments WHERE instrument_category = @category";
                    }
                    else if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory == "Svi proizvodi")
                    {
                        query = "SELECT instrument_image, instrument_name, instrument_price FROM instruments";
                    }
                    else if (string.IsNullOrEmpty(selectedCategory))
                    {
                        query = "SELECT instrument_image, instrument_name, instrument_price FROM instruments";
                    }
                    else
                    {
                        MessageBox.Show("Greška!");
                        return;
                    }

                    // ako korisnik odabere način filtiranja po cijeni
                    if (!string.IsNullOrEmpty(sort))
                    {
                        if (sort == "Po najnižoj cijeni")
                        {
                            query += " ORDER BY instrument_price ASC";
                        }
                        else if (sort == "Po najvišoj cijeni")
                        {
                            query += " ORDER BY instrument_price DESC";
                        }
                    }

                    command = new MySqlCommand(query, mySqlConnection);

                    // postavljam parametar kategorije ako je odabran instrument
                    if (!string.IsNullOrEmpty(selectedCategory))
                    {
                        command.Parameters.AddWithValue("@category", selectedCategory);
                    }

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TableLayoutPanel tableForPicture = new();
                        tableForPicture.RowCount = 3;
                        tableForPicture.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                        tableForPicture.RowStyles.Add(new RowStyle(SizeType.Percent, 76));
                        tableForPicture.RowStyles.Add(new RowStyle(SizeType.Percent, 14));
                        tableForPicture.Height = 430;
                        tableForPicture.Width = 350;
                        tableForPicture.BackColor = Color.Peru;
                        tableForPicture.Margin = new Padding(0, 0, 40, 30);

                        // za cijenu i button kupi
                        FlowLayoutPanel buttonPanel = new();
                        buttonPanel.Dock = DockStyle.Fill;
                        buttonPanel.FlowDirection = FlowDirection.LeftToRight;
                        tableForPicture.Controls.Add(buttonPanel, 0, 2);

                        string instrumentName = reader.GetString("instrument_name");
                        double instrumentPrice = reader.GetDouble("instrument_price");

                        PictureBox pic = new PictureBox();
                        byte[] imageData = (byte[])reader["instrument_image"];
                        MemoryStream memory = new(imageData);
                        Image image = Image.FromStream(memory);
                        pic.Image = image;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Dock = DockStyle.Fill;
                        tableForPicture.Controls.Add(pic, 0, 1);

                        Label name = new();
                        name.Text = reader["instrument_name"].ToString();
                        name.Dock = DockStyle.Fill;
                        name.TextAlign = ContentAlignment.MiddleCenter;
                        name.Font = new Font("Gabriola", 16, FontStyle.Bold);
                        tableForPicture.Controls.Add(name, 0, 0);

                        Label price = new();
                        price.Text = reader["instrument_price"].ToString() + " €";
                        price.TextAlign = ContentAlignment.TopCenter;
                        price.Width = 205;
                        price.Height = 50;
                        price.ForeColor = Color.GreenYellow;
                        price.Font = new Font("Gabriola", 18, FontStyle.Bold);
                        buttonPanel.Controls.Add(price);

                        Button buy = new();
                        buy.Text = "KUPI";
                        buy.Font = new Font("Gabriola", 11, FontStyle.Bold);
                        buy.Size = new Size(120, 50);
                        buy.BackColor = Color.Bisque;
                        buttonPanel.Controls.Add(buy);

                        // stavljamo na panel
                        InstrumentiPanel.AutoScroll = true;
                        InstrumentiPanel.Controls.Add(tableForPicture);
                    }
                    mySqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void UkloniFilter_Click(object sender, EventArgs e)
        {
            try
            {
                InstrumentiPanel.Controls.Clear();
                if (String.IsNullOrEmpty(selectedCategory) || selectedCategory == "Svi proizvodi")
                {
                    // ako nema kategorije
                    FilterComboBox.Text = "Sortiraj po cijeni";
                    GetProductsFromDb();
                }
                else
                {
                    mySqlConnection = new MySqlConnection(mySqlCon);
                    mySqlConnection.Open();
                    string query = "select instrument_image, instrument_name, instrument_price from instruments where instrument_category = @category";
                    MySqlCommand command = new(query, mySqlConnection);
                    command.Parameters.AddWithValue("@category", selectedCategory);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TableLayoutPanel tableForPicture = new();
                            tableForPicture.RowCount = 3;
                            tableForPicture.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                            tableForPicture.RowStyles.Add(new RowStyle(SizeType.Percent, 76));
                            tableForPicture.RowStyles.Add(new RowStyle(SizeType.Percent, 14));
                            tableForPicture.Height = 430;
                            tableForPicture.Width = 350;
                            tableForPicture.BackColor = Color.Peru;
                            tableForPicture.Margin = new Padding(0, 0, 40, 30);

                            // za cijenu i button kupi
                            FlowLayoutPanel buttonPanel = new();
                            buttonPanel.Dock = DockStyle.Fill;
                            buttonPanel.FlowDirection = FlowDirection.LeftToRight;
                            tableForPicture.Controls.Add(buttonPanel, 0, 2);

                            string instrumentName = reader.GetString("instrument_name");
                            double instrumentPrice = reader.GetDouble("instrument_price");

                            PictureBox pic = new PictureBox();
                            byte[] imageData = (byte[])reader["instrument_image"];
                            MemoryStream memory = new(imageData);
                            Image image = Image.FromStream(memory);
                            pic.Image = image;
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic.Dock = DockStyle.Fill;
                            tableForPicture.Controls.Add(pic, 0, 1);

                            Label name = new();
                            name.Text = reader["instrument_name"].ToString();
                            name.Dock = DockStyle.Fill;
                            name.TextAlign = ContentAlignment.MiddleCenter;
                            name.Font = new Font("Gabriola", 16, FontStyle.Bold);
                            tableForPicture.Controls.Add(name, 0, 0);

                            Label price = new();
                            price.Text = reader["instrument_price"].ToString() + " €";
                            price.TextAlign = ContentAlignment.TopCenter;
                            price.Width = 205;
                            price.Height = 50;
                            price.ForeColor = Color.GreenYellow;
                            price.Font = new Font("Gabriola", 18, FontStyle.Bold);
                            buttonPanel.Controls.Add(price);

                            Button buy = new();
                            buy.Text = "KUPI";
                            buy.Font = new Font("Gabriola", 11, FontStyle.Bold);
                            buy.Size = new Size(120, 50);
                            buy.BackColor = Color.Bisque;
                            buttonPanel.Controls.Add(buy);

                            // stavljamo na panel
                            InstrumentiPanel.AutoScroll = true;
                            InstrumentiPanel.Controls.Add(tableForPicture);
                        }
                    }
                    FilterComboBox.Text = "Sortiraj po cijeni";
                    mySqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvaćanja podataka iz baze: " + ex.Message);
            }
        }

        private void InstrumentiPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
