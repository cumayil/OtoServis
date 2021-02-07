using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OtoServis.Business.Abstract;
using OtoServis.Business.Concrete;
using OtoServis.DataAccess.Concrete.EntityFramework;
using OtoServis.Entities.Concrete;
using OtoServis.Models;
using OtoServis.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OtoServis.Controllers
{
    public class HomeController : Controller
    {
        
        private IServiceOperationService _serviceOperationService;

        public HomeController(ILogger<HomeController> logger)
        {
           
            _serviceOperationService = new ServiceOperationManager(new EfServiceOperationDal()); 
        }
        [Route("anasayfa")]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        [Route("anasayfa")]
        public IActionResult Add(ServiceOperation serviceOperation)
        {
            if (serviceOperation.Id == 0)
            {
                _serviceOperationService.Add(serviceOperation);
            }
            _serviceOperationService.Update(serviceOperation);
            

            return RedirectToAction("Index", "Home");
        }

        [Route("list")]
        public IActionResult List()
        {
            ServiceOperationViewModel model = new ServiceOperationViewModel()
            {
                serviceOperations = _serviceOperationService.GetAll()
            };
            return View(model);
        }
        [Route("car-detail/{id}")]
        public IActionResult Details(int id)
        {
            ServiceOperationViewModel model = new ServiceOperationViewModel()
            {
                serviceOperation = _serviceOperationService.Get(id),
                serviceOperations = _serviceOperationService.GetAll()
            };
            return View(model);
        }
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            _serviceOperationService.Delete(id);
            return RedirectToAction("List", "Home");
        }
        [Route("update/{id}")]
        public ActionResult Update(int id)
        {
            ServiceOperationViewModel model = new ServiceOperationViewModel()
            {
                serviceOperation= _serviceOperationService.Get(id)
            };
           
            return View("Index", model);
        }

       
    }
}
