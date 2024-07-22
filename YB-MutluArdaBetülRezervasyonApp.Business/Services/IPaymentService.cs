﻿using YB_MutluArdaBetülRezervasyonApp.Business.Abstractions;
using YB_MutluArdaBetülRezervasyonApp.Business.Validators;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Repositories;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;
using FluentValidation.Results;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Services
{
    public class IPaymentService : IService<Payment>
    {
        private readonly IPaymentRepository _paymentRepository;

        public IPaymentService(IPaymentRepository gRepo)
        {
            _paymentRepository = gRepo;
        }

        public void Add(Payment entity)
        {
            PaymentValidator pVal = new();
            ValidationResult result = pVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _paymentRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var payment = _paymentRepository.GetByID(id);

            if (payment.IsActive)
            {
                throw new Exception("Aktif misafir silinemez!!");
            }
            _paymentRepository.Delete(id);
        }

        public IEnumerable<Payment>? GetAll()
        {
            return _paymentRepository.GetAll();
        }

        public Payment? GetByID(Guid id)
        {
            return _paymentRepository.GetByID(id);
        }

        public void Update(Payment entity)
        {
            PaymentValidator pVal = new();
            ValidationResult result = pVal.Validate(entity);

            if (result.IsValid)
            {
                _paymentRepository.Update(entity);
            }
        }
    }

}
