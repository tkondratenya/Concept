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
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}