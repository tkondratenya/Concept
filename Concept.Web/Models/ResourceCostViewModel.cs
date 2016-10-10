using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Concept.Web.Models
{
    public class ResourceCostViewModel
    {
        public int Id { get; set; }
        public ResourceViewModel Resource { get; set; }
        public CostViewModel Cost { get; set; }
    }
}