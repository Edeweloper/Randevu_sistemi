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
    public class ArayanTipiManager : IGenericService<ArayanTipi>
    {
        IArayanTipiDal _arayanTipiDal;

        public ArayanTipiManager(IArayanTipiDal arayanTipiDal)
        {
            _arayanTipiDal = arayanTipiDal;
        }

        public void TDelete(ArayanTipi t)
        {
            _arayanTipiDal.Delete(t);
        }
        public ArayanTipi TGetById(int id)
        {
            return _arayanTipiDal.GetByID(id);
        }

        public List<ArayanTipi> TGetList()
        {
            return _arayanTipiDal.GetList();
        }

        public void TInsert(ArayanTipi t)
        {
            _arayanTipiDal.Insert(t);
        }

        public void TUpdate(ArayanTipi t)
        {
          _arayanTipiDal.Update(t);
        }
    }
}
