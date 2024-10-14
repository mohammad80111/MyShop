using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.Repositry;

namespace MyShop.Controllers
{
    public class CarSizeController : Controller
    {
        private readonly ICarsSizeRepositry _carsSizeRepositry;

        public CarSizeController(ICarsSizeRepositry carsSize)
        {
            _carsSizeRepositry = carsSize;
        }
        //list all CarSize
        [HttpGet]
        public ActionResult Index()
        {
            List<CarSize> listo=_carsSizeRepositry.GetAllCarSize();
            return View(listo);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
    
        public ActionResult Create(CarSize carSize)
        {
            _carsSizeRepositry.Create(carSize);
            List<CarSize> listo = _carsSizeRepositry.GetAllCarSize();
            return View("Index",listo);
        }

        public ViewResult Delete(int id)
        {
            _carsSizeRepositry.Delete(id);
            List<CarSize> listo = _carsSizeRepositry.GetAllCarSize();
            return View("Index",listo);
        }


    }
}
