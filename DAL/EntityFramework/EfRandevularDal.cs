using DAL.Abstract;
using DAL.Repository;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EfRandevularDal : GenericRepository<Randevular>, IRandevularDal
    {
        public List<Randevular> GetRandevularListWithRandevu_durumu(int id, bool isAdmin)
        {
          
            using (var c = new context())
            {
                if (isAdmin)
                {
                    return c.Randevu.Where(x => x.Ziyaret_EdilenKisiId == id).Include(x => x.Randevu_Durumu).Include(x => x.Ziyaret_EdilenKisi).Include(x => x.Randevu_Kaydeden).ToList();
                }

                return c.Randevu.Include(x=>x.Randevu_Durumu).Include(x => x.Ziyaret_EdilenKisi).Include(x=>x.Randevu_Kaydeden).ToList();
            }
        }
    }
}
