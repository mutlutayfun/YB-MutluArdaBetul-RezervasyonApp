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
        }



        private void btnExit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" Mutlu Günler... ");
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

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
                        TCNo = txtTCNo.Text,
                        FirstName = txtGuestName.Text,
                        LastName = txtGuestSurname.Text,
                        Address = txtGuestAddress.Text,
                        DateOfBirth = DateTime.Parse(dtpDogumTarihi.Text),
                        Phone = txtGuestPhone.Text,
                        Email = txtGuestMail.Text,
                        IsActive = true
                    };
                    _guestService.Add(guest);
                }
                maxGuestCount += guestCount;
                MessageBox.Show($"{guestCount} misafir başarıyla eklendi.");

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

                dgvListe.DataSource = filteredList;
            }
            else if (searchText.Length == 0)
            {
                BookingList();
            }

        }
        private void GetAllHotels()
        {
            var hotels = _hotelService.GetAll();
            cmbHName.DataSource = hotels;
            cmbHName.DisplayMember = "Name";
            cmbHName.ValueMember = "Id";
        }


        private void BookingList()
        {
            var bookingList = _bookingService.GetBookingsWithGuests();

        }

        private void Frm_Rezervasyon_Load(object sender, EventArgs e)
        {
            GetAllHotels();
            BookingList();
        }

        private void nmrGuestNumber_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
