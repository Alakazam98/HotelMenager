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
using System.Configuration;

namespace HotelMenager
{
    public partial class Reservations_Form : Form
    {


        public MySqlConnection Connection { get; set; }

        public string ConnectionString { get; set; }
        public Reservations_Form()
        {
            InitializeComponent();
        }

        private void Reservations_Form_Load(object sender, EventArgs e)
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["HotelMenager.Properties.Settings.hotelmanagerdatabaseConnectionString1"].ConnectionString;
            PopulateReservations();
        }

        private void PopulateReservations()
        {
            string query = "SELECT a.Id, b.Name, b.Surname, b.Phone, a.DateIn, a.DateOut, a.RoomNumber FROM reservations a " +
                "LEFT JOIN guests b ON a.GuestId = b.Id";


            using (Connection = new MySqlConnection(ConnectionString))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, Connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                grdViewReservations.DataSource = table;

            }

        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO reservations (DateIn, DateOut, RoomNumber ";


            using(Connection = new MySqlConnection(ConnectionString))
            using(MySqlCommand command = new MySqlCommand(query, Connection))
            {
                Connection.Open();




            }
        }
    }
}
