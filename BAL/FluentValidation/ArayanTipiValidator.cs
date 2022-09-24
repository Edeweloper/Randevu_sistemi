using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.FluentValidation
{
    public class ArayanTipiValidator : AbstractValidator<ArayanTipi>
    {
        public ArayanTipiValidator()
        {
            RuleFor(x => x.Arayan_tipi).NotEmpty().WithMessage("Arama Tipi boş bırakılamaz");
        }
    }
}
