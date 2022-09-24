using BAL.Concrete;
using DAL.EntityFramework;
using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.FluentValidation
{
    public class RandevularValidator:AbstractValidator<Randevular>
    {
        public RandevularValidator()
        {
          
            RuleFor(x => x.Randevuya_Gelen).MaximumLength(25).WithMessage("Kısa bir Ad giriniz");
            RuleFor(x => x.Randevuya_Gelen).MinimumLength(3).WithMessage("Uzun  bir Ad giriniz");
            RuleFor(x => x.Konu).MinimumLength(25).WithMessage("Uzun bir konu giriniz");
            RandevularManager randevuManager = new RandevularManager(new EfRandevularDal());
            var values = randevuManager.TGetList();
            foreach (var item in values)
            {
                if (item.Start_Time >= DateTime.Today && item.End_Time >= DateTime.Today)
                {

                    RuleFor(x => x.Start_Time).Custom((list, context) =>
                    {
                        if (item.Start_Time <= list && item.End_Time >= list)
                        {
                            context.AddFailure(item.Start_Time + " ile " + item.End_Time + " arasında başka bir randevu bulunduğu için randevunuz eklenemedi. Lütfen Başlangıç tarihini değiştirin");
                        }
                    });
                    RuleFor(x => x.End_Time).Custom((list, context) =>
                    {
                        if (item.Start_Time <= list && item.End_Time >= list)
                        {
                            context.AddFailure(item.Start_Time + " ile " + item.End_Time + " arasında başka bir randevu bulunduğu için randevunuz eklenemedi. Lütfen Bitiş tarihini değiştirin");
                        }
                    });

                }
            }
    }

    }
}
