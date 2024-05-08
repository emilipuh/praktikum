using System;
using System.Collections;
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
    public partial class SignUp : Form
    {
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        public SignUp()
        {
            InitializeComponent();
            TextBoxLozinka.UseSystemPasswordChar = true;
            TextBoxLozinkaPotvrda.UseSystemPasswordChar = true;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Registracija_Click_1(object sender, EventArgs e)
        {
            // registracija u bazu
            // dohvaćamo inpute od korisnika
            string ime = TextBoxIme.Text.Trim(); // trim miče razmake
            string prezime = TextBoxPrezime.Text.Trim();
            string korisnicko_ime = TextBoxKorisnickoIme.Text.Trim();
            string lozinka = TextBoxLozinka.Text.Trim();
            string lozinka_potrvda = TextBoxLozinkaPotvrda.Text.Trim();
            object role_comboBox = RazinaComboBox.SelectedItem;
            string role_status = Convert.ToString(role_comboBox); // vrijednost comboboxa
            int iznos_novcanika = 0;

            string status_pristupa; // po defaultu nema pristup

            if (ime == "" || prezime == "" || korisnicko_ime == "" || lozinka == "" || lozinka_potrvda == "")
            {
                MessageBox.Show("Sva polja moraju biti ispunjena!");
                return;
            }
            else if (lozinka != lozinka_potrvda)
            {
                MessageBox.Show("Lozinke se ne podudaraju!");
                return;
            }
            else if (role_status == "")
            {
                MessageBox.Show("Odaberite razinu prijave");
                return;
            }
            else
            {
                // logika registracije
                try
                {
                    MySqlConnection mySqlConnection = new(mySqlCon); // instanca baze
                    using (mySqlConnection)
                    {
                        // if koji provjerava da li se ubacuje admin ili korisnik
                        if (role_status == "Korisnik")
                        {
                            // ako se u registraciji odabere u combo boxu korisnik
                            status_pristupa = "nije odobren";
                            mySqlConnection.Open(); // otvaramo konekciju
                            string queryUser = "INSERT INTO users (username, password, first_name, last_name, status, wallet) values (@username, @pass, @fname, @lname, @status, @wallet)"; // pišemo upit
                            MySqlCommand command = new(queryUser, mySqlConnection);

                            command.Parameters.AddWithValue("@username", korisnicko_ime);
                            command.Parameters.AddWithValue("@pass", lozinka);
                            command.Parameters.AddWithValue("@fname", ime);
                            command.Parameters.AddWithValue("@lname", prezime);
                            command.Parameters.AddWithValue("@status", status_pristupa);
                            command.Parameters.AddWithValue("@wallet", iznos_novcanika);

                            int status = command.ExecuteNonQuery();
                            if (status > 0 && status_pristupa == "nije odobren")
                            {
                                MessageBox.Show("Uspješna registracija, " + ime + "! Molimo sačekajte da vas administrator odobri!");
                                mySqlConnection.Close();
                                Login login = new();
                                this.Hide();
                                login.Show();
                            }
                            else
                            {
                                MessageBox.Show("Greška prilikom registracije!");
                                return;
                            }
                        }
                        else if (role_status == "Administrator")
                        {
                            // ako mi je role status admin
                            mySqlConnection.Open();
                            string queryAdmin = "INSERT INTO admin (username, password, first_name, last_name, wallet) values (@username, @pass, @fname, @lname, @wallet)";
                            MySqlCommand command = new(queryAdmin, mySqlConnection);

                            command.Parameters.AddWithValue("@username", korisnicko_ime);
                            command.Parameters.AddWithValue("@pass", lozinka);
                            command.Parameters.AddWithValue("@fname", ime);
                            command.Parameters.AddWithValue("@lname", prezime);
                            command.Parameters.AddWithValue("@wallet", iznos_novcanika);

                            int status = command.ExecuteNonQuery();
                            if (status > 0)
                            {
                                MessageBox.Show("Uspješna registracija, administratoru " + ime + "!");
                                mySqlConnection.Close();
                                HomeAdmin home = new(korisnicko_ime, ime);
                                this.Hide();
                                home.Show();
                            }
                            else
                            {
                                MessageBox.Show("Greška prilikom registracije!");
                                return;
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

        private void Prijava_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new();
            this.Hide();
            loginForm.Show();
        }

        private void BezRegistracije_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new();
            this.Hide();
            home.Show();
        }


        private void PrikaziLozinku_CheckedChanged_1(object sender, EventArgs e)
        {

            TextBoxLozinka.UseSystemPasswordChar = !PrikaziLozinku.Checked;
            TextBoxLozinkaPotvrda.UseSystemPasswordChar = !PrikaziLozinku.Checked;
        }
    }
}
