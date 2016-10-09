using Concept.Dal.EF;
using Concept.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept.Dal.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private ConceptContext db;

        public BaseRepository(ConceptContext context)
        {
            this.db = context;
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>();
        }

        public T Get(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Create(T item)
        {
            db.Set<T>().Add(item);
        }

        public void Update(T item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public IEnumerable<T> Find(Func<T, Boolean> predicate)
        {
            return db.Set<T>().Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            T item = db.Set<T>().Find(id);
            if (item != null)
                db.Set<T>().Remove(item);
        }
    }
}
