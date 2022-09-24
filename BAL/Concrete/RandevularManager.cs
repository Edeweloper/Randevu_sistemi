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
    public class RandevularManager :IGenericService<Randevular>
    {
        IRandevularDal _randevularDal;

        public RandevularManager(IRandevularDal randevularDal)
        {
            _randevularDal = randevularDal;
        }

        public void TDelete(Randevular t)
        {
            _randevularDal.Delete(t);
        }

        public Randevular TGetById(int id)
        {
            return _randevularDal.GetByID(id);
        }

        public List<Randevular> TGetListByID(int id, bool isAdmin)
        {
            return _randevularDal.GetRandevularListWithRandevu_durumu(id, isAdmin);
        }

        public void TInsert(Randevular t)
        {
          _randevularDal.Insert(t);
        }

        public void TUpdate(Randevular t)
        {
            _randevularDal.Update(t);   
        }

        public List<Randevular> TGetList()
        {
            return _randevularDal.GetList();
        }
    }
}
