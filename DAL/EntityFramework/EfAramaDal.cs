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
    public class EfAramaDal : GenericRepository<Arama>, IAramaDal
    {
        public List<Arama> GetAramaListWithAramaTipi(int id, bool isAdmin)
        {
            using( var c = new context())
            {
                if (isAdmin)
                {
                    return c.Arama.Where(x => x.ArananId == id).Include(x => x.AramaTipi).Include(x => x.ArayanTipi).Include(x => x.Aranan).Include(x => x.Kaydeden).ToList();
                }
                return c.Arama.Include(x=>x.AramaTipi).Include(x=>x.ArayanTipi).Include(x=>x.Aranan).Include(x=>x.Kaydeden).ToList();

            }
        }
    }
}
