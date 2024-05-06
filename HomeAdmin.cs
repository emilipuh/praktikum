using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MusicShop
{
    public partial class HomeAdmin : Form
    {
        private readonly string loggedInAdminUsername; // za username
        private readonly string loggedInAdminFirstName; // za ime
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";

        public HomeAdmin(string loggedInAdminUsername, string loggedInAdminFirstName)
        {
            InitializeComponent();
            this.loggedInAdminUsername = loggedInAdminUsername;
            this.loggedInAdminFirstName = loggedInAdminFirstName;
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = 60;
            TrenutniKorisnik.Text = "Dobrodošli, " + loggedInAdminFirstName + "!";

            try
            {
                // Dohvaćanje stanja novčanika iz baze za trenutno prijavljenog admina
                using MySqlConnection mySqlConnection = new(mySqlCon);

                mySqlConnection.Open();
                string query_adminId = "SELECT admin_id FROM admin WHERE username = @username";
                using MySqlCommand command_adminId = new(query_adminId, mySqlConnection);

                command_adminId.Parameters.AddWithValue("@username", loggedInAdminUsername);
                object result = command_adminId.ExecuteScalar();

                if (result != null)
                {
                    int adminId = Convert.ToInt32(result);

                    string query_wallet = "SELECT wallet FROM admin WHERE admin_id = @admin_id";
                    using MySqlCommand command_wallet = new(query_wallet, mySqlConnection);

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
                    mySqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Nije pronađen admin s korisničkim imenom: " + loggedInAdminUsername);
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
    }
}
