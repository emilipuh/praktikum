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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace MusicShop
{
    public partial class Home : Form
    {
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        private string selectedCategory;
        MySqlConnection mySqlConnection;
        public Home()
        {
            InitializeComponent();
        }

        private void prijava_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void InstrumentiPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Nodes.Count == 0) // provjera ako je odabrani list u treeviewu dio istog
            {
                selectedCategory = e.Node.Text;
                Filter_SelectedIndexChanged(sender, e);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            GetProductsFromDb();
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

                            //FlowLayoutPanel buttonPanel = new();
                            //buttonPanel.Dock = DockStyle.Fill;
                            //buttonPanel.FlowDirection = FlowDirection.LeftToRight; // Postavljanje smjera na desno
                            //tableForPicture.Controls.Add(buttonPanel, 0, 2);

                            Label price = new();
                            price.Text = reader["instrument_price"].ToString() + " €";
                            price.Width = 340;
                            price.Height = 50;
                            price.TextAlign = ContentAlignment.MiddleCenter;
                            price.ForeColor = Color.GreenYellow;
                            price.Font = new Font("Gabriola", 18, FontStyle.Bold);
                            tableForPicture.Controls.Add(price);

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

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sort = Filter.Text;
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
                    Filter.Text = "Sortiraj po cijeni";
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
                    Filter.Text = "Sortiraj po cijeni";
                    mySqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvaćanja podataka iz baze: " + ex.Message);
            }
        }
    }
}
