using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Validators;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Services
{
    public class RoomService : IService<Room>
    {
        private readonly RoomRepository _roomRepository;

        public RoomService(RoomRepository rRepo)
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
