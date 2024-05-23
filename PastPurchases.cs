using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class PastPurchases : Form
    {
        private readonly string loggedInAdminUsername; // za username
        private readonly string loggedInAdminFirstName; // za ime
        private int purchaseId;
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        private int adminId;

        public PastPurchases(string loggedInAdminUsername, string loggedInAdminFirstName)
        {
            this.loggedInAdminUsername = loggedInAdminUsername;
            this.loggedInAdminFirstName = loggedInAdminFirstName;
            InitializeComponent();
        }

        private void PastPurchases_Load(object sender, EventArgs e)
        {
            if (DohvatiAdminId())
            {
                PopulateDataGridView();
            }
            else
            {
                MessageBox.Show("Greška: Nije moguće dohvatiti ID admina.");
            }
        }

        private bool DohvatiAdminId()
        {
            try
            {
                using (MySqlConnection mySqlConnection = new(mySqlCon))
                {
                    mySqlConnection.Open();
                    string query = "SELECT admin_id FROM admin WHERE username = @username";
                    MySqlCommand command = new(query, mySqlConnection);
                    command.Parameters.AddWithValue("@username", loggedInAdminUsername);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        adminId = Convert.ToInt32(result);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvatanja ID-a admina: " + ex.Message);
            }
            return false;
        }

        private void PopulateDataGridView()
        {
            try
            {
                using (MySqlConnection mySqlConnection = new(mySqlCon))
                {
                    string query = "SELECT * FROM purchases WHERE id_customer = @id_customer";
                    MySqlDataAdapter dataAdapter = new(query, mySqlConnection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@id_customer", adminId);

                    DataTable dataTable = new();
                    dataAdapter.Fill(dataTable);
                    Racuni.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void Racuni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Natrag_Click(object sender, EventArgs e)
        {
            HomeAdmin home = new(loggedInAdminUsername, loggedInAdminFirstName);
            home.Show();
            this.Close();
        }

        private void PrikaziRacun_Click(object sender, EventArgs e)
        {
            if (Racuni.SelectedRows.Count > 0)
            {
                purchaseId = Convert.ToInt32(Racuni.SelectedRows[0].Cells["purchase_id"].Value);

                PurchaseDetails kupnja = new(loggedInAdminUsername, loggedInAdminFirstName, purchaseId);
                kupnja.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Odaberite račun koji želite pregledati");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
