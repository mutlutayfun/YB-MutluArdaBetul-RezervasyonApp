using Microsoft.EntityFrameworkCore;
using System.Globalization;
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
        private Guest _guest;

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
        private void GetBtnGuestSave()
        {
            var guestSaveList = _guestList.ToList();
            dgvList.DataSource = null;
            dgvList.DataSource = guestSaveList;
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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (!string.IsNullOrEmpty(searchText) && searchText.Length >= 2)
            {
                //var bookingList = _bookingService.GetBookingsWithGuests();
                var guest = _guestService.GetAll();

                var filteredList = guest
                    .Where(g => g.FirstName.ToLower().Contains(searchText) ||g.TCNo.ToString().Contains(searchText)||
                        g.LastName.ToLower().Contains(searchText))
                        .ToList();

                dgvList.DataSource = null;
                dgvList.DataSource = filteredList;
            }
            else if (searchText.Length == 0)
            {
                BookingList();
            }

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
        private void Frm_Rezervasyon_Load(object sender, EventArgs e)
        {
            GetAllHotels();
            GetAllRoomTypes();
            GetPaymentMethod();
            BookingList();
            ClearControls();
            //GetByGuest();

            grpGuest.Visible = false;

            cmbHName.SelectedIndexChanged += cmbHName_SelectedIndexChanged;
            cmbOdaTipi.SelectedIndexChanged += cmbOdaTipi_SelectedIndexChanged;
            dtpGirisTarihi.ValueChanged += dtpGirisTarihi_ValueChanged;
            dtpCikisTarihi.ValueChanged += dtpCikisTarihi_ValueChanged;

        }

        private void GetPaymentMethod()
        {

            cmbPaymentMethod.Items.Add("Kredi Kartı");
            cmbPaymentMethod.Items.Add("Nakit");

        }

        private void nmrGuestNumber_ValueChanged(object sender, EventArgs e)
        {

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

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

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
            GetAllReservationDetails();
            //GetAllGuest(); listbox için
            GetAllGuestList(); //datagrid için

            //var detailedBookings = _bookingService.GetDetailedBookings();

            //var bookingInfo = detailedBookings.Select(b => new
            //{
            //    HotelName = b.Room.Hotel.Name,
            //    GuestName = string.Join(", ", b.GuestBookings.Select(gb => gb.Guest.FirstName + " " + gb.Guest.LastName)),
            //    RoomType = b.Room.RoomType.Name,
            //    //Price = b.Room.RoomType.Price 
            //}).ToList();

            //dgvList.DataSource = bookingInfo;


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
        private void GetAllRoomList()
        {
            var selectedHotel = cmbHName.SelectedItem as Hotel;
            var selectedRoomType = cmbOdaTipi.SelectedItem as RoomType;

            if (selectedHotel != null && selectedRoomType != null)
            {
                // Seçilen otel ve oda tipine göre filtreleme yap
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
                // Eğer seçilen bir otel veya oda tipi yoksa, listeyi boş bırak
                cmbOdaNo.DataSource = null;
            }
        }

        #region listbox kullanırsak bunu kullanıcaz
        /* private void GetAllGuest()
         {
             var guests = _guestService.GetAll();
             lstList.DataSource = null;
             lstList.DataSource = guests;
             lstList.DisplayMember = "FullName" + "TCNo" + "DateOfBirth" + "Address" + "Phone" + "Email" + "CreateAt" + "UpdateAt"; // Bu tür bir özellik tanımladığınızdan emin olun
             lstList.ValueMember = "Id"; // `Guid`'in kullanıldığı ID alanı
         }*/
        #endregion

        private void btnSil_Click(object sender, EventArgs e)
        {
            #region listbox da silme
            //try
            //{
            //    if (lstList.SelectedIndex != -1)
            //    {
            //        var selectedValue = lstList.SelectedValue;
            //        if (selectedValue != null && Guid.TryParse(selectedValue.ToString(), out Guid guestId))
            //        {
            //            _guestService.Delete(guestId);
            //            GetAllGuest();
            //            MessageBox.Show("Misafir Silindi.");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Geçersiz misafir ID.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Silinecek bir misafir seç.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Hata var :" + ex.Message);
            //}
            #endregion

            try
            {
                if (dgvList.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvList.SelectedRows[0];
                    var guestId = (Guid)selectedRow.Cells["Id"].Value; // "Id" sütun adınız olmalı

                    _guestService.Delete(guestId);
                    GetAllGuestList();
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
            //_guest = _guestService.GetByID(txtGuestName.Text);
            //if (_guest != null)
            //{
            //    _guest.TCNo = txtGuestName.Text;
            //    _guest.FullName = txtGuestName.Text;
            //    _guest.sur
            //}
            //_guestService.Update(_guest);
            //ClearControls();
            try
            {
                if (dgvList.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvList.SelectedRows[0];
                    var guestId = (Guid)selectedRow.Cells["Id"].Value;

                    var existingGuest = _guestService.GetByID(guestId);
                    if (existingGuest != null)
                    {
                        _context.Entry(existingGuest).State = EntityState.Detached;
                    }

                    var guest = new Guest
                    {
                        Id = guestId,
                        TCNo = txtTCNo.Text,
                        FirstName = txtGuestName.Text,
                        LastName = txtGuestSurname.Text,
                        Address = txtGuestAddress.Text,
                        DateOfBirth = dtpDogumTarihi.Value,
                        Phone = txtGuestPhone.Text,
                        Email = txtGuestMail.Text,
                        UpdateAt = DateTime.Now,
                        IsActive = true
                    };

                    _guestService.Update(guest);
                    GetAllGuestList();
                    MessageBox.Show("Misafir Güncellendi.");
                    //GetByGuest();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var :" + ex.Message);
            }
            ClearControls();
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
            dtpCikisTarihi.Value = DateTime.Now;
            dtpCikisTarihi.Value = DateTime.Now;
            lblGun.Text = string.Empty;
            lblPricePerNight.Text = string.Empty;
            lblTotalPrice.Text = string.Empty;
            lbllabelDescription.Text = string.Empty;
            lblCapacity.Text = string.Empty;

        }

        private void btnSaveAllGuests_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var guest in _guestList)
                {
                    _guestService.Add(guest);
                }
                _guestList.Clear();
                MessageBox.Show("Tüm misafirler başarıyla kaydedildi.");
                GetAllGuestList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
            grpGuest.Visible = false;
            grpRezervasyon.Visible = true;
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                var selectedRow = dgvList.SelectedRows[0];

                if (selectedRow != null)
                {
                    var guestId = selectedRow.Cells["Id"].Value;
                    if (guestId != null)
                    {
                        var guest = _guestService.GetByID(Guid.Parse(guestId.ToString()));
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
                        else
                        {
                            MessageBox.Show("Seçili misafir bulunamadı.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Misafir ID alınamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Seçili satır alınamadı.");
                }
            }

        }

        private void cmbPaymentMethod_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnOlustur_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Oda ID'sini ve tarih aralığını alıyoruz
                Guid roomId = Guid.Parse(cmbOdaNo.SelectedValue.ToString());
                DateTime checkinDate = dtpGirisTarihi.Value;
                DateTime checkoutDate = dtpCikisTarihi.Value;

                // Oda rezervasyonlarını kontrol ediyoruz
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



                Payment payment = new Payment()
                {
                    BookingId = booking.Id,
                    Amount = _totalPrice,
                    PaymentDate = DateTime.Now,
                    PaymentMethod = cmbPaymentMethod.Text,
                };



                _bookingService.Add(booking);

                foreach (var item in _guestList)
                {
                    GuestBooking guestBooking = new GuestBooking()
                    {
                        BookingId = booking.Id,
                        GuestId = item.Id,
                    };
                    _guestBookingService.Add(guestBooking);
                }
                _paymentService.Add(payment);
                if (nmrGuestNumber.Value !=0)
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

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpGuest.Visible = true;
        }

        private void grpRezervasyon_Enter(object sender, EventArgs e)
        {

        }

        private void cmbOdaNo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}


    