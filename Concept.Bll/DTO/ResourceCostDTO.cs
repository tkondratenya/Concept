using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept.Bll.DTO
{
    public class ResourceCostDTO
    {
        public int Id { get; set; }
        public ResourceDTO Resource { get; set; }
        public CostDTO Cost { get; set; }
    }
}
