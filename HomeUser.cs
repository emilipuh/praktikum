using MySql.Data.MySqlClient;

namespace MusicShop
{
    public partial class HomeUser : Form
    {
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        private readonly string loggedInUserUsername; // privatna varijabla koja prati koji je korisnik ulogiran
        private readonly string loggedInUserFirstName; // privatna varijabla koja prati koji je korisnik ulogiran
        public HomeUser(string loggedInUserUsername, string loggedInUserFirstName) // konstruktor
        {
            this.loggedInUserFirstName = loggedInUserFirstName;
            this.loggedInUserUsername = loggedInUserUsername; // koristimo dalje u kodu za pristup informacijama trenutno ulogiranog usera
            InitializeComponent();
        }
        private void MusicShop_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = 60;
            Dropdown.Text = "Dobrodošli, " + loggedInUserFirstName + "!";

            try
            {
                using MySqlConnection mySqlConnection = new(mySqlCon);

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


            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvatanja stanja novèanika: " + ex.Message);
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
        public void UpdateUserData()
        {
            Dropdown.Text = "Dobrodošli, " + loggedInUserFirstName + "!";
        }
    }
}
