using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HotelMenager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tlstrpbtnGuests_Click(object sender, EventArgs e)
        {
            Guest_Form guest_Form = new Guest_Form();
            guest_Form.Show();
        }

        private void tlstrpbtnRooms_Click(object sender, EventArgs e)
        {
            Rooms_Form rooms_Form = new Rooms_Form();
            rooms_Form.Show();
        }

        private void tlstrpbtnReservations_Click(object sender, EventArgs e)
        {
            Reservations_Form reservations_Form = new Reservations_Form();
            reservations_Form.Show();
        }
    }
}
