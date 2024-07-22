﻿using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Validators;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using FluentValidation.Results;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Services
{
    public class IHotelService : IService<Hotel>
    {
        private readonly IHotelRepository _hotelRepository;

        public IHotelService(IHotelRepository gRepo)
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

            if (hotel.IsActive)
            {
                throw new Exception("Aktif misafir silinemez!!");
            }
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
