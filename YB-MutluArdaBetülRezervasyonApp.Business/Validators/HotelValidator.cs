using FluentValidation;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Validators
{
    public class HotelValidator : AbstractValidator<Hotel>
    {
        public HotelValidator()
        {
            RuleFor(h => h.Name)
                .NotEmpty().WithMessage("Otel adı gerekli.")
                .MaximumLength(100).WithMessage("Otel adı 100 karakterden uzun olamaz.");

            RuleFor(h => h.Address)
                .NotEmpty().WithMessage("Adres gerekli.")
                .MaximumLength(100).WithMessage("Adres 100 karakterden uzun olamaz.");

            RuleFor(h => h.Phone)
                .Matches(@"^\d{10}$").WithMessage("Telefon numarası 10 haneli olmalıdır.");

            RuleFor(h => h.Email)
                .EmailAddress().WithMessage("Geçersiz e-posta formatı.")
                .MaximumLength(100).WithMessage("E-posta 100 karakterden uzun olamaz.");

            RuleFor(h => h.Stars)
                .InclusiveBetween(1, 5).WithMessage("Yıldız sayısı 1 ile 5 arasında olmalıdır.");

            RuleFor(h => h.CheckinTime)
                .NotEmpty().WithMessage("Giriş saati gerekli.");

            RuleFor(h => h.CheckoutTime)
                .NotEmpty().WithMessage("Çıkış saati gerekli.");
        }

    }
}
