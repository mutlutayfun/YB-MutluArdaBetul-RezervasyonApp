﻿using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Validators;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using FluentValidation.Results;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Services
{
    public class IStaffService : IService<Staff>
    {
        private readonly IStaffRepository _staffRepository;

        public IStaffService(IStaffRepository sRepo)
        {
            _staffRepository = sRepo;
        }

        public void Add(Staff entity)
        {
            StaffValidator gVal = new();
            ValidationResult result = gVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _staffRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var staff = _staffRepository.GetByID(id);

            if (staff.IsActive)
            {
                throw new Exception("Aktif misafir silinemez!!");
            }
            _staffRepository.Delete(id);
        }

        public IEnumerable<Staff>? GetAll()
        {
            return _staffRepository.GetAll();
        }

        public Staff? GetByID(Guid id)
        {
            return _staffRepository.GetByID(id);
        }

        public void Update(Staff entity)
        {
            StaffValidator sVal = new();
            ValidationResult result = sVal.Validate(entity);

            if (result.IsValid)
            {
                _staffRepository.Update(entity);
            }
        }

    }

}
