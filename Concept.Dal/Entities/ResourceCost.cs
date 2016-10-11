using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept.Dal.Entities
{
    public class ResourceCost
    {
        public int Id { get; set; }
        public int Cost { get; set; }

        public int ResourceId { get; set; }
        public Resource Resource { get; set; }
    }
}
