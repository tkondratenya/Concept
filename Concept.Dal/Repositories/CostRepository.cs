using Concept.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concept.Dal.EF;

namespace Concept.Dal.Repositories
{
    public class CostRepository : BaseRepository<Cost>
    {
        public CostRepository(ConceptContext context) : base(context)
        {
        }
    }
}
