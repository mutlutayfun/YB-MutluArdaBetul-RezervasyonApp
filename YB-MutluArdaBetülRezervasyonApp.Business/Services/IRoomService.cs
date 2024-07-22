using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Validators;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using FluentValidation.Results;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Services
{
    public class IRoomService : IService<Room>
    {
        private readonly IRoomRepository _roomRepository;

        public IRoomService(IRoomRepository rRepo)
        {
            _roomRepository = rRepo;
        }

        public void Add(Room entity)
        {
            RoomValidator rVal = new();
            ValidationResult result = rVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _roomRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var room = _roomRepository.GetByID(id);

            if (room.IsActive)
            {
                throw new Exception("Aktif misafir silinemez!!");
            }
            _roomRepository.Delete(id);
        }

        public IEnumerable<Room>? GetAll()
        {
            return _roomRepository.GetAll();
        }

        public Room? GetByID(Guid id)
        {
            return _roomRepository.GetByID(id);
        }

        public void Update(Room entity)
        {
            RoomValidator rVal = new();
            ValidationResult result = rVal.Validate(entity);

            if (result.IsValid)
            {
                _roomRepository.Update(entity);
            }
        }
    }

}
