using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept.Dal.EF
{
    public class MigrationsContextFactory : IDbContextFactory<ConceptContext>
    {
        public ConceptContext Create()
        {
            return new ConceptContext("DefaultConnection");
        }
    }
}