﻿using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Validators;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using FluentValidation.Results;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Services
{
    public class IBookingService : IService<Booking>
    {
        private readonly IBookingRepository _bookingRepository;

        public IBookingService(IBookingRepository bRepo)
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
            _bookingRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var booking = _bookingRepository.GetByID(id);

            if (booking.IsActive)
            {
                throw new Exception("Aktif misafir silinemez!!");
            }
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
    }

}
