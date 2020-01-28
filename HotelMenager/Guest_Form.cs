using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace HotelMenager
{
    public partial class Guest_Form : Form
    {
        public MySqlConnection Connection { get; set; }

        public string ConnectionString { get; set; }


        public Guest_Form()
        {
            InitializeComponent();
            ConnectionString = ConfigurationManager.ConnectionStrings["HotelMenager.Properties.Settings.hotelmanagerdatabaseConnectionString1"].ConnectionString;
            PopulateGuests();
        }

        private void PopulateGuests()
        {


            using (Connection = new MySqlConnection(ConnectionString))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM guests", Connection))
            {

                DataTable table = new DataTable();
                adapter.Fill(table);
                guestsDataGridView.DataSource = table;


            }
        }

        private void Guest_Form_Load(object sender, EventArgs e)
        {


            PopulateGuests();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO guests(Id, Name, Surname, Phone) VALUES (@Id, @Name, @Surname, @Phone)";

            using (Connection = new MySqlConnection(ConnectionString))
            using (MySqlCommand command = new MySqlCommand(query, Connection))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@Id", guestsDataGridView.RowCount + 1);
                command.Parameters.AddWithValue("@Name", txtbxName.Text);
                command.Parameters.AddWithValue("@Surname", txtbxSurname.Text);
                command.Parameters.AddWithValue("@Phone", txtbxPhone.Text);
                command.ExecuteNonQuery();
            }
            PopulateGuests();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM guests WHERE Id = @GuestId";

            using (Connection = new MySqlConnection(ConnectionString))
            using (MySqlCommand command = new MySqlCommand(query, Connection))
            {
                Connection.Open();

                command.Parameters.AddWithValue("@GuestId", guestsDataGridView.SelectedCells[0].Value);

                command.ExecuteNonQuery();
            }
            PopulateGuests();
        }

        private void guestsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbxName.Text = (string)guestsDataGridView.SelectedCells[1].Value;
            txtbxSurname.Text = (string)guestsDataGridView.SelectedCells[2].Value;
            txtbxPhone.Text = guestsDataGridView.SelectedCells[3].Value.ToString();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxName.Text = null;
            txtbxSurname.Text = null;
            txtbxPhone.Text = null;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE guests SET Name = @Name, Surname =@Surname, Phone = @Phone WHERE Id = @Id" ;

            using (Connection = new MySqlConnection(ConnectionString))
            using (MySqlCommand command = new MySqlCommand(query, Connection))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@Id", guestsDataGridView.SelectedCells[0].Value);
                command.Parameters.AddWithValue("@Name", txtbxName.Text);
                command.Parameters.AddWithValue("@Surname", txtbxSurname.Text);
                command.Parameters.AddWithValue("@Phone", txtbxPhone.Text);
                command.ExecuteNonQuery();
            }
            PopulateGuests();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

                   string query ;


            switch (cmbBoxSearch.SelectedIndex)
            {
                case 0: query = "SELECT * FROM guests WHERE Id = @Input";
                    break;
                case 1:
                    query = "SELECT * FROM guests WHERE Name = @Input";
                    break;
                case 2:
                    query = "SELECT * FROM guests WHERE Surname = @Input";
                    break;
                case 3:
                    query = "SELECT * FROM guests WHERE Phone = @Input";
                    break;
                default:
                    query = "SELECT * FROM guests ";

                    break;
            }
            using (Connection = new MySqlConnection(ConnectionString))
            using (MySqlCommand command = new MySqlCommand(query, Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@Input", txtbxSearch.Text);
                command.ExecuteNonQuery();

                DataTable table = new DataTable();
                adapter.Fill(table);
                guestsDataGridView.DataSource = table;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGuests();
        }

        
    }
}
