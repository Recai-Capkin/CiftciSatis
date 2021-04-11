using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiftciSatis.Data.Models;

namespace CiftciSatis.Data.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        Context c = new Context();
        public List<T> TList()
        {
            return c.Set<T>().ToList();
        }
        public void TAdd(T p)
        {
            c.Set<T>().Add(p);
            c.SaveChanges();
        }
        public void TDelete(T id)
        {
            c.Set<T>().Remove(id);
            c.SaveChanges();
        }
        public void TUpdate(T p)
        {
            c.Set<T>().Update(p);
            c.SaveChanges();
        }
    }
}
