using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.FluentValidation
{
    public class AramaTipiValidator : AbstractValidator<AramaTipi>
    {
        public AramaTipiValidator()
        {
            RuleFor(x => x.Arama_tipi).NotEmpty().WithMessage("Arama Tipi boş bırakılamaz");
        }
    }
}
