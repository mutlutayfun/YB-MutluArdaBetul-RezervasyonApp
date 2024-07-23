using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Validators;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using FluentValidation.Results;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Services
{
    public class GuestService : IService<Guest>
    {
        private readonly GuestRepository _guestRepository;

        public GuestService(GuestRepository gRepo)
        {
            _guestRepository = gRepo;
        }

        public void Add(Guest entity)
        {
            GuestValidator gVal = new();
            ValidationResult result = gVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _guestRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            //var guest = _guestRepository.GetByID(id);
            
            //if (guest.IsActive)
            //{
            //    throw new Exception("Aktif misafir silinemez!!");
            //}

            var guest = _guestRepository.GetByID(id);

            if (guest == null)
            {
                throw new Exception("Geçersiz Misafir ID: Misafir bulunamadı.");
            }

            _guestRepository.Delete(id);
        }

        public IEnumerable<Guest>? GetAll()
        {
            return _guestRepository.GetAll();
        }

        public Guest? GetByID(Guid id)
        {
            return _guestRepository.GetByID(id);
        }

        public void Update(Guest entity)
        {
            GuestValidator gVal = new();
            ValidationResult result = gVal.Validate(entity);

            if (result.IsValid)
            {
                _guestRepository.Update(entity);
            }
            else
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
        }
    }
}
