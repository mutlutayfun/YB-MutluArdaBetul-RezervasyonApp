using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Validators;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using FluentValidation.Results;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Services
{
    public class BookingService : IService<Booking>
    {
        private readonly BookingRepository _bookingRepository;

        public BookingService(BookingRepository bRepo)
        {
            _bookingRepository = bRepo;
        }

        public void Add(Booking entity)
        {
            BookingValidator bVal = new();
            ValidationResult result = bVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            RoomValidator rVal = new();
            ValidationResult result1 = rVal.Validate(entity.Room);
            if (!result1.IsValid)
            {
                throw new Exception(string.Join("\n", result1.Errors));
            }
            _bookingRepository.Add(entity);

        }


        public void Delete(Guid id)
        {
            var booking = _bookingRepository.GetByID(id);

            _bookingRepository.Delete(id);
        }

        public IEnumerable<Booking>? GetAll()
        {
            return _bookingRepository.GetAll();
        }

        public Booking? GetByID(Guid id)
        {
            return _bookingRepository.GetByID(id);
        }

        public void Update(Booking entity)
        {
            BookingValidator bVal = new();
            ValidationResult result = bVal.Validate(entity);

            if (result.IsValid)
            {
                _bookingRepository.Update(entity);
            }
        }
        public IEnumerable<Booking> GetBookingsWithGuests()
        {
            return _bookingRepository.GetBookingsWithGuests();
        }
        public IEnumerable<Booking> GetDetailedBookings()
        {
            return _bookingRepository.GetDetailedBookings();
        }


    }

}
