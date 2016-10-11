using AutoMapper;
using Concept.Bll.DTO;
using Concept.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept.Bll.AutoMapper
{
    public class EntityToDTOMappingProfile : Profile
    {
        public EntityToDTOMappingProfile()
        {
            CreateMap<Resource, ResourceDTO>().ReverseMap();
            CreateMap<ResourceCost, ResourceCostDTO>().ReverseMap();
            CreateMap<Cost, CostDTO>().ReverseMap(); // TODO: implement self-reference objects mapping
            /*
           Mapper.Map<OrderLine, OrderLineDTO>()
    .ForMember(m => m.Order, opt => opt.Ignore());

Mapper.Map<Order, OrderDTO>()
    .AfterMap((src, dest) => { 
         foreach(var i in dest.OrderLines) 
             i.Order = dest;
         });
         */
        }
    }
}
