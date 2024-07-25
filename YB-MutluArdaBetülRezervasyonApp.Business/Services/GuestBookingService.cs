using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Validators;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using FluentValidation.Results;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Services
{
    public class GuestBookingService : IService<GuestBooking>
    {
        private readonly GuestBookingRepository _guestBookingRepository;

        public GuestBookingService(GuestBookingRepository gbRepo)
        {
            _guestBookingRepository = gbRepo;
        }

        public void Add(GuestBooking entity)
        {
            _guestBookingRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var guestBooking = _guestBookingRepository.GetByID(id);

            _guestBookingRepository.Delete(id);
        }

        public IEnumerable<GuestBooking>? GetAll()
        {
            return _guestBookingRepository.GetAll();
        }

        public GuestBooking? GetByID(Guid id)
        {
            return _guestBookingRepository.GetByID(id);
        }

        public void Update(GuestBooking entity)
        {

           _guestBookingRepository.Update(entity);
           
        }
        public IEnumerable<GuestBooking> GetByBookingID(Guid bookingId)
        {
            return _guestBookingRepository.GetByBookingID(bookingId);
        }
    }

}
