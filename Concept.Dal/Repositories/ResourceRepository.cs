using Concept.Dal.EF;
using Concept.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept.Dal.Repositories
{
    public class ResourceRepository : BaseRepository<Resource>
    {
        public ResourceRepository(ConceptContext context) : base(context)
        {
        }
    }
}
