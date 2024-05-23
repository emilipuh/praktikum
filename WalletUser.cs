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
    public partial class WalletUser : Form
    {
        private readonly string loggedInUserUsername;
        private readonly string loggedInUserFirstName;
        private readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=;";
        MySqlConnection mySqlConnection;
        public WalletUser(string loggedInUserUsername, string loggedInUserFirstName)
        {
            this.loggedInUserUsername = loggedInUserUsername;
            this.loggedInUserFirstName = loggedInUserFirstName;
            InitializeComponent();
        }

        private void WalletUser_Load(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection = new(mySqlCon);
                using(mySqlConnection)
                {
                    mySqlConnection.Open();
                    string query = "SELECT wallet FROM users WHERE username = @username";
                    MySqlCommand command = new(query, mySqlConnection);
                    using(command)
                    {
                        command.Parameters.AddWithValue("@username", loggedInUserUsername);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            TrenutniIznos.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Korisnik nije pronađen.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvatanja stanja novčanika: " + ex.Message);
            }
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

                string query_userId = "SELECT user_id FROM users WHERE username = @username";
                using MySqlCommand command_userId = new(query_userId, mySqlConnection);

                command_userId.Parameters.AddWithValue("@username", loggedInUserUsername);
                object result = command_userId.ExecuteScalar();
                if (result != null)
                {
                    int userId = Convert.ToInt32(result);

                    string query_update = "UPDATE users SET wallet = @wallet WHERE user_id = @user_id";
                    using MySqlCommand command_update = new(query_update, mySqlConnection);

                    command_update.Parameters.AddWithValue("@wallet", ukupni_iznos);
                    command_update.Parameters.AddWithValue("@user_id", userId);
                    int rowsAffected = command_update.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Stanje novčanika je uspješno ažurirano.");
                        TrenutniIznos.Text = ukupni_iznos.ToString();
                        HomeUser home = new(loggedInUserUsername, loggedInUserFirstName);
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
                    MessageBox.Show("Korisnik nije pronađen.");

                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom ažuriranja stanja novčanika: " + ex.Message);
            }

        }

        private void Ponisti_Click(object sender, EventArgs e)
        {
            HomeUser home = new(loggedInUserUsername, loggedInUserFirstName);
            home.Show();
            this.Hide();
        }
    }
}
