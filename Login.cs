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
            // autentifikacija
            //// dohvaćamo vrijednosti koje je korisnik upisao
            string username = TextBoxUsername.Text.ToString();
            string password = TextBoxPassword.Text.ToString();
            object role = RoleComboBox.SelectedItem;
            string role_status = Convert.ToString(role);

            if (username == "" || password == "")
            {
                MessageBox.Show("Korisničko ime i lozinka su obavezni!");
                return;
            }
            else if (role_status == "")
            {
                MessageBox.Show("Odaberite razinu prijave!");
                return;

            }
            else
            {
                // logika prijave
                // ako se prijavljuje admin
                if (role_status == "Administrator")
                {
                    try
                    {
                        // dohvatiti iz baze podatke
                        MySqlConnection mySqlConnection = new(mySqlCon);
                        using (mySqlConnection)
                        {
                            mySqlConnection.Open();
                            string query = "select * from admin where username = @username and password = @password";
                            MySqlCommand command = new(query, mySqlConnection);
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            MySqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                string first_name = reader["first_name"].ToString();
                                string last_name = reader["last_name"].ToString();
                                string username_admin = reader["username"].ToString();
                                this.Hide();
                                HomeAdmin homeAdmin = new(username_admin, first_name);
                                homeAdmin.Show();
                            }
                            else
                            {
                                MessageBox.Show("Neispravno korisničko ime ili lozinka!");
                            }
                        }
                        mySqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (role_status == "Korisnik")
                {
                    try
                    {
                        // dohvatiti iz baze status prijave odnosno registracije
                        // ako mi je status odobren odobren je pristup, ako nije nema pristupa i
                        // ispisuje se poruka da korisnik još nije odobren

                        // dohvaćamo korisnika iz baze koji se poklapa sa unesenim podacima
                        // konekcija na bazu
                        MySqlConnection mySqlConnection = new(mySqlCon);
                        using (mySqlConnection)
                        {
                            mySqlConnection.Open();
                            string query = "select * from users where username = @username and @password = password";
                            MySqlCommand command = new(query, mySqlConnection);
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            MySqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                // pretvara u string ono što je dohvaćeno iz baze
                                string first_name = reader["first_name"].ToString();
                                string last_name = reader["last_name"].ToString();
                                string userStatus = reader["status"].ToString();
                                string username_user = reader["username"].ToString();
                                // ako je status nije odobren ispiši poruku
                                if (userStatus == "nije odobren")
                                {
                                    MessageBox.Show("Administrator vas još nije odobrio!");
                                    return;
                                }
                                else if (userStatus == "odobren")
                                {
                                    this.Hide();
                                    HomeUser homeUser = new(username_user, first_name);
                                    homeUser.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Dogodila se greška!");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Neispravno korisničko ime ili lozinka!");
                                return;
                            }
                        }
                        mySqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // zatvara aplikaciju
            Application.Exit();
        }

        private void Registracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // vodi me na registraciju
            SignUp signUp = new();
            this.Hide();
            signUp.Show();
        }

        private void BezPrijave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // vodi me u home bez prijave
            Home home = new();
            this.Hide();
            home.Show();
        }


        private void PrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = !PrikaziLozinku.Checked;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
