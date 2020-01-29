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

            string guestQuery = "INSERT INTO reservations (DateIn, DateOut, RoomNumber, GuestId, RoomType) " +
                "VALUES (@DateIn, @DateOut, @RoomNumber, @GuestId, @RoomType); "+
                "INSERT INTO guests (Id, Name, Surname, Phone, RoomNumber) " +
                "VALUES (@GuestId, @Name, @Surname, @Phone, @RoomNumber)"; 


            Guest_Form form = new Guest_Form();

            using(Connection = new MySqlConnection(ConnectionString))
            using(MySqlCommand command = new MySqlCommand(guestQuery, Connection))
            using(MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                Connection.Open();
               
                command.Parameters.AddWithValue("@DateIn", dtTmPickArrival.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@DateOut", dtTmPickDeparture.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@RoomNumber", txtbxRoomNumber.Text);
                command.Parameters.AddWithValue("@RoomType", cmbBxRoomSize.SelectedIndex + 1);
                command.Parameters.AddWithValue("@GuestId", txtbxGuestId.Text);
                command.Parameters.AddWithValue("@Name", txtBxName.Text);
                command.Parameters.AddWithValue("@Surname", txtBxSurname.Text);
                command.Parameters.AddWithValue("@Phone", txtBxPhone.Text);

                command.ExecuteNonQuery();
            }
            PopulateReservations();
            
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string guestQuery = "DELETE FROM reservations WHERE Id = @Id";


            Guest_Form form = new Guest_Form();

            using (Connection = new MySqlConnection(ConnectionString))
            using (MySqlCommand command = new MySqlCommand(guestQuery, Connection))
            {
                Connection.Open();

                command.Parameters.AddWithValue("@Id", grdViewReservations.SelectedCells[0].Value);
                

                command.ExecuteNonQuery();
            }
            PopulateReservations();
        }

        private void dtTmPickDeparture_ValueChanged(object sender, EventArgs e)
        {
            DateTime departure = dtTmPickDeparture.Value;
            DateTime  arrival= dtTmPickArrival.Value;

            TimeSpan ts = departure - arrival;

            txtDaysAmount.Text = ts.Days.ToString();
        }
    }
}
