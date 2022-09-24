using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.FluentValidation
{
    public class Randevu_durumuValidator : AbstractValidator<Randevu_durumu>
    {
        public Randevu_durumuValidator()
        {
            RuleFor(x => x.Randevu_Durumu).NotEmpty().WithMessage("Adı boş geçemezssiniz");
        }
    }
}
