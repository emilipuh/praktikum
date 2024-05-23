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
    public partial class Products : Form
    {
        private readonly string loggedInAdminUsername;
        private readonly string loggedInAdminFirstName;
        private int instrumentId;
        readonly string mySqlCon = "server=127.0.0.1; user=root; database=musicShop; password=";
        MySqlConnection mySqlConnection;
        public Products(string loggedInAdminUsername, string loggedInAdminFirstName)
        {
            this.loggedInAdminUsername = loggedInAdminUsername;
            this.loggedInAdminFirstName = loggedInAdminFirstName;
            InitializeComponent();
        }

        private void PopulateDataGridView()
        {
            try
            {
                // dohvati sve proizvode iz baze
                mySqlConnection = new(mySqlCon);
                string query = "select instrument_id, instrument_name, instrument_price, instrument_category from instruments";
                MySqlDataAdapter command_adapter = new(query, mySqlConnection);
                DataTable dataTable = new();
                command_adapter.Fill(dataTable);
                PopisProizvoda.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
            finally { mySqlConnection.Close(); }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            PopisProizvoda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Natrag_Click(object sender, EventArgs e)
        {
            HomeAdmin home = new(loggedInAdminUsername, loggedInAdminFirstName);
            home.Show();
            this.Close();
        }

        private void DodajNovi_Click(object sender, EventArgs e)
        {
            InsertProduct newProduct = new(loggedInAdminUsername, loggedInAdminFirstName);
            newProduct.Show();
            this.Close();
        }

        private void Obrisi_Click(object sender, EventArgs e)
        {
            if (PopisProizvoda.SelectedRows.Count > 0)
            {
                int instrumentId = Convert.ToInt32(PopisProizvoda.SelectedRows[0].Cells["instrument_id"].Value);

                try
                {
                    mySqlConnection = new(mySqlCon);
                    mySqlConnection.Open();
                    string query = "delete from instruments where instrument_id = @instrument_id";
                    MySqlCommand command = new(query, mySqlConnection);
                    command.Parameters.AddWithValue("@instrument_id", instrumentId);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Proizvod je uspješno obrisan!");
                        PopulateDataGridView(); // osvježi mi datagrid
                    }
                    else
                    {
                        MessageBox.Show("Neuspješno brisanje proizvoda!");
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
                MessageBox.Show("Odaberite proizvod koji želite obrisati");
            }
        }

        private void Uredi_Click(object sender, EventArgs e)
        {
            if (PopisProizvoda.SelectedRows.Count > 0)
            {
                instrumentId = Convert.ToInt32(PopisProizvoda.SelectedRows[0].Cells["instrument_id"].Value);

                EditInstrumentData editData = new(loggedInAdminUsername, loggedInAdminFirstName, instrumentId);
                editData.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Odaberite proizvod koji želite urediti");
            }
        }

        private void PopisProizvoda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
