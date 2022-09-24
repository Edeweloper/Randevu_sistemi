using BAL.Abstract;
using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Concrete
{
    public class Randevu_durumuManager : IGenericService<Randevu_durumu>
    {
        IRandevu_durumuDal randevu_DurumuDal;
        public Randevu_durumuManager(IRandevu_durumuDal randevu_DurumuDal)
        {
            this.randevu_DurumuDal = randevu_DurumuDal;
        }

        public void TDelete(Randevu_durumu t)
        {
            randevu_DurumuDal.Delete(t);
        }

        public Randevu_durumu TGetById(int id)
        {
            return randevu_DurumuDal.GetByID(id);
        }

        public List<Randevu_durumu> TGetList()
        {
            return randevu_DurumuDal.GetList();
        }

        public void TInsert(Randevu_durumu t)
        {
            randevu_DurumuDal.Insert(t);    
        }

        public void TUpdate(Randevu_durumu t)
        {
            randevu_DurumuDal.Update(t);
        }
    }
}
