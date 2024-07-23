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
        }



        private void btnExit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" Hoşçakal... ");
            Application.Exit();
        }


        private int maxGuestCount = 0;
        private void btnGuestSave_Click(object sender, EventArgs e)
        {
            try
            {
                var guestCount = (int)nmrGuestNumber.Value;

                if (maxGuestCount + guestCount > 5)
                {
                    MessageBox.Show("Maksimum misafir sayısına ulaşıldı. Daha fazla misafir eklenemez.");
                    return;
                }

                for (int i = 0; i < guestCount; i++)
                {
                    Guest guest = new Guest()
                    {
                       // Id = Guid.NewGuid(),
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
                    _guestService.Add(guest);
                }
                maxGuestCount += guestCount;
                MessageBox.Show($"{guestCount} misafir başarıyla eklendi.");
                GetAllGuestList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu : {ex.Message}");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (!string.IsNullOrEmpty(searchText) && searchText.Length >= 2)
            {
                var bookingList = _bookingService.GetBookingsWithGuests();

                var filteredList = bookingList
                .Where(b => b.GuestBookings.Any(gb =>
                    gb.Guest != null &&
                    (gb.Guest.FirstName.ToLower().Contains(searchText) ||
                    gb.Guest.LastName.ToLower().Contains(searchText))))
                .ToList();

                lstList.DataSource = filteredList;
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

        private void CalculateTotal()
        {
            var selectedRoomType = cmbOdaTipi.SelectedItem as RoomType;
            if (selectedRoomType != null)
            {
                int days = (dtpCikisTarihi.Value - dtpGirisTarihi.Value).Days;
                if (days > 0)
                {
                    decimal? total = days * selectedRoomType.PricePerNight;
                    lblTotalPrice.Text = $"{total}TL";
                }
                else
                {
                    lblTotalPrice.Text = "Geçersiz tarih aralığı.";
                }
            }
        }
        private void BookingList()
        {
            var bookingList = _bookingService.GetBookingsWithGuests();

        }

        private void Frm_Rezervasyon_Load(object sender, EventArgs e)
        {
            
            BookingList();
        }

        private void nmrGuestNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbHName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedHotel = cmbHName.SelectedItem as Hotel;
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

        private void btnOluştur_Click(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GetAllReservationDetails();
            //GetAllGuest(); listbox için
            GetAllGuestList(); //datagrid için


        }

        private void GetAllReservationDetails()
        {
            var booking = _bookingService.GetAll();
            lstList.DataSource = booking;
        }
        private void GetAllGuestList()
        {
            var guests = _guestService.GetAll();
            dgvList.DataSource = null;
            dgvList.DataSource = guests;
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
    }
}
