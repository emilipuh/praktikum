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
    public partial class DetailsAdmin : Form
    {
        private string loggedInAdminUsername;
        private string loggedInAdminFirstName;
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        MySqlConnection mySqlConnection;
        public DetailsAdmin(string loggedInAdminUsername, string loggedInAdminFirstName)
        {
            InitializeComponent();
            this.loggedInAdminUsername = loggedInAdminUsername;
            this.loggedInAdminFirstName = loggedInAdminFirstName;
        }

        private void Ponisti_Click(object sender, EventArgs e)
        {
            HomeAdmin home = new(loggedInAdminUsername, loggedInAdminFirstName);
            home.Show();
            this.Hide();
        }

        private void DetailsAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection = new(mySqlCon);
                using (mySqlConnection)
                {
                    mySqlConnection.Open();
                    string query = "SELECT * FROM admin WHERE username = @username";
                    using MySqlCommand command = new(query, mySqlConnection);

                    command.Parameters.AddWithValue("@username", loggedInAdminUsername);

                    using MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string username = reader["username"].ToString();
                        string first_name = reader["first_name"].ToString();
                        string last_name = reader["last_name"].ToString();
                        string pass = reader["password"].ToString();
                        // textboxevi do labela
                        KorisnickoIme.Text = username;
                        Ime.Text = first_name;
                        Prezime.Text = last_name;
                        NovaLozinka.Text = pass;
                    }
                    else
                    {
                        MessageBox.Show("Admin nije pronađen.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvaćanja podataka admina: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void KorisnickoIme_Click(object sender, EventArgs e)
        {

        }
        private void AzurirajPodatke_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TextBoxUsername.Text) &&
                    string.IsNullOrEmpty(TextBoxFirstName.Text) &&
                    string.IsNullOrEmpty(TextBoxLastName.Text) &&
                    string.IsNullOrEmpty(TextBoxNovaLozinka.Text))
                {
                    MessageBox.Show("Upišite podatak koji želite ažurirati!");
                    return;
                }

                mySqlConnection = new MySqlConnection(mySqlCon);
                using (mySqlConnection)
                {
                    if (Ime.Text == TextBoxFirstName.Text)
                    {
                        MessageBox.Show("Novo ime se mora razlikovati od starog imena!");
                        return;
                    }
                    if (Prezime.Text == TextBoxLastName.Text)
                    {
                        MessageBox.Show("Novo prezime se mora razlikovati od starog prezimena!");
                        return;
                    }
                    if (KorisnickoIme.Text == TextBoxUsername.Text)
                    {
                        MessageBox.Show("Novo korisničko ime se mora razlikovati od starog korisničkog imena!");
                        return;
                    }
                    if (NovaLozinka.Text == TextBoxNovaLozinka.Text)
                    {
                        MessageBox.Show("Nova lozinka se mora razlikovati od stare lozinke!");
                        return;
                    }

                    mySqlConnection.Open();
                    StringBuilder updateQuery = new("UPDATE admin SET ");

                    if (!string.IsNullOrEmpty(TextBoxUsername.Text)) // ako nije prazan
                    {
                        updateQuery.Append("username = @username, ");
                    }

                    if (!string.IsNullOrEmpty(TextBoxFirstName.Text))
                    {
                        updateQuery.Append("first_name = @first_name, ");
                    }

                    if (!string.IsNullOrEmpty(TextBoxLastName.Text))
                    {
                        updateQuery.Append("last_name = @last_name, ");
                    }

                    if (!string.IsNullOrEmpty(TextBoxNovaLozinka.Text))
                    {
                        updateQuery.Append("password = @pass, ");
                    }

                    updateQuery.Length -= 2; // miče zarez i razmak

                    updateQuery.Append(" WHERE username = @oldUsername");

                    using MySqlCommand command = new(updateQuery.ToString(), mySqlConnection);
                    if (!string.IsNullOrEmpty(TextBoxUsername.Text))
                    {
                        command.Parameters.AddWithValue("@username", TextBoxUsername.Text);
                    }

                    if (!string.IsNullOrEmpty(TextBoxFirstName.Text))
                    {
                        command.Parameters.AddWithValue("@first_name", TextBoxFirstName.Text);
                        loggedInAdminFirstName = TextBoxFirstName.Text;
                    }

                    if (!string.IsNullOrEmpty(TextBoxLastName.Text))
                    {
                        command.Parameters.AddWithValue("@last_name", TextBoxLastName.Text);
                    }

                    if (!string.IsNullOrEmpty(TextBoxNovaLozinka.Text))
                    {
                        command.Parameters.AddWithValue("@pass", TextBoxNovaLozinka.Text);
                    }

                    command.Parameters.AddWithValue("@oldUsername", loggedInAdminUsername);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Podaci admina su uspješno ažurirani.");
                        if (!string.IsNullOrEmpty(TextBoxUsername.Text))
                        {
                            loggedInAdminUsername = TextBoxUsername.Text;
                        }
                        else if (!string.IsNullOrEmpty(TextBoxFirstName.Text))
                        {
                            loggedInAdminFirstName = TextBoxFirstName.Text;
                        }

                        this.Hide();
                        HomeAdmin homeAdmin = new(loggedInAdminUsername, loggedInAdminFirstName);
                        homeAdmin.UpdateAdminData();
                        homeAdmin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nema podataka za ažuriranje ili nijedno polje nije uneseno.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom ažuriranja podataka admina: " + ex.Message);
            }
            finally { mySqlConnection.Close(); }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
