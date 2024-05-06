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
    public partial class DetailsUser : Form
    {
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        private string loggedInUserUsername;
        private string loggedInUserFirstName;
        MySqlConnection mySqlConnection;
        public DetailsUser(string loggedInUserUsername, string loggedInUserFirstName)
        {
            InitializeComponent();
            this.loggedInUserUsername = loggedInUserUsername;
            this.loggedInUserFirstName = loggedInUserFirstName;
        }

        private void DetailsUser_Load(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection = new(mySqlCon);
                using (mySqlConnection)
                {
                    mySqlConnection.Open();
                    string query = "SELECT * FROM users WHERE username = @username";
                    using MySqlCommand command = new(query, mySqlConnection);

                    command.Parameters.AddWithValue("@username", loggedInUserUsername);

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
                        MessageBox.Show("Korisnik nije pronađen.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void Ponisti_Click(object sender, EventArgs e)
        {
            HomeUser home = new(loggedInUserUsername, loggedInUserFirstName);
            home.Show();
            this.Hide();
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
                    StringBuilder updateQuery = new("UPDATE users SET ");

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
                        loggedInUserFirstName = TextBoxFirstName.Text;
                    }

                    if (!string.IsNullOrEmpty(TextBoxLastName.Text))
                    {
                        command.Parameters.AddWithValue("@last_name", TextBoxLastName.Text);
                    }

                    if (!string.IsNullOrEmpty(TextBoxNovaLozinka.Text))
                    {
                        command.Parameters.AddWithValue("@pass", TextBoxNovaLozinka.Text);
                    }

                    command.Parameters.AddWithValue("@oldUsername", loggedInUserUsername);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Podaci korisnika su uspješno ažurirani.");
                        if (!string.IsNullOrEmpty(TextBoxUsername.Text))
                        {
                            loggedInUserUsername = TextBoxUsername.Text;
                        }
                        else if (!string.IsNullOrEmpty(TextBoxFirstName.Text))
                        {
                            loggedInUserFirstName = TextBoxFirstName.Text;
                        }

                        this.Hide();
                        HomeUser homeUser = new(loggedInUserUsername, loggedInUserFirstName);
                        homeUser.UpdateUserData();
                        homeUser.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nema podataka za ažuriranje ili nijedno polje nije uneseno.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom ažuriranja podataka korisnika: " + ex.Message);
            }
        }
    }
}
