using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Validators;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using FluentValidation.Results;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Services
{
    public class RoomTypeService : IService<RoomType>
    {
        private readonly RoomTypeRepository _roomTypeRepository;

        public RoomTypeService(RoomTypeRepository rtRepo)
        {
            _roomTypeRepository = rtRepo;
        }

        public void Add(RoomType entity)
        {
            RoomTypeValidator rtVal = new();
            ValidationResult result = rtVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _roomTypeRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var roomType = _roomTypeRepository.GetByID(id);

            _roomTypeRepository.Delete(id);
        }

        public IEnumerable<RoomType>? GetAll()
        {
            return _roomTypeRepository.GetAll();
        }

        public RoomType? GetByID(Guid id)
        {
            return _roomTypeRepository.GetByID(id);
        }

        public void Update(RoomType entity)
        {
            RoomTypeValidator rtVal = new();
            ValidationResult result = rtVal.Validate(entity);

            if (result.IsValid)
            {
                _roomTypeRepository.Update(entity);
            }
        }
    }

}
