using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Service
{
    public class Service<T> : IService<T> where T : class
    {
        private DefaultConnection db;
        private IDbSet<T> Dbentity;
        public Service()
        {
            db = new DefaultConnection();
            Dbentity = db.Set<T>();
        }
        public void Delete(int id)
        {
            T entity = Dbentity.Find(id);
            Dbentity.Remove(entity);
            Save();
        }

        public IEnumerable<T> Get()
        {
            return Dbentity.AsNoTracking().ToList();
        }

        public T GetById(int id)
        {
            return Dbentity.Find(id);

        }

        public void Insert(T entity)
        {
            Dbentity.Add(entity);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            Save();
        }
    }
}
