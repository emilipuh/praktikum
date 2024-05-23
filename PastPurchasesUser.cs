using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class PastPurchasesUser : Form
    {
        private readonly string loggedInUserUsername; // za username
        private readonly string loggedInUserFirstName; // za ime
        private int purchaseId;
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        private int userId;

        public PastPurchasesUser(string loggedInUserUsername, string loggedInUserFirstName)
        {
            this.loggedInUserUsername = loggedInUserUsername;
            this.loggedInUserFirstName = loggedInUserFirstName;
            InitializeComponent();
        }

        private void PastPurchasesUser_Load(object sender, EventArgs e)
        {
            if (DohvatiUserId())
            {
                PopulateDataGridView();
            }
            else
            {
                MessageBox.Show("Greška: Nije moguće dohvatiti ID korisnika.");
            }
        }

        private bool DohvatiUserId()
        {
            try
            {
                using (MySqlConnection mySqlConnection = new(mySqlCon))
                {
                    mySqlConnection.Open();
                    string query = "SELECT user_id FROM users WHERE username = @username";
                    MySqlCommand command = new(query, mySqlConnection);
                    command.Parameters.AddWithValue("@username", loggedInUserUsername);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                        MessageBox.Show("user id:", userId.ToString());
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvatanja korisničkog ID-a: " + ex.Message);
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
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@id_customer", userId);

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
        private void PrikaziRacun_Click(object sender, EventArgs e)
        {
            if (Racuni.SelectedRows.Count > 0)
            {
                purchaseId = Convert.ToInt32(Racuni.SelectedRows[0].Cells["purchase_id"].Value);

                PurchaseDetails kupnja = new(loggedInUserUsername, loggedInUserFirstName, purchaseId);
                kupnja.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Odaberite račun koji želite pregledati");
            }
        }

        private void Natrag_Click_1(object sender, EventArgs e)
        {
            HomeUser home = new(loggedInUserUsername, loggedInUserFirstName);
            home.Show();
            this.Close();
        }
    }
}
