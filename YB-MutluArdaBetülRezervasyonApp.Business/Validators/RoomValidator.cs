using FluentValidation;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Validators
{
    public class RoomValidator : AbstractValidator<Room>
    {
        public RoomValidator()
        {
            RuleFor(r => r.Status)
                .NotEmpty().WithMessage("Durum gerekli.")
                .MaximumLength(50).WithMessage("Durum 50 karakterden uzun olamaz.");
        }
    }
}
