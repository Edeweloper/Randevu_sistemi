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
    public class AramaManager : IGenericService<Arama>

    {
        IAramaDal _aramaDal;
public AramaManager(IAramaDal aramaDal)
        {
            _aramaDal = aramaDal;
        }

        public void TDelete(Arama t)
        {
            _aramaDal.Delete(t);      
        }

      

        public Arama TGetById(int id)
        {
            return _aramaDal.GetByID(id);
        }
        public List<Arama> TGetListByID(int id, bool isAdmin)
        {
            return _aramaDal.GetAramaListWithAramaTipi(id, isAdmin);
        }

        
       

        public void TInsert(Arama t)
        {
            _aramaDal.Insert(t);
        }

       

        public void TUpdate(Arama t)
        {
            _aramaDal.Update(t);    
        }

       

        Arama IGenericService<Arama>.TGetById(int id)
        {
            throw new NotImplementedException();
        }

        List<Arama> IGenericService<Arama>.TGetList()
        {
            throw new NotImplementedException();
        }
        public List<Arama> TGetList()
        {
            return _aramaDal.GetList();
        }
    }
}
