using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.Repositry;

namespace MyShop.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceRepositry _serviceRepositry;

        public ServiceController(IServiceRepositry serviceRepositry)
        {
            _serviceRepositry = serviceRepositry;
            
        }
        //list all servise
        [HttpGet]
        public ActionResult Index()
        {
            List<Service> listo = _serviceRepositry.GetAllServce();
            return View(listo);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Service service)
        {
            _serviceRepositry.Create(service);
            List<Service> listo = _serviceRepositry.GetAllServce();
            return View("Index", listo);
        }


        public ViewResult Delete(int id)
        {
            _serviceRepositry.Delete(id);
            List<Service> listo = _serviceRepositry.GetAllServce();
            return View("Index",listo);
        }
    }
}
