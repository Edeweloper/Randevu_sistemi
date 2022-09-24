using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IAramaDal : IGenericDal<Arama>
    {
        List<Arama> GetAramaListWithAramaTipi(int id, bool isAdmin);
     
    }
}
