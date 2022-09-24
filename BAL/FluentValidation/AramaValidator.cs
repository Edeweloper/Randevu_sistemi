using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.FluentValidation
{
    public class AramaValidator : AbstractValidator<Arama>
    {
        public AramaValidator()
        {
            
            RuleFor(x => x.Ad).MaximumLength(20).WithMessage("Kısa bir ad giriniz");
            RuleFor(x => x.Ad).MinimumLength(5).WithMessage("Uzun bir ad giriniz");
            RuleFor(x => x.Konu).MinimumLength(20).WithMessage("Uzun bir konu giriniz");
            RuleFor(x => x.Aranma_Zamanı.TimeOfDay).InclusiveBetween(new TimeSpan(8, 30, 0), new TimeSpan(17, 30, 0)).WithMessage("Aranma saati 8:30 ile 17:30 arasında olmalıdır.");
        }
    }
}
