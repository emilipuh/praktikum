using MySql.Data.MySqlClient;

namespace MusicShop
{
    public partial class HomeUser : Form
    {
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        private readonly string loggedInUserUsername; // privatna varijabla koja prati koji je korisnik ulogiran
        private readonly string loggedInUserFirstName; // privatna varijabla koja prati koji je korisnik ulogiran
        MySqlConnection mySqlConnection;
        private string selectedCategory;
        public HomeUser(string loggedInUserUsername, string loggedInUserFirstName) // konstruktor
        {
            this.loggedInUserFirstName = loggedInUserFirstName;
            this.loggedInUserUsername = loggedInUserUsername; // koristimo dalje u kodu za pristup informacijama trenutno ulogiranog usera
            InitializeComponent();
        }
        private void MusicShop_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = 60;
            flowLayoutPanel1.BringToFront();
            Dropdown.Text = "Dobrodošli, " + loggedInUserFirstName + "!";

            try
            {
                using (mySqlConnection = new(mySqlCon))
                {

                    mySqlConnection.Open();
                    string query_userId = "SELECT user_id FROM users WHERE username = @username";
                    using MySqlCommand command_userId = new(query_userId, mySqlConnection);

                    command_userId.Parameters.AddWithValue("@username", loggedInUserUsername);
                    object result = command_userId.ExecuteScalar();

                    if (result != null)
                    {
                        int userId = Convert.ToInt32(result);

                        string query_wallet = "SELECT wallet FROM users WHERE user_id = @user_id";
                        using MySqlCommand command_wallet = new(query_wallet, mySqlConnection);

                        command_wallet.Parameters.AddWithValue("@user_id", userId);
                        object walletResult = command_wallet.ExecuteScalar();

                        if (walletResult != null)
                        {
                            iznos_novcanika.Text = walletResult.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Nije pronaðeno stanje novèanika za trenutno prijavljenog korisnika.");
                        }
                        mySqlConnection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nije pronaðen korisnik s korisnièkim imenom: " + loggedInUserUsername);
                    }
                    // pozivanje metode za uèitavanje proizvoda iz baze
                    GetProductsFromDb();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvatanja stanja novèanika: " + ex.Message);
            }
        }
        public void UpdateUserData()
        {
            Dropdown.Text = "Dobrodošli, " + loggedInUserFirstName + "!";
        }
        private void GetProductsFromDb()
        {
            try
            {
                // povlaèi sve iz baze
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
                            // Izvlaèenje podataka iz baze
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
                MessageBox.Show("Greška prilikom dohvaæanja podataka iz baze: " + ex.Message);
            }
        }
        private void Down_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Height == 325)
            {
                flowLayoutPanel1.Height = 60;
            }
            else
            {
                flowLayoutPanel1.Height = 325;
            }
        }
        private void Odjava_Click_1(object sender, EventArgs e)
        {
            Login loginPage = new();
            loginPage.Show();
            this.Close();
        }

        private void Novcanik_Click(object sender, EventArgs e)
        {
            WalletUser novcanik = new(loggedInUserUsername, loggedInUserFirstName);
            novcanik.Show();
            this.Hide();
        }

        private void UrediPodatke_Click(object sender, EventArgs e)
        {
            DetailsUser details = new(loggedInUserUsername, loggedInUserFirstName);
            details.Show();
            this.Hide();
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
        private void UkloniFilter_Click_1(object sender, EventArgs e)
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
                    mySqlConnection = new(mySqlCon);
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
                MessageBox.Show("Greška prilikom dohvaæanja podataka iz baze: " + ex.Message);
            }
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection = new(mySqlCon);
                string vrstaFiltera = Filter.Text;
                InstrumentiPanel.Controls.Clear();
                MySqlCommand command;
                using (mySqlConnection)
                {
                    mySqlConnection.Open();
                    string query = "";
                    // provjeravam ako je odabrano nešto u tree viewu
                    // ako mi kategorija nije prazna i nije svi proizvodi
                    if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "Svi proizvodi")
                    {
                        query = "select instrument_image, instrument_name, instrument_price from instruments where instrument_category=@category";
                    }
                    // ako mi je kategorija svi proizvodi
                    else if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory == "Svi proizvodi")
                    {
                        query = "select instrument_image, instrument_name, instrument_price from instruments";
                    }
                    // ako mi je kategorija prazna(sluèaj koji se dešava jednom)
                    else if (string.IsNullOrEmpty(selectedCategory))
                    {
                        query = "select instrument_image, instrument_name, instrument_price from instruments";
                    }
                    else
                    {
                        MessageBox.Show("Greška!");
                        return;
                    }

                    // provjeravam da li je korisnik odabrao naèin filtriranja
                    // ako nije odabran filter samo se preskaèe ovaj dio
                    if (!string.IsNullOrEmpty(vrstaFiltera))
                    {
                        if (vrstaFiltera == "Po najnižoj cijeni")
                        {
                            query += " order by instrument_price asc";
                        }
                        else if (vrstaFiltera == "Po najvišoj cijeni")
                        {
                            query += " order by instrument_price desc";
                        }
                    }
                    command = new(query, mySqlConnection);
                    // provjeravam ako smo u kategoriji i ako jesmo prosljeðujemo parametar id
                    // ako nismo preskaèe se ovaj dio
                    if(!string.IsNullOrEmpty(selectedCategory))
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

                        PictureBox pic = new();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
