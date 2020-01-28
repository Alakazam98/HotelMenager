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
            PopulateTakenRooms();
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

                lstbxTakenRooms.DataSource = table;
                lstbxTakenRooms.DisplayMember = "RoomNumber";
                lstbxTakenRooms.ValueMember = "RoomNumber";
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            string query;

            switch(cmboxSize.SelectedIndex)
            {
                case 0: query = "SELECT * FROM rooms WHERE Size = 1 AND Availability = \"YES\"";
                break;
                case 1:
                query = "SELECT * FROM rooms WHERE Size = 2 AND Availability = \"YES\"";
                break;
                case 2:
                query = "SELECT * FROM rooms WHERE Size = 3 AND Availability = \"YES\"";
                break;
                case 3:
                query = "SELECT * FROM rooms WHERE Size = 4 AND Availability = \"YES\"";
                break;
                default:
                query = "SELECT * FROM rooms";
                break;
            }

            using (Connection = new MySqlConnection( ConnectionString))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, Connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                lstbxAvailableRooms.DataSource = table;
                lstbxAvailableRooms.DisplayMember = "RoomNumber";
                lstbxAvailableRooms.ValueMember = "RoomNumber";

            }

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            string query = 
                "INSERT INTO reservations(DateIn, DateOut, RoomNumber, GuestId, RoomType) " +
                "VALUES(@Today, @DateOut, @RoomNumber, @GuestId, @RoomType) ;" +
                "UPDATE rooms SET Availability = \"NO\" WHERE RoomNumber = @RoomNumber;" +
                "UPDATE guests SET RoomNumber = @RoomNumber WHERE Id = @GuestId";

            using (Connection = new MySqlConnection(ConnectionString))
            using(MySqlCommand command = new MySqlCommand(query, Connection))
            {
                Connection.Open();
                DateTime now = DateTime.UtcNow;
                string today = now.ToString("yyyy-MM-dd");
                string dateOut = now.AddDays(Double.Parse(txtbxDays.Text)).ToString("yyyy-MM-dd");
                command.Parameters.AddWithValue("@GuestId", txtbxGuestId.Text);
                command.Parameters.AddWithValue("@RoomNumber", txtbxRoomNumber.Text);
                command.Parameters.AddWithValue("@Days", txtbxDays.Text);
                command.Parameters.AddWithValue("@RoomType", cmboxSize.Text);
                command.Parameters.AddWithValue("@Today", today);
                command.Parameters.AddWithValue("@DateOut", dateOut);

                command.ExecuteNonQuery();
            }
            PopulateAvailableRooms();
            PopulateTakenRooms();
        }
    }
}
