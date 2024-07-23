using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Validators;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using FluentValidation.Results;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Services
{
    public class HotelService : IService<Hotel>
    {
        private readonly HotelRepository _hotelRepository;

        public HotelService(HotelRepository gRepo)
        {
            _hotelRepository = gRepo;
        }

        public void Add(Hotel entity)
        {
            HotelValidator hVal = new();
            ValidationResult result = hVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _hotelRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var hotel = _hotelRepository.GetByID(id);

            _hotelRepository.Delete(id);
        }

        public IEnumerable<Hotel>? GetAll()
        {
            return _hotelRepository.GetAll();
        }

        public Hotel? GetByID(Guid id)
        {
            return _hotelRepository.GetByID(id);
        }

        public void Update(Hotel entity)
        {
            HotelValidator hVal = new();
            ValidationResult result = hVal.Validate(entity);

            if (result.IsValid)
            {
                _hotelRepository.Update(entity);
            }
        }
    }

}
