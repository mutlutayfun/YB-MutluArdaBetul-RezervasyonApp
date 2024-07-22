using FluentValidation;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Validators
{
    public class StaffValidator : AbstractValidator<Staff>
    {
        public StaffValidator()
        {
            RuleFor(s => s.FirstName)
                .NotEmpty().WithMessage("İsim gerekli.")
                .MaximumLength(50).WithMessage("İsim 50 karakterden uzun olamaz.");

            RuleFor(s => s.LastName)
                .NotEmpty().WithMessage("Soyisim gerekli.")
                .MaximumLength(50).WithMessage("Soyisim 50 karakterden uzun olamaz.");

            RuleFor(s => s.Position)
                .NotEmpty().WithMessage("Pozisyon gerekli.")
                .MaximumLength(50).WithMessage("Pozisyon 50 karakterden uzun olamaz.");

            RuleFor(s => s.Salary)
                .GreaterThan(0).WithMessage("Maaş sıfırdan büyük olmalıdır.");

            RuleFor(s => s.DateOfBirth)
                .LessThan(DateTime.Now).WithMessage("Doğum tarihi geçmişte olmalıdır.");

            RuleFor(s => s.Phone)
                .Matches(@"^\d{10}$").WithMessage("Telefon numarası 10 haneli olmalıdır.");

            RuleFor(s => s.Email)
                .EmailAddress().WithMessage("Geçersiz e-posta formatı.")
                .MaximumLength(100).WithMessage("E-posta 100 karakterden uzun olamaz.");

            RuleFor(s => s.HireDate)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("İşe alım tarihi gelecekte olamaz.");
        }
    }
}
