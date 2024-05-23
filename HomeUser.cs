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
        private List<(string, double)> KosaricaStavke = new List<(string, double)>();
        private Label UkupnaCijena = new();
        private double ukupno;
        private object novcanik;

        public HomeUser(string loggedInUserUsername, string loggedInUserFirstName) // konstruktor
        {
            this.loggedInUserFirstName = loggedInUserFirstName;
            this.loggedInUserUsername = loggedInUserUsername; // koristimo dalje u kodu za pristup informacijama trenutno ulogiranog usera
            InitializeComponent();
        }
        private void MusicShop_Load(object sender, EventArgs e)
        {

            AžurirajPrikazKosarice();
            StavkeKosarice.Visible = false;
            flowLayoutPanel1.Height = 60;
            flowLayoutPanel1.BringToFront();
            Dropdown.Text = "Dobrodošli, " + loggedInUserFirstName + "!";

            try
            {
                using (mySqlConnection = new(mySqlCon))
                {
                    mySqlConnection.Open();
                    string query_userId = "SELECT user_id FROM users WHERE username = @username";
                    MySqlCommand command_userId = new(query_userId, mySqlConnection);
                    using (command_userId)
                    {
                        command_userId.Parameters.AddWithValue("@username", loggedInUserUsername);
                        object result = command_userId.ExecuteScalar();

                        if (result != null)
                        {
                            int userId = Convert.ToInt32(result);

                            string query_wallet = "SELECT wallet FROM users WHERE user_id = @user_id";
                            MySqlCommand command_wallet = new(query_wallet, mySqlConnection);
                            using (command_wallet)
                            {
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
                        }
                        else
                        {
                            MessageBox.Show("Nije pronaðen korisnik s korisnièkim imenom: " + loggedInUserUsername);
                        }
                        // pozivanje metode za uèitavanje proizvoda iz baze
                        GetProductsFromDb();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvaæanja stanja novèanika: " + ex.Message);
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
                mySqlConnection = new(mySqlCon);
                using (mySqlConnection)
                {
                    mySqlConnection.Open();
                    string query = "SELECT instrument_image, instrument_name, instrument_price FROM instruments";
                    using (MySqlCommand command = new(query, mySqlConnection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
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
                                buttonPanel.FlowDirection = FlowDirection.LeftToRight;
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
                                buy.Click += (sender, e) =>
                                {
                                    DodajUKosaricu(instrumentName, instrumentPrice);
                                };
                                buttonPanel.Controls.Add(buy);

                                // stavljamo na panel
                                InstrumentiPanel.AutoScroll = true;
                                InstrumentiPanel.Controls.Add(tableForPicture);
                            }
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
            this.Close();
        }

        private void UrediPodatke_Click(object sender, EventArgs e)
        {
            DetailsUser details = new(loggedInUserUsername, loggedInUserFirstName);
            details.Show();
            this.Close();
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
                    using (mySqlConnection)
                    {
                        mySqlConnection.Open();
                        string query = "SELECT instrument_image, instrument_name, instrument_price FROM instruments WHERE instrument_category = @category";
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
                                buy.Click += (sender, e) =>
                                {
                                    DodajUKosaricu(instrumentName, instrumentPrice);
                                };
                                buttonPanel.Controls.Add(buy);

                                // stavljamo na panel
                                InstrumentiPanel.AutoScroll = true;
                                InstrumentiPanel.Controls.Add(tableForPicture);
                            }
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
                        buy.Click += (sender, e) =>
                        {
                            DodajUKosaricu(instrumentName, instrumentPrice);
                        };
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

        private void Kosarica_Click(object sender, EventArgs e)
        {
            // isto kao iz admina
            StavkeKosarice.Visible = true;
        }

        private void DodajUKosaricu(string instrumentName, double instrumentPrice)
        {
            // Dodavanje stavke u listu košarice
            KosaricaStavke.Insert(0, (instrumentName, instrumentPrice));

            // Ažuriranje prikaza košarice
            AžurirajPrikazKosarice();
        }
        private void AžurirajPrikazKosarice()
        {
            StavkeKosarice.Controls.Clear();

            if (KosaricaStavke.Count == 0)
            {
                PrikaziPraznuKosaricu();
                return;
            }
            StavkeKosarice.Height = 400;
            StavkeKosarice.Width = 300;

            // Ostatak koda za prikaz stavki u košarici...
            TableLayoutPanel kosaricaPanel = new TableLayoutPanel();
            kosaricaPanel.Height = 400;
            kosaricaPanel.Width = 300;
            kosaricaPanel.Margin = new Padding(0);
            kosaricaPanel.RowCount = 4;
            kosaricaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8));
            kosaricaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
            kosaricaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            kosaricaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12));

            // gumb za zatvaranje košarice
            Label zatvoriKosaricu = new Label();
            zatvoriKosaricu.Text = "X";
            zatvoriKosaricu.Width = 300;
            zatvoriKosaricu.TextAlign = ContentAlignment.TopRight;
            zatvoriKosaricu.Font = new Font("Gabriola", 10, FontStyle.Bold);
            zatvoriKosaricu.Dock = DockStyle.Left;
            kosaricaPanel.Controls.Add(zatvoriKosaricu, 0, 0);
            zatvoriKosaricu.Click += (sender, e) => { StavkeKosarice.Visible = false; };

            // novi table za stavke košarice
            TableLayoutPanel kosaricaTable = new TableLayoutPanel();
            kosaricaTable.Dock = DockStyle.Fill;
            kosaricaTable.AutoScroll = true;
            kosaricaTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // dodavanje kosaricaTable u StavkeKosarice panel
            kosaricaPanel.Controls.Add(kosaricaTable, 0, 1);

            // Dodavanje stavki iz košarice
            for (int i = 0; i < KosaricaStavke.Count; i++)
            {
                Label stavkaLabel = new Label();
                stavkaLabel.Width = 300;
                stavkaLabel.AutoSize = true;
                stavkaLabel.Font = new Font("Gabriola", 14, FontStyle.Regular);
                stavkaLabel.Text = $"{KosaricaStavke[i].Item1} - {KosaricaStavke[i].Item2} €";
                kosaricaTable.Controls.Add(stavkaLabel, 0, 1);
            }

            // dodavanje ukupne cijene
            UkupnaCijena.Text = "Ukupno: " + KosaricaStavke.Sum(stavka => stavka.Item2) + " €";
            ukupno = KosaricaStavke.Sum(stavka => stavka.Item2);
            UkupnaCijena.Width = 300;
            UkupnaCijena.Height = 30;
            UkupnaCijena.Font = new Font("Gabriola", 12, FontStyle.Regular);
            kosaricaPanel.Controls.Add(UkupnaCijena, 0, 2);

            // novi panel za gumbe naruci i ocisti
            TableLayoutPanel buttonPanel = new TableLayoutPanel();
            buttonPanel.RowCount = 1;
            buttonPanel.ColumnCount = 2;
            buttonPanel.Width = 296;
            buttonPanel.Margin = new Padding(0);

            Button naruci = new Button();
            naruci.Text = "Naruèi";
            naruci.Font = new Font("Gabriola", 12, FontStyle.Bold);
            naruci.Height = 43;
            naruci.Width = 148;
            naruci.FlatStyle = FlatStyle.Flat;
            naruci.FlatAppearance.BorderSize = 0;
            naruci.Click += (sender, e) =>
            {
                if (ProvjeriStanjeNovcanika())
                {
                    SpremiNarudzbuUBazu();
                    AžurirajPrikazKosarice();
                    KosaricaStavke.Clear();
                }
                else
                {
                    MessageBox.Show("Nedovoljno sredstava u novèaniku za izvršenje narudžbe.");
                }
            };
            // dodavanje gumba za èišæenje košarice
            Button ocisti = new Button();
            ocisti.Text = "Oèisti";
            ocisti.Width = 148;
            ocisti.Font = new Font("Gabriola", 12, FontStyle.Bold);
            ocisti.Height = 43;
            ocisti.FlatStyle = FlatStyle.Flat;
            ocisti.FlatAppearance.BorderSize = 0;
            ocisti.Click += (sender, e) =>
            {
                AžurirajPrikazKosarice();
                PrikaziPraznuKosaricu();
                KosaricaStavke.Clear();
            };

            buttonPanel.Controls.Add(naruci, 0, 0);
            buttonPanel.Controls.Add(ocisti, 1, 0);
            kosaricaPanel.Controls.Add(buttonPanel, 0, 3);
            kosaricaPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            // Dodavanje košarica panela u stavke košarice
            StavkeKosarice.Controls.Add(kosaricaPanel);
            // Postavljanje kosaricaTable kao kontrolu za pomicanje unutar StavkeKosarice panela
            StavkeKosarice.AutoScroll = true;
            StavkeKosarice.VerticalScroll.Visible = true;
            StavkeKosarice.VerticalScroll.Enabled = true;
            StavkeKosarice.Visible = true;
        }

        private void PrikaziPraznuKosaricu()
        {
            StavkeKosarice.Controls.Clear();
            // Kreiraj novi TableLayoutPanel za prazan prikaz košarice
            TableLayoutPanel PraznaKosarica = new TableLayoutPanel();
            PraznaKosarica.RowCount = 2;
            PraznaKosarica.ColumnCount = 1;
            PraznaKosarica.Width = 300;
            PraznaKosarica.Height = 200;
            PraznaKosarica.Margin = new Padding(0);
            PraznaKosarica.BackColor = Color.Bisque;
            PraznaKosarica.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            PraznaKosarica.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            PraznaKosarica.RowStyles.Add(new RowStyle(SizeType.Percent, 80));

            // Prvi redak: X za zatvaranje
            Label Zatvori = new Label();
            Zatvori.Text = "X";
            Zatvori.Font = new Font("Gabriola", 12, FontStyle.Bold);
            Zatvori.Height = 40;
            Zatvori.TextAlign = ContentAlignment.TopRight;
            Zatvori.Dock = DockStyle.Fill;
            Zatvori.Click += (sender, e) => { StavkeKosarice.Visible = false; };
            PraznaKosarica.Controls.Add(Zatvori, 0, 0);

            // Drugi redak: poruka o praznoj košarici
            Label Prazna = new Label();
            Prazna.Text = "Nema stavaka u košarici";
            Prazna.Font = new Font("Gabriola", 14, FontStyle.Bold);
            Prazna.TextAlign = ContentAlignment.MiddleCenter;
            Prazna.Dock = DockStyle.Fill;
            PraznaKosarica.Controls.Add(Prazna, 0, 1);

            // Oèisti trenutne kontrole i dodaj novi prikaz prazne košarice
            StavkeKosarice.Controls.Clear();
            StavkeKosarice.Controls.Add(PraznaKosarica);
            StavkeKosarice.AutoScroll = false;
            StavkeKosarice.VerticalScroll.Visible = false;
            StavkeKosarice.VerticalScroll.Enabled = false;
            StavkeKosarice.Visible = true;
            StavkeKosarice.Margin = new Padding(0);
            StavkeKosarice.Width = 300;
            StavkeKosarice.Height = 200;
        }

        private void SpremiNarudzbuUBazu()
        {
            try
            {
                using (mySqlConnection = new MySqlConnection(mySqlCon))
                {
                    mySqlConnection.Open();

                    using (MySqlTransaction transaction = mySqlConnection.BeginTransaction())
                    {
                        try
                        {
                            // Prvo dodajte narudžbu u tablicu orders
                            string queryNarudzba = "INSERT INTO purchases (id_customer, amount, date) VALUES (@userId, @totalAmount, @orderDate)";
                            using (MySqlCommand commandNarudzba = new MySqlCommand(queryNarudzba, mySqlConnection, transaction))
                            {
                                commandNarudzba.Parameters.AddWithValue("@userId", GetUserId());
                                commandNarudzba.Parameters.AddWithValue("@totalAmount", ukupno);
                                commandNarudzba.Parameters.AddWithValue("@orderDate", DateTime.Now);

                                commandNarudzba.ExecuteNonQuery();

                                // Dohvaæanje ID-a narudžbe koja je upravo dodana
                                long orderId = commandNarudzba.LastInsertedId;

                                // Dodajte stavke narudžbe u tablicu order_items
                                foreach (var stavka in KosaricaStavke)
                                {
                                    string queryStavke = "INSERT INTO purchase_items (purchase_id, item_name, item_price) VALUES (@orderId, @instrumentName, @instrumentPrice)";
                                    using (MySqlCommand commandStavke = new MySqlCommand(queryStavke, mySqlConnection, transaction))
                                    {
                                        commandStavke.Parameters.AddWithValue("@orderId", orderId);
                                        commandStavke.Parameters.AddWithValue("@instrumentName", stavka.Item1);
                                        commandStavke.Parameters.AddWithValue("@instrumentPrice", stavka.Item2);

                                        commandStavke.ExecuteNonQuery();
                                    }
                                }

                                // Smanjite stanje novèanika
                                string queryUpdateWallet = "UPDATE users SET wallet = wallet - @totalAmount WHERE user_id = @userId";
                                using (MySqlCommand commandUpdateWallet = new MySqlCommand(queryUpdateWallet, mySqlConnection, transaction))
                                {
                                    commandUpdateWallet.Parameters.AddWithValue("@totalAmount", ukupno);
                                    commandUpdateWallet.Parameters.AddWithValue("@userId", GetUserId());

                                    commandUpdateWallet.ExecuteNonQuery();
                                }

                                // Potvrdite transakciju
                                transaction.Commit();
                                MessageBox.Show("Narudžba uspješno izvršena!");
                                KosaricaStavke.Clear();
                                AžurirajPrikazKosarice();
                                UpdateWallet();
                            }
                        }
                        catch (Exception ex)
                        {
                            // Otkazivanje transakcije u sluèaju greške
                            transaction.Rollback();
                            MessageBox.Show("Greška prilikom spremanja narudžbe u bazu: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom povezivanja s bazom: " + ex.Message);
            }
        }
        // zbog "osvježavanja" stanja novèanika
        public void UpdateWallet()
        {
            ProvjeriStanjeNovcanika();
        }

        // Pomocna metoda za dohvaæanje ID-a trenutno prijavljenog admina
        private int GetUserId()
        {
            int userId = -1;
            using (MySqlCommand command = new MySqlCommand("SELECT user_id FROM users WHERE username = @username", mySqlConnection))
            {
                command.Parameters.AddWithValue("@username", loggedInUserUsername);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    userId = Convert.ToInt32(result);
                }
            }
            return userId;
        }

        private bool ProvjeriStanjeNovcanika()
        {

            double walletBalance = 0;
            mySqlConnection = new(mySqlCon);
            using (mySqlConnection)
            {
                mySqlConnection.Open();
                string query = "SELECT wallet FROM users WHERE username = @username";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                using (command)
                {
                    command.Parameters.AddWithValue("@username", loggedInUserUsername);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        walletBalance = Convert.ToDouble(result);
                        iznos_novcanika.Text = walletBalance.ToString();
                    }
                }
                return walletBalance >= ukupno;
            }
        }

        private void ProsleKupnje_Click_1(object sender, EventArgs e)
        {
            PastPurchasesUser prosleKupnje = new(loggedInUserUsername, loggedInUserFirstName);
            prosleKupnje.Show();
            this.Close();
        }
    }
}
