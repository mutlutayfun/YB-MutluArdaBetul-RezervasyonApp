using FluentValidation;
using Microsoft.EntityFrameworkCore;
using YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.Context;
using YB_MutluArdaBetülRezervasyonApp.Entities.Models;

namespace YB_MutluArdaBetülRezervasyonApp.Business.Validators
{
    public class BookingValidator : AbstractValidator<Booking>
    {
        
        public BookingValidator()
        {
            RuleFor(booking => booking.CheckinDate)
                .GreaterThan(DateTime.Now).WithMessage("Giriş tarihi gelecekte olmalıdır.");

            RuleFor(booking => booking.CheckoutDate)
                .GreaterThan(booking => booking.CheckinDate).WithMessage("Çıkış tarihi giriş tarihinden sonra olmalıdır.");


            RuleFor(booking => booking.TotalPrice)
                .GreaterThan(0).WithMessage("Toplam fiyat sıfırdan büyük olmalıdır.");

        }
    }
    
}
