using FluentValidation;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Validators
{
    public class RoomTypeValidator : AbstractValidator<RoomType>
    {
        public RoomTypeValidator()
        {
            RuleFor(rt => rt.Name)
                .NotEmpty().WithMessage("Odanın tipi girilmelidir.")
                .MaximumLength(50).WithMessage("Odanın tipi 50 karakterden uzun olamaz.");

            RuleFor(rt => rt.Description)
                .MaximumLength(100).WithMessage("Açıklama 100 karakterden uzun olamaz.");

            RuleFor(rt => rt.PricePerNight)
                .GreaterThan(0).WithMessage("Gecelik fiyat sıfırdan büyük olmalıdır.");

            RuleFor(rt => rt.Capacity)
                .GreaterThan(0).WithMessage("Kapasite sıfırdan büyük olmalıdır.");
        }
    }
}
