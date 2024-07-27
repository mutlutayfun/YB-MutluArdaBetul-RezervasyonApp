using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Net;
using System.Windows.Forms;
using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Services;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.UI
{
    public partial class Frm_Rezervasyon : Form
    {
        private readonly AppDbContext _context;
        private readonly GuestService _guestService;
        private readonly BookingService _bookingService;
        private readonly PaymentService _paymentService;
        private readonly HotelService _hotelService;
        private readonly RoomTypeService _roomTypeService;
        private readonly GuestBookingService _guestBookingService;
        private readonly RoomService _roomService;

        private List<Guest> _guestList;
        public List<Guid> NewGuestIds { get; set; } = new List<Guid>();
        private Booking _booking;

        public Frm_Rezervasyon()
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
            RoomTypeRepository rtRepo = new RoomTypeRepository(_context);
            _roomTypeService = new RoomTypeService(rtRepo);
            GuestBookingRepository gbRepo = new GuestBookingRepository(_context);
            _guestBookingService = new GuestBookingService(gbRepo);
            RoomRepository rRepo = new RoomRepository(_context);
            _roomService = new RoomService(rRepo);
            _guestList = new List<Guest>();


            dgvList.SelectionChanged += dgvList_SelectionChanged;//Seçili satırı ekrana getirmek için eklelndi.
            btnGuncelle.Click += btnGuncelle_Click;
        }


        private void Frm_Rezervasyon_Load(object sender, EventArgs e)
        {
            GetAllHotels();
            GetAllRoomTypes();
            GetPaymentMethod();
            BookingList();
            ClearControls();

            grpGuest.Visible = false;

            cmbHName.SelectedIndexChanged += cmbHName_SelectedIndexChanged;
            cmbOdaTipi.SelectedIndexChanged += cmbOdaTipi_SelectedIndexChanged;
            dtpGirisTarihi.ValueChanged += dtpGirisTarihi_ValueChanged;
            dtpCikisTarihi.ValueChanged += dtpCikisTarihi_ValueChanged;

        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" Hoşçakal... ");
            Application.Exit();
        }

        private int maxGuestCount = 1;
        private void btnGuestSave_Click(object sender, EventArgs e)
        {
            try
            {
                var guestCount = (int)nmrGuestNumber.Value;

                if (guestCount > 0)
                {
                    if (guestCount > 5)
                    {
                        MessageBox.Show("Maksimum misafir sayısına ulaşıldı. Daha fazla misafir eklenemez.");
                        return;
                    }

                    if (guestCount >= maxGuestCount)
                    {
                        Guest guest = new Guest()
                        {
                            TCNo = txtTCNo.Text,
                            FirstName = txtGuestName.Text,
                            LastName = txtGuestSurname.Text,
                            Address = txtGuestAddress.Text,
                            DateOfBirth = DateTime.Parse(dtpDogumTarihi.Text),
                            CreateAt = DateTime.Now,
                            Phone = txtGuestPhone.Text,
                            Email = txtGuestMail.Text,
                            IsActive = true
                        };
                        _guestList.Add(guest);
                        NewGuestIds.Add(guest.Id);
                        maxGuestCount++;
                    }
                    else
                    {
                        MessageBox.Show("Maksimum misafir sayısına ulaşıldı. Daha fazla misafir eklenemez.");
                        ClearSpecificTextBoxes();
                        return;
                    }
                    ClearSpecificTextBoxes();
                    GetBtnGuestSave();
                }
                else
                {
                    MessageBox.Show("Misafir sayısını giriniz");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu : {ex.Message}");
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            var bookingsQuery = from gb in _context.GuestBookings
                                join b in _context.Bookings on gb.BookingId equals b.Id
                                join g in _context.Guests on gb.GuestId equals g.Id
                                join r in _context.Rooms on b.RoomId equals r.Id
                                join rt in _context.RoomTypes on b.RoomTypeId equals rt.Id
                                join h in _context.Hotels on r.HotelId equals h.Id
                                join p in _context.Payments on b.Id equals p.BookingId
                                orderby b.CheckinDate.Date
                                select new
                                {
                                    Id = b.Id,
                                    MisafirAdi = g.FirstName,
                                    MisafirSoyad = g.LastName,
                                    OtelAdi = h.Name,
                                    OdaTipi = rt.Name,
                                    OdaNo = r.RoomNo,
                                    GecelikUcret = rt.PricePerNight,
                                    Tutar = b.TotalPrice,
                                    GirisTarihi = b.CheckinDate,
                                    CikisTarihi = b.CheckoutDate,
                                    RoomId = r.Id,
                                    RoomTypeId = rt.Id,
                                    HotelId = h.Id,
                                    PaymentId = p.Id,
                                    OdemeSekli = p.PaymentMethod // Ödeme yöntemi
                                };

            if (!string.IsNullOrEmpty(searchText) && searchText.Length >= 2)
            {
                var filteredBookings = bookingsQuery
            .Where(b => b.MisafirAdi.ToLower().Contains(searchText) ||
                        b.MisafirSoyad.ToLower().Contains(searchText) ||
                        b.OtelAdi.ToLower().Contains(searchText) ||
                        b.OdaTipi.ToLower().Contains(searchText) ||
                        b.OdaNo.ToString().Contains(searchText) ||
                        b.OdemeSekli.ToLower().Contains(searchText))
            .ToList();

                dgvList.DataSource = null;
                dgvList.DataSource = filteredBookings;
            }
            else if (searchText.Length == 0)
            {
                GetAllBookingData();
            }
        }
        private void cmbHName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllRoomList();
        }

        private void cmbOdaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRoomType = cmbOdaTipi.SelectedItem as RoomType;
            if (selectedRoomType != null)
            {
                lblPricePerNight.Text = $"{selectedRoomType.PricePerNight} TL";
                lblCapacity.Text = $"{selectedRoomType.Capacity} kişi";
                lbllabelDescription.Text = $"{selectedRoomType.Description}";
            }
            CalculateTotal();
            GetAllRoomList();

        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {

            CalculateTotal();
        }

        private void dtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            GetAllBookingData();

        }


        private void btnSil_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvList.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvList.SelectedRows[0];
                    var bookingId = (Guid)selectedRow.Cells["Id"].Value; // "Id" sütun adınız olmalı

                    _bookingService.Delete(bookingId);
                    GetAllBookingData();
                    MessageBox.Show("Misafir Silindi.");
                }
                else
                {
                    MessageBox.Show("Silinecek bir misafir seç.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var :" + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvList.SelectedRows[0];
                    var bookingIdCellValue = selectedRow.Cells["Id"].Value;

                    if (bookingIdCellValue != null && Guid.TryParse(bookingIdCellValue.ToString(), out Guid bookingId))
                    {
                        var booking = _bookingService.GetByID(bookingId);
                        if (booking != null)
                        {
                            var guestBookings = _guestBookingService.GetByBookingID(booking.Id);
                            var guestBooking = guestBookings.FirstOrDefault();

                            DateTime checkinDate = dtpGirisTarihi.Value;
                            DateTime checkoutDate = dtpCikisTarihi.Value;
                            Guid newRoomId = Guid.Parse(cmbOdaNo.SelectedValue.ToString());

                            var existingBookings = _bookingService.GetAll()
                                .Where(b => b.RoomId == newRoomId &&
                                            ((checkinDate < b.CheckoutDate && checkoutDate > b.CheckinDate) ||
                                             (checkinDate <= b.CheckinDate && checkoutDate >= b.CheckoutDate)))
                                .ToList();

                            if (existingBookings.Any())
                            {
                                MessageBox.Show($"Seçtiğiniz oda {checkinDate.Date:dd.MM.yyyy} - {checkoutDate.Date:dd.MM.yyyy} tarihleri aralığında doludur. Lütfen başka bir tarih veya oda seçiniz.");
                                return;
                            }


                            if (guestBooking != null)
                            {
                                var guest = guestBooking.Guest;
                                if (guest != null)
                                {
                                    guest.TCNo = txtTCNo.Text;
                                    guest.FirstName = txtGuestName.Text;
                                    guest.LastName = txtGuestSurname.Text;
                                    guest.Address = txtGuestAddress.Text;
                                    guest.DateOfBirth = dtpDogumTarihi.Value;
                                    guest.Phone = txtGuestPhone.Text;
                                    guest.Email = txtGuestMail.Text;
                                    guest.UpdateAt = DateTime.Now;
                                    guest.IsActive = true;

                                    _guestService.Update(guest);
                                }
                            }


                            booking.RoomId = newRoomId;
                            booking.RoomTypeId = Guid.Parse(cmbOdaTipi.SelectedValue.ToString());
                            booking.CheckinDate = checkinDate;
                            booking.CheckoutDate = checkoutDate;


                            CalculateTotal();
                            booking.TotalPrice = _totalPrice ?? 0;

                            _bookingService.Update(booking);

                            MessageBox.Show("Misafir ve rezervasyon güncellendi.");
                            GetAllBookingData();
                            ClearControls();
                        }
                        else
                        {
                            MessageBox.Show("Geçersiz Rezervasyon ID.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rezervasyon ID alınamadı.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var: " + ex.Message);
            }
        }


        private void btnSaveAllGuests_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var guest in _guestList)
                {
                    _guestService.Add(guest);
                }
                //_guestList.Clear();
                MessageBox.Show("Tüm misafirler başarıyla kaydedildi.");
                GetAllGuestList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
            grpGuest.Visible = false;
            grpRezervasyon.Visible = true;

            Booking booking = new Booking()
            {
                RoomId = Guid.Parse(cmbOdaNo.SelectedValue.ToString()),
                Room = _roomService.GetByID(Guid.Parse(cmbOdaNo.SelectedValue.ToString())),
                RoomTypeId = Guid.Parse(cmbOdaTipi.SelectedValue.ToString()),
                CheckinDate = dtpGirisTarihi.Value,
                CheckoutDate = dtpCikisTarihi.Value,
                IsActive = true,
                TotalPrice = _totalPrice,
            };

            _bookingService.Add(booking);

            Payment payment = new Payment()
            {
                BookingId = booking.Id,
                Amount = _totalPrice,
                PaymentDate = DateTime.Now,
                PaymentMethod = cmbPaymentMethod.Text,
            };


            _paymentService.Add(payment);


            foreach (var item in _guestList)
            {
                GuestBooking guestBooking = new GuestBooking()
                {
                    BookingId = booking.Id,
                    GuestId = item.Id,
                };
                _guestBookingService.Add(guestBooking);
            }

            Frm_RezervasyonBilgi frmRezerBilgi = new Frm_RezervasyonBilgi(NewGuestIds);

            frmRezerBilgi.Show();
            ClearControls();
            maxGuestCount = 0;
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                var selectedRow = dgvList.SelectedRows[0];

                if (selectedRow != null)
                {
                    var bookingIdCellValue = selectedRow.Cells["Id"].Value;

                    if (bookingIdCellValue != null)
                    {
                        Guid bookingId;
                        if (Guid.TryParse(bookingIdCellValue.ToString(), out bookingId))
                        {
                            var booking = _bookingService.GetByID(bookingId);

                            if (booking != null)
                            {
                                var guestBookings = _guestBookingService.GetByBookingID(booking.Id);
                                var guestBooking = guestBookings.FirstOrDefault();
                                if (guestBooking != null)
                                {
                                    var guest = guestBooking.Guest;

                                    if (guest != null)
                                    {
                                        txtTCNo.Text = guest.TCNo;
                                        txtGuestName.Text = guest.FirstName;
                                        txtGuestSurname.Text = guest.LastName;
                                        txtGuestAddress.Text = guest.Address;
                                        dtpDogumTarihi.Value = guest.DateOfBirth;
                                        txtGuestPhone.Text = guest.Phone;
                                        txtGuestMail.Text = guest.Email;
                                    }
                                }
                                grpGuest.Visible = true;
                                UpdateHotelFill();
                                UpdateRoomTypeFill();
                                UpdateRoomFill();
                                UpdatePaymentFill();

                                dtpGirisTarihi.Value = booking.CheckinDate;
                                dtpCikisTarihi.Value = booking.CheckoutDate;
                            }
                            else
                            {
                                MessageBox.Show("Seçili rezervasyon bulunamadı.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Rezervasyon ID geçersiz.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rezervasyon ID alınamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Seçili satır alınamadı.");
                }
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
            grpGuest.Visible = false;

        }

        private void btnOlustur_Click_1(object sender, EventArgs e)
        {
            var selectedRoom = cmbOdaNo.SelectedItem as Room;

            if (selectedRoom != null)
            {

                if (cmbOdaNo.SelectedValue != null)
                {
                    try
                    {
                        DateControl();

                        if (nmrGuestNumber.Value != 0)
                        {
                            MessageBox.Show($"{nmrGuestNumber.Value} adet Misafir girişi yapınız.");
                            grpGuest.Visible = true;
                            grpRezervasyon.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Misafir Sayısı girşi yapınız.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Bir oda seçmediniz.");
                }
            }
            else
            {
                MessageBox.Show("Bir oda seçmediniz.");
            }

        }
        private void DateControl()
        {

            Guid roomId = Guid.Parse(cmbOdaNo.SelectedValue.ToString());
            DateTime checkinDate = dtpGirisTarihi.Value;
            DateTime checkoutDate = dtpCikisTarihi.Value;


            var existingBookings = _bookingService.GetAll()
                .Where(b => b.RoomId == roomId &&
                            ((checkinDate >= b.CheckinDate && checkinDate < b.CheckoutDate) ||
                             (checkoutDate > b.CheckinDate && checkoutDate <= b.CheckoutDate) ||
                             (checkinDate <= b.CheckinDate && checkoutDate >= b.CheckoutDate)))
                .ToList();

            if (existingBookings.Any())
            {
                MessageBox.Show($"Seçtiğiniz oda {checkinDate.Date}-{checkoutDate.Date} tarihleri aralığında doludur. Lütfen başka bir tarih veya oda seçiniz.");
                return;
            }
        }

        private void GetAllBookingData()
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
                                    orderby b.CheckinDate.Date
                                    select new
                                    {
                                        Id = b.Id,
                                        MisafirAdi = g.FirstName,
                                        MisafirSoyad = g.LastName,
                                        OtelAdi = h.Name,
                                        OdaTipi = rt.Name,
                                        OdaNo = r.RoomNo,
                                        GecelikUcret = rt.PricePerNight,
                                        Tutar = b.TotalPrice,
                                        GirisTarihi = b.CheckinDate,
                                        CikisTarihi = b.CheckoutDate,
                                        RoomId = r.Id,
                                        RoomTypeId = rt.Id,
                                        HotelId = h.Id,
                                        PaymentId = p.Id,
                                        OdemeSekli = p.PaymentMethod
                                    };

                var bookings = bookingsQuery.ToList();


                if (bookings.Count == 0)
                {
                    MessageBox.Show("Veri bulunamadı.");
                }


                dgvList.DataSource = bookings;
                dgvList.Columns["RoomId"].Visible = false;
                dgvList.Columns["RoomTypeId"].Visible = false;
                dgvList.Columns["HotelId"].Visible = false;
                dgvList.Columns["PaymentId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        private void UpdatePaymentFill()
        {
            cmbPaymentMethod.DataSource = null;
            cmbPaymentMethod.DataSource = _paymentService.GetAll();
            cmbPaymentMethod.DisplayMember = "PaymentMethod";
            cmbPaymentMethod.ValueMember = "Id";

            var cmbUpdateSelected = dgvList.CurrentRow.Cells["PaymentId"].Value;
            cmbPaymentMethod.SelectedValue = cmbUpdateSelected;
        }

        private void UpdateRoomTypeFill()
        {
            cmbOdaTipi.DataSource = null;
            cmbOdaTipi.DataSource = _roomTypeService.GetAll();
            cmbOdaTipi.DisplayMember = "Name";
            cmbOdaTipi.ValueMember = "Id";

            var cmbUpdateSelected = dgvList.CurrentRow.Cells["RoomTypeId"].Value;
            cmbOdaTipi.SelectedValue = cmbUpdateSelected;
        }

        private void UpdateRoomFill()
        {
            cmbOdaNo.DataSource = null;
            cmbOdaNo.DataSource = _roomService.GetAll();
            cmbOdaNo.DisplayMember = "RoomNo";
            cmbOdaNo.ValueMember = "Id";

            var cmbUpdateSelected = dgvList.CurrentRow.Cells["RoomId"].Value;
            cmbOdaNo.SelectedValue = cmbUpdateSelected;
        }
        private void UpdateHotelFill()
        {
            cmbHName.DataSource = null;
            cmbHName.DataSource = _hotelService.GetAll();
            cmbHName.DisplayMember = "Name";
            cmbHName.ValueMember = "Id";

            var cmbUpdateSelected = dgvList.CurrentRow.Cells["HotelId"].Value;
            cmbHName.SelectedValue = cmbUpdateSelected;
        }
        private void GetBtnGuestSave()
        {
            var guestSaveList = _guestList.ToList();
            dgvList.DataSource = null;
            dgvList.DataSource = guestSaveList;
        }
        private void GetAllRoomList()
        {
            var selectedHotel = cmbHName.SelectedItem as Hotel;
            var selectedRoomType = cmbOdaTipi.SelectedItem as RoomType;

            if (selectedHotel != null && selectedRoomType != null)
            {

                var filteredRooms = _roomService.GetAll()
                                    .Where(r => r.HotelId == selectedHotel.Id && r.RoomTypeId == selectedRoomType.Id)
                                    .ToList();

                cmbOdaNo.DataSource = null;
                cmbOdaNo.DataSource = filteredRooms;
                cmbOdaNo.DisplayMember = "RoomNo";
                cmbOdaNo.ValueMember = "Id";
            }
            else
            {

                cmbOdaNo.DataSource = null;
            }
        }
        private void ClearControls()
        {
            txtTCNo.Clear();
            txtGuestName.Clear();
            txtGuestSurname.Clear();
            dtpDogumTarihi.Value = DateTime.Now;
            txtGuestAddress.Clear();
            txtGuestPhone.Clear();
            txtGuestMail.Clear();
            dtpGirisTarihi.Value = DateTime.Now;
            dtpCikisTarihi.Value = DateTime.Now;
            lblGun.Text = string.Empty;
            lblPricePerNight.Text = string.Empty;
            lblTotalPrice.Text = string.Empty;
            lbllabelDescription.Text = string.Empty;
            lblCapacity.Text = string.Empty;
            cmbPaymentMethod.SelectedIndex = -1;
            cmbHName.SelectedIndex = -1;
            cmbOdaTipi.SelectedIndex = -1;
            cmbOdaNo.SelectedIndex = -1;


            _guestList.Clear();
            _totalPrice = null;


            dgvList.DataSource = null;

        }
        private void GetAllReservationDetails()
        {
            var booking = _bookingService.GetAll();
            dgvList.DataSource = booking;
        }
        private void GetAllGuestList()
        {
            var guests = _guestService.GetAll();
            dgvList.DataSource = null;
            dgvList.DataSource = guests;
        }
        private void GetPaymentMethod()
        {

            cmbPaymentMethod.Items.Add("Kredi Kartı");
            cmbPaymentMethod.Items.Add("Nakit");

        }
        private void ClearSpecificTextBoxes()
        {
            txtTCNo.Clear();
            txtGuestName.Clear();
            txtGuestSurname.Clear();
            dtpDogumTarihi.Value = DateTime.Now;
            txtGuestAddress.Clear();
            txtGuestPhone.Clear();
            txtGuestMail.Clear();
        }
        private void GetAllHotels()
        {
            var hotels = _hotelService.GetAll();

            cmbHName.DataSource = null;
            cmbHName.DataSource = hotels;
            cmbHName.DisplayMember = "Name";
            cmbHName.ValueMember = "Id";
            cmbHName.Refresh();
        }

        private void GetAllRoomTypes()
        {
            var roomTypes = _roomTypeService.GetAll();
            cmbOdaTipi.DataSource = null;
            cmbOdaTipi.DataSource = roomTypes;
            cmbOdaTipi.DisplayMember = "Name";
            cmbOdaTipi.ValueMember = "Id";
        }

        private decimal? _totalPrice;
        private void CalculateTotal()
        {
            var selectedRoomType = cmbOdaTipi.SelectedItem as RoomType;
            if (selectedRoomType != null)
            {
                int days = (dtpCikisTarihi.Value - dtpGirisTarihi.Value).Days;
                if (days > 0)
                {
                    lblGun.Text = $"{days} Gece";

                    decimal? pricePerNight = selectedRoomType.PricePerNight;
                    _totalPrice = (pricePerNight ?? 0) * days;

                    lblTotalPrice.Text = $"{_totalPrice:0.##} TL";
                }
                else
                {
                    lblTotalPrice.Text = "Geçersiz tarih aralığı.";
                    _totalPrice = null;
                }
            }
        }
        private void BookingList()
        {
            var bookingList = _bookingService.GetBookingsWithGuests();


        }


    }
}


