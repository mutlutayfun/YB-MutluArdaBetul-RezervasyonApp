using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YB_MutluArdaBetülRezervasyonApp.Business.Services;

namespace YB_MutluArdaBetülRezervasyonApp.UI
{
    public partial class Frm_RezervasyonBilgi : Form
    {
        private readonly BookingService _bookingService;
        private readonly HotelService _hotelService;
        private readonly GuestService _guestService;
        private readonly StaffService _staffService;

        public Frm_RezervasyonBilgi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstRezervasyon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
