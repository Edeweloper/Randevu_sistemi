using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IRandevularDal:IGenericDal<Randevular>
    {
        List<Randevular> GetRandevularListWithRandevu_durumu(int id, bool isAdmin);
    }
}
