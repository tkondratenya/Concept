using Concept.Dal.EF;
using Concept.Dal.Entities;
using Concept.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept.Dal.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ConceptContext db;
        private ResourceRepository resourceRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new ConceptContext(connectionString);
        }

        public IRepository<Resource> Resources
        {
            get
            {
                if (resourceRepository == null)
                    resourceRepository = new ResourceRepository(db);
                return resourceRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Truncate()
        {
            db.Database.ExecuteSqlCommand("DELETE FROM [Chords]");
            db.Database.ExecuteSqlCommand("DBCC CHECKIDENT([Chords], RESEED, 0)");
            db.Database.ExecuteSqlCommand("DELETE FROM [Songs]");
            db.Database.ExecuteSqlCommand("DBCC CHECKIDENT([Songs], RESEED, 0)");
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
