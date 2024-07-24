using FluentValidation;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Validators
{
    public class RoomValidator : AbstractValidator<Room>
    {
        public RoomValidator()
        {
            RuleFor(r => r.Status)
                .Must(status => status != "Dolu").WithMessage("Bu oda dolu olduğu için yeni rezervasyon yapılamaz.");
        }
    }
}
