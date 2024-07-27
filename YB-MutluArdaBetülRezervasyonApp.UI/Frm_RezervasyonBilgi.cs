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


        private List<Guid> _newGuestIds;

        public Frm_RezervasyonBilgi(List<Guid> newGuestIds)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _newGuestIds = newGuestIds;
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
            try
            {
                var bookingsQuery = from gb in _context.GuestBookings
                                    join b in _context.Bookings on gb.BookingId equals b.Id
                                    join g in _context.Guests on gb.GuestId equals g.Id
                                    join r in _context.Rooms on b.RoomId equals r.Id
                                    join rt in _context.RoomTypes on b.RoomTypeId equals rt.Id
                                    join h in _context.Hotels on r.HotelId equals h.Id
                                    join p in _context.Payments on b.Id equals p.BookingId
                                    where _newGuestIds.Contains(g.Id)
                                    orderby g.CreateAt descending
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

                var bookings = bookingsQuery.ToList();

                lstRezervasyon.Items.Clear();

                foreach (var booking in bookings)
                {
                    lstRezervasyon.Items.Add($"TC No: {booking.TcNo}");
                    lstRezervasyon.Items.Add($"Misafir Adı: {booking.MisafirAdi}");
                    lstRezervasyon.Items.Add($"Misafir Soyadı: {booking.MisafirSoyad}");
                    lstRezervasyon.Items.Add($"Otel Adı: {booking.OtelAdi}");
                    lstRezervasyon.Items.Add($"Oda Tipi: {booking.OdaTipi}");
                    lstRezervasyon.Items.Add($"Oda No: {booking.OdaNo}");
                    lstRezervasyon.Items.Add($"Gecelik Ücret: {booking.GecelikUcret?.ToString("C")}");
                    lstRezervasyon.Items.Add($"Tutar: {booking.Tutar?.ToString("C")}");
                    lstRezervasyon.Items.Add($"Giriş Tarihi: {booking.GirisTarihi.ToShortDateString()}");
                    lstRezervasyon.Items.Add($"Çıkış Tarihi: {booking.CikisTarihi.ToShortDateString()}");
                    lstRezervasyon.Items.Add($"Ödeme Şekli: {booking.OdemeSekli}");

                    lstRezervasyon.Items.Add(new string('-', 50));
                }

                if (!bookings.Any())
                {
                    lstRezervasyon.Items.Add("Yeni misafir bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void Frm_RezervasyonBilgi_Load(object sender, EventArgs e)
        {
            _context.SaveChanges();
            GetReservations();
        }
    }
}