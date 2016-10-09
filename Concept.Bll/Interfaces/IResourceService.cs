using Concept.Bll.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept.Bll.Interfaces
{
    public interface IResourceService : IBaseService
    {

        IEnumerable<ResourceDTO> GetResources();
        bool AddResource(ResourceDTO resource);
    }
}
