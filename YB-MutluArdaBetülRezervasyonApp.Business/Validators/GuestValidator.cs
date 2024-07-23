using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Validators
{
    public class GuestValidator : AbstractValidator<Guest>
    {
        public GuestValidator()
        {
            RuleFor(g => g.FirstName)
            .NotEmpty().WithMessage("İsim gereklidir.")
            .MaximumLength(50).WithMessage("İsim 50 karakterden uzun olamaz.");

            RuleFor(g => g.LastName)
                .NotEmpty().WithMessage("Soyisim gereklidir.")
                .MaximumLength(50).WithMessage("Soyisim 50 karakterden uzun olamaz.");

            RuleFor(g => g.DateOfBirth)
                .LessThan(DateTime.Now).WithMessage("Doğum tarihi geçmişte olmalıdır.");

            RuleFor(g => g.Address)
                .MaximumLength(100).WithMessage("Adres 100 karakterden uzun olamaz.");

            RuleFor(g => g.Phone)
                .Matches(@"^\d{10}$").WithMessage("Telefon numarası 10 haneli olmalıdır.");

            RuleFor(g => g.Email)
                .EmailAddress().WithMessage("Geçersiz e-posta formatı.")
                .MaximumLength(100).WithMessage("E-posta 100 karakterden uzun olamaz.");

            RuleFor(g => g.TCNo)
                .NotEmpty().WithMessage("TC Kimlik Numarası boş olamaz.")
                .Length(11).WithMessage("TC Kimlik Numarası 11 haneli olmalıdır.")
                .Matches("[0-9]").WithMessage("TC Kimlik Numarası rakamlardan oluşmalıdır!!");
        }
    }
}
