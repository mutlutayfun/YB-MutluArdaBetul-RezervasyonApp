using Microsoft.EntityFrameworkCore;
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
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.UI
{
    public partial class Frm_RezervasyonBilgi : Form
    {
        private readonly AppDbContext _context;
        private readonly BookingService _bookingService;
        private readonly HotelService _hotelService;
        private readonly GuestService _guestService;
        private readonly PaymentService _paymentService;

        public Frm_RezervasyonBilgi()
        {
            InitializeComponent();
            _context = new AppDbContext();
            GuestRepository gRepo = new GuestRepository(_context);
            _guestService = new GuestService(gRepo);
            BookingRepository bRepo = new BookingRepository(_context);
            _bookingService = new BookingService(bRepo);
            PaymentRepository pRepo = new PaymentRepository(_context);
            _paymentService = new PaymentService(pRepo);
            HotelRepository hRepo = new HotelRepository(_context);
            _hotelService = new HotelService(hRepo);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstRezervasyon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GetReservations()
        {

            var reservations = from booking in _context.Bookings
                               join hotel in _context.Hotels on booking.Id equals hotel.Id
                               join roomType in _context.RoomTypes on booking.RoomTypeId equals roomType.Id
                               join guestbooking in _context.GuestBookings on booking.Id equals guestbooking.Id
                               join guest in _context.Guests on guestbooking.Id equals guest.Id
                               select new
                               {
                                   ReferansNo=booking.Id,
                                   Otel = hotel.Name,
                                   OdaTipi = roomType,
                                   Giris=booking.CheckinDate.ToString(),
                                   Cıkıs=booking.CheckoutDate.ToString(),
                                   Tutar=booking.TotalPrice.ToString()
                               };

            lstRezervasyon.DataSource = reservations.ToList();


        }

        private void Frm_RezervasyonBilgi_Load(object sender, EventArgs e)
        {
            GetReservations();
        }
    }
}