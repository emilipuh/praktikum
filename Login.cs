using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MusicShop
{
    public partial class Login : Form
    {
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";

        public Login()
        {
            InitializeComponent();
            TextBoxPassword.UseSystemPasswordChar = true;
        }

        private void Prijava_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text.Trim();
            string password = TextBoxPassword.Text.Trim();
            string role = RoleComboBox.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Korisničko ime i lozinka su obavezni!");
                return;
            }
            else if (string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Odaberite razinu prijave!");
                return;
            }
            else
            {
                string query = "";
                string columnName = "";
                string formName = "";

                if (role == "Administrator")
                {
                    query = "SELECT * FROM admin WHERE username = @username AND password = @password";
                    columnName = "first_name";
                    formName = "HomeAdmin";
                }
                else if (role == "Korisnik")
                {
                    query = "SELECT * FROM users WHERE username = @username AND password = @password";
                    columnName = "first_name";
                    formName = "HomeUser";
                }
                else
                {
                    return;
                }

                try
                {
                    using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlCon))
                    {
                        mySqlConnection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                        {
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string firstName = reader[columnName].ToString();
                                    this.Hide();
                                    Form homeForm = (Form)Activator.CreateInstance(Type.GetType("MusicShop." + formName), username, firstName);
                                    homeForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Neispravno korisničko ime ili lozinka!");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }

        private void BezPrijave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void PrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = !PrikaziLozinku.Checked;
        }
    }
}