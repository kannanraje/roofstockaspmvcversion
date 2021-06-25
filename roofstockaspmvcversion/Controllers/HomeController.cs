using roofstock.Core.Models;
using roofstock.Core.Repository;
using roofstock.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace roofstockaspmvcversion.Controllers
{
    public class HomeController : Controller
    {
        private IPropertyRepository _propertyRepository;
        public HomeController()
        {
            this._propertyRepository = new PropertyRepository(new roofstock.Core.PropertyEntities());
        }
        public ActionResult Index()
        {
            return View(_propertyRepository.GetAll());
        }

        public ActionResult Details(PropertyViewModel propertyDetails)
        {
            return View(propertyDetails);
        }
        public ActionResult AddProperty()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProperty(AddPropertyModel propertyModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Check if property already exists, throw validation error if id already exists. property id should be unique
                    //Insert property to database
                    _propertyRepository.Insert(propertyModel);
                }

            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}