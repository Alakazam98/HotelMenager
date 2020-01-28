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
    public partial class Rooms_Form : Form
    {
        public MySqlConnection Connection { get; set; }

        public string ConnectionString { get; set; }
        public Rooms_Form()
        {
            InitializeComponent();
            ConnectionString = ConfigurationManager.ConnectionStrings["HotelMenager.Properties.Settings.hotelmanagerdatabaseConnectionString1"].ConnectionString;
        }

        private void Rooms_Form_Load(object sender, EventArgs e)
        {
            PopulateAvailableRooms();
        }

        private void PopulateAvailableRooms()
        {

            using (Connection = new MySqlConnection(ConnectionString))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM rooms WHERE Availability = \"YES\" ", Connection))
            {
                DataTable table = new DataTable();

                adapter.Fill(table);

                lstbxAvailableRooms.DataSource = table;
                lstbxAvailableRooms.DisplayMember = "RoomNumber";
                lstbxAvailableRooms.ValueMember = "RoomNumber";
            }
        }

        private void PopulateTakenRooms()
        {
            using (Connection = new MySqlConnection(ConnectionString))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM rooms WHERE Availability = \"NO\" ", Connection))
            {
                DataTable table = new DataTable();

                adapter.Fill(table);

                lstbxAvailableRooms.DataSource = table;
                lstbxAvailableRooms.DisplayMember = "RoomNumber";
                lstbxAvailableRooms.ValueMember = "RoomNumber";
            }
        }
    }
}
