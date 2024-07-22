using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Validators;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using FluentValidation.Results;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Services
{
    public class IGuestBookingService : IService<GuestBooking>
    {
        private readonly IGuestBookingRepository _guestBookingRepository;

        public IGuestBookingService(IGuestBookingRepository gbRepo)
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

            if (guestBooking.IsActive)
            {
                throw new Exception("Aktif misafir silinemez!!");
            }
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
    }

}
