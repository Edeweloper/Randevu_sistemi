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
    public class AramaTipiManager : IGenericService<AramaTipi>
        

    {
        IAramaTipiDal _aramaTipiDal;

        public AramaTipiManager(IAramaTipiDal aramaTipiDal)
        {
            _aramaTipiDal = aramaTipiDal;
        }

        public void TDelete(AramaTipi t)
        {
            _aramaTipiDal.Delete(t);
        }

     

        public AramaTipi TGetById(int id)
        {
            return _aramaTipiDal.GetByID (id);
        }


        public List<AramaTipi> TGetList()
        {
            return _aramaTipiDal.GetList();
        }

        public void TInsert(AramaTipi t)
        {
            _aramaTipiDal.Insert(t);    
        }

        public void TUpdate(AramaTipi t)
        {
            _aramaTipiDal.Update(t);
        }
    }
}
