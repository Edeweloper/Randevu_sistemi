using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new context();
            return c.Set<T>().ToList();
        }

        public List<T> GetListByID(int id, bool isAdmin)
        {
            using var c = new context();
            return c.Set<List<T>>().Find(id, isAdmin);
        }

        public void Insert(T t)
        {
            using var c = new context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
