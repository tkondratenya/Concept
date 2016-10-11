using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept.Dal.Entities
{
    public class Resource : BasicResource
    {
        public virtual ICollection<ResourceCost> ResourcesCost { get; set; }
    }
}
