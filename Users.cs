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
    public partial class Users : Form
    {
        private readonly string loggedInAdminUsername;
        private readonly string loggedInAdminFirstName;
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        MySqlConnection mySqlConnection;

        public Users(string loggedInAdminUsername, string loggedInAdminFirstName)
        {
            InitializeComponent();
            this.loggedInAdminUsername = loggedInAdminUsername;
            this.loggedInAdminFirstName = loggedInAdminFirstName;
        }

        private void Natrag_Click(object sender, EventArgs e)
        {
            HomeAdmin home = new(loggedInAdminUsername, loggedInAdminFirstName);
            this.Hide();
            home.Show();
        }
        private void PopulateDataGridView()
        {
            // dohvati sve korisnike iz baze
            try
            {
                mySqlConnection = new(mySqlCon);
                string query = "select user_id, first_name, last_name, status, wallet from users";
                MySqlDataAdapter command = new(query, mySqlConnection);
                DataTable dataTable = new();
                command.Fill(dataTable);
                PrikazKorisnika.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
            finally { mySqlConnection.Close(); }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void Obrisi_Click(object sender, EventArgs e)
        {
            if (PrikazKorisnika.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(PrikazKorisnika.SelectedRows[0].Cells["user_id"].Value);

                try
                {
                    mySqlConnection = new(mySqlCon);
                    mySqlConnection.Open();
                    string query = "delete from users where user_id = @user_id";
                    MySqlCommand command = new(query, mySqlConnection);
                    command.Parameters.AddWithValue("@user_id", userId);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Korisnik je uspješno obrisan!");
                        PopulateDataGridView(); // osvježi mi datagrid
                    }
                    else
                    {
                        MessageBox.Show("Neuspješno brisanje korisnika!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška: " + ex.Message);
                }
                finally { mySqlConnection.Close(); }
            }
            else
            {
                MessageBox.Show("Odaberite korisnika kojeg želite obrisati");
            }
        }
        private void PromijeniStatus_Click(object sender, EventArgs e)
        {
            if (PrikazKorisnika.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(PrikazKorisnika.SelectedRows[0].Cells["user_id"].Value);

                try
                {
                    // provjera statusa korisnika
                    string query_status = "select status from users where user_id = @user_id";

                    using MySqlCommand command_status = new(query_status, mySqlConnection);
                    command_status.Parameters.AddWithValue("@user_id", userId);

                    if (mySqlConnection.State == ConnectionState.Closed)
                        mySqlConnection.Open();

                    string status = command_status.ExecuteScalar().ToString();

                    // ako je status korisnika "nije odobren", promijeni ga u "odobren", i obrnuto
                    string newStatus = (status == "nije odobren") ? "odobren" : "nije odobren";

                    string query_update = "UPDATE users SET status = @newStatus WHERE user_id = @user_id";

                    using MySqlCommand command_update = new(query_update, mySqlConnection);

                    command_update.Parameters.AddWithValue("@user_id", userId);
                    command_update.Parameters.AddWithValue("@newStatus", newStatus);

                    int rowsAffected = command_update.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Status korisnika je uspješno promijenjen u '{newStatus}'!");
                        PopulateDataGridView(); // osvježi prikaz korisnika
                    }
                    else
                    {
                        MessageBox.Show("Neuspješna promjena statusa korisnika!");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška: " + ex.Message);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Odaberite korisnika čiji status želite promijeniti.");
            }
        }

        private void PrikazKorisnika_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

