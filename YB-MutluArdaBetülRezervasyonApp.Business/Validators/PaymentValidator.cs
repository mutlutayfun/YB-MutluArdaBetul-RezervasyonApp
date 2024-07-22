using FluentValidation;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Validators
{
    public class PaymentValidator : AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(p => p.Amount)
                .GreaterThan(0).WithMessage("Tutar sıfırdan büyük olmalıdır.");

            RuleFor(p => p.PaymentDate)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Ödeme tarihi gelecekte olamaz.");

            RuleFor(p => p.PaymentMethod)
                .NotEmpty().WithMessage("Ödeme yöntemi gerekli.")
                .MaximumLength(50).WithMessage("Ödeme yöntemi 50 karakterden uzun olamaz.");
        }
    }
}
