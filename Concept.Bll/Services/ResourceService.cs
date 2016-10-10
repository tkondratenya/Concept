using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concept.Dal.Interfaces;
using Concept.Bll.DTO;
using Concept.Bll.Interfaces;
using AutoMapper;
using Concept.Dal.Entities;

namespace Concept.Bll.Services
{
    public class ResourceService : BaseService, IResourceService
    {
        public ResourceService(IUnitOfWork uow) : base(uow)
        {
        }

        public IEnumerable<ResourceDTO> GetResources()
        {
            return Mapper.Map<IEnumerable<Resource>, IEnumerable<ResourceDTO>>(Database.Resources.GetAll().ToList());
        }

        public bool AddResource(ResourceDTO resource)
        {

            foreach(var resCost in resource.ResourcesCost)
            {
                ResourceCost resCostm = Mapper.Map<ResourceCost>(resCost);
                Database.ResourceCosts.Create(resCostm);
                Cost cost = Mapper.Map<Cost>(resCost.Cost);
                Database.Costs.Create(cost);
                Database.Save();
            }
            Resource res = Mapper.Map<Resource>(resource);
            Database.Resources.Create(res);
            Database.Save();
            return true;
        }
    }
}

