using Concept.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept.Dal.EF
{
    public class ConceptContext : DbContext
    {
        public DbSet<Resource> Resources { get; set; }

        public ConceptContext(string connectionString)
                : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
