using AutoMapper;
using Concept.Bll.DTO;
using Concept.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Concept.Web.AutoMapper
{
    public class DTOToViewModelMappingProfile : Profile
    {
        public DTOToViewModelMappingProfile()
        {
            CreateMap<ResourceDTO, ResourceViewModel>().ReverseMap();
            CreateMap<ResourceCostDTO, ResourceCostViewModel>().ReverseMap(); //TODO: use only ResourceViewModel
            CreateMap<CostDTO, CostViewModel>().ReverseMap();
        }
    }
}