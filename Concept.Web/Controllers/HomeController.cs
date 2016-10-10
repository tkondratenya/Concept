using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Concept.Bll.Interfaces;
using Concept.Web.Models;
using AutoMapper;
using Concept.Bll.DTO;

namespace Concept.Web.Controllers
{
    public class HomeController : Controller
    {
        IResourceService resourceService;

        public HomeController(IResourceService resourceService)
        {
            this.resourceService = resourceService;
        }

        public ActionResult Index()
        {
            var resourceDtos = resourceService.GetResources();
            IEnumerable<ResourceViewModel> resources = Mapper.Map<IEnumerable<ResourceViewModel>>(resourceDtos);
            
            return View(resources);
        }

        [HttpGet]
        public ActionResult CreateResource()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateResource(ResourceViewModel resource)
        {
            resourceService.AddResource(Mapper.Map<ResourceDTO>(resource));
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            var resourceDto = resourceService.GetResources().Where(r=>r.Id == 6).FirstOrDefault();
            ResourceViewModel resource = Mapper.Map<ResourceViewModel>(resourceDto);

            List<ResourceCostViewModel> lrcvm = new List<ResourceCostViewModel>();
            for(int i = 0; i<3; i++)
            {
                CostViewModel cvm = new CostViewModel
                {
                    Gold = 3,
                    Silver = 56,
                    Copper = 24
                };
                ResourceCostViewModel rcvm = new ResourceCostViewModel
                {
                    Resource = resource,
                    Cost = cvm
                };
                lrcvm.Add(rcvm);
            }
            var newResource = new ResourceViewModel
            {
                Name = "test1",
                ImageUrl = "test/url",
                Description = "Test description",
                ResourcesCost = lrcvm
            };
            resourceService.AddResource(Mapper.Map<ResourceDTO>(newResource));
            return View();
        }
    }
}