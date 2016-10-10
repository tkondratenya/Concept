using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Concept.Web.Models
{
    public class ResourceViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public IEnumerable<ResourceCostViewModel> ResourcesCost { get; set; }
    }
}