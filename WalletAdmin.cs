using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class WalletAdmin : Form
    {
        private readonly string loggedInAdminUsername;
        private readonly string loggedInAdminFirstName;
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";

        public WalletAdmin(string loggedInAdminUsername, string loggedInAdminFirstName)
        {
            InitializeComponent();
            this.loggedInAdminUsername = loggedInAdminUsername;
            this.loggedInAdminFirstName = loggedInAdminFirstName;
        }

        private void WalletAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                // Vuci stanje novcanika iz baze
                using MySqlConnection mySqlConnection = new(mySqlCon);

                mySqlConnection.Open();
                string query = "SELECT wallet FROM admin WHERE username = @username";
                using MySqlCommand command = new(query, mySqlConnection);

                command.Parameters.AddWithValue("@username", loggedInAdminUsername);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    TrenutniIznos.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Admin nije pronađen.");
                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvatanja stanja novčanika: " + ex.Message);
            }
        }

        private void Ponisti_Click(object sender, EventArgs e)
        {
            HomeAdmin home = new(loggedInAdminUsername, loggedInAdminFirstName);
            home.Show();
            this.Hide();
        }

        private void Unesi_Click(object sender, EventArgs e)
        {
            string upisani_iznos_string = UpisaniIznos.Text.Trim();

            if (string.IsNullOrEmpty(upisani_iznos_string))
            {
                MessageBox.Show("Unesite iznos kojim želite ažurirati stanje novčanika.");
                return;
            }

            try
            {
                double upisani_iznos = Convert.ToDouble(upisani_iznos_string);
                double trenutni_iznos = Convert.ToDouble(TrenutniIznos.Text);
                double ukupni_iznos = trenutni_iznos + upisani_iznos; 

                using MySqlConnection mySqlConnection = new(mySqlCon);

                mySqlConnection.Open();

                string query_adminId = "SELECT admin_id FROM admin WHERE username = @username";
                using MySqlCommand command_adminId = new(query_adminId, mySqlConnection);

                command_adminId.Parameters.AddWithValue("@username", loggedInAdminUsername);
                object result = command_adminId.ExecuteScalar();
                if (result != null)
                {
                    int adminId = Convert.ToInt32(result);

                    string query_update = "UPDATE admin SET wallet = @wallet WHERE admin_id = @admin_id";
                    using MySqlCommand command_update = new(query_update, mySqlConnection);

                    command_update.Parameters.AddWithValue("@wallet", ukupni_iznos);
                    command_update.Parameters.AddWithValue("@admin_id", adminId);
                    int rowsAffected = command_update.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Stanje novčanika je uspješno ažurirano.");
                        TrenutniIznos.Text = ukupni_iznos.ToString();
                        HomeAdmin home = new(loggedInAdminUsername, loggedInAdminFirstName);
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Neuspješno ažuriranje stanja novčanika.");
                    }
                }

                else
                {
                    MessageBox.Show("Admin nije pronađen.");

                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom ažuriranja stanja novčanika: " + ex.Message);
            }
        }
    }
}
