using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Abstract
{
    public interface IRandevularService:IGenericService<Randevular>
    {
        List<Randevular> GetRandevularListWithRandevu_durumu();
    }
}
