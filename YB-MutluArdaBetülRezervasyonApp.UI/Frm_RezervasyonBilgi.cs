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
            Close();
        }

        private void lstRezervasyon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GetReservations()
        {
            var bookingsQuery = from gb in _context.GuestBookings
                                join b in _context.Bookings on gb.BookingId equals b.Id
                                join g in _context.Guests on gb.GuestId equals g.Id
                                join r in _context.Rooms on b.RoomId equals r.Id
                                join rt in _context.RoomTypes on b.RoomTypeId equals rt.Id
                                join h in _context.Hotels on r.HotelId equals h.Id
                                join p in _context.Payments on b.Id equals p.BookingId
                                orderby b.CreateAt descending // En son eklenen kaydı almak için sıralama
                                select new
                                {
                                    TcNo = g.TCNo,
                                    MisafirAdi = g.FirstName,
                                    MisafirSoyad = g.LastName,
                                    OtelAdi = h.Name,
                                    OdaTipi = rt.Name,
                                    OdaNo = r.RoomNo,
                                    GecelikUcret = rt.PricePerNight,
                                    Tutar = b.TotalPrice,
                                    GirisTarihi = b.CheckinDate,
                                    CikisTarihi = b.CheckoutDate,
                                    OdemeSekli = p.PaymentMethod
                                };

            var lastBooking = bookingsQuery.FirstOrDefault(); // En son eklenen kaydı almak için FirstOrDefault kullanıyoruz

            lstRezervasyon.Items.Clear();

            if (lastBooking != null)
            {
                
                lstRezervasyon.Items.Add($"TC No: {lastBooking.TcNo}");
                lstRezervasyon.Items.Add($"Misafir Adı: {lastBooking.MisafirAdi}");
                lstRezervasyon.Items.Add($"Misafir Soyadı: {lastBooking.MisafirSoyad}");
                lstRezervasyon.Items.Add($"Otel Adı: {lastBooking.OtelAdi}");
                lstRezervasyon.Items.Add($"Oda Tipi: {lastBooking.OdaTipi}");
                lstRezervasyon.Items.Add($"Oda No: {lastBooking.OdaNo}");
                lstRezervasyon.Items.Add($"Gecelik Ücret: {lastBooking.GecelikUcret?.ToString("C")}");
                lstRezervasyon.Items.Add($"Tutar: {lastBooking.Tutar?.ToString("C")}");
                lstRezervasyon.Items.Add($"Giriş Tarihi: {lastBooking.GirisTarihi.ToShortDateString()}");
                lstRezervasyon.Items.Add($"Çıkış Tarihi: {lastBooking.CikisTarihi.ToShortDateString()}");
                lstRezervasyon.Items.Add($"Ödeme Şekli: {lastBooking.OdemeSekli}");

                
                lstRezervasyon.Items.Add(new string('-', 50));
            }

        }

        private void Frm_RezervasyonBilgi_Load(object sender, EventArgs e)
        {
            GetReservations();
        }
    }
}