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
    public partial class PurchaseDetailsUser : Form
    {
        private readonly string loggedInUserUsername; // za username
        private readonly string loggedInUserFirstName; // za ime
        private int purchaseId;
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        MySqlConnection connection;
        public PurchaseDetailsUser(string loggedInUserUsername, string loggedInUserFirstName, int purchaseId)
        {
            this.loggedInUserUsername = loggedInUserUsername;
            this.loggedInUserFirstName = loggedInUserFirstName;
            this.purchaseId = purchaseId;
            InitializeComponent();
        }

        private void Natrag_Click(object sender, EventArgs e)
        {
            PastPurchasesUser prosleKupnje = new(loggedInUserUsername, loggedInUserFirstName);
            prosleKupnje.Show();
            this.Close();
        }

        private void PurchaseDetailsUser_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void PopulateDataGridView()
        {
            try
            {
                connection = new MySqlConnection(mySqlCon);
                using (connection)
                {
                    connection.Open();
                    string query = "SELECT item_name, item_price FROM purchase_items WHERE purchase_id = @purchase_id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@purchase_id", purchaseId);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}
