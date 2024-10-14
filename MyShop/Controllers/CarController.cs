using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.Repositry;

namespace MyShop.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarsRepositry _carsRepositry;
        private readonly ICarsSizeRepositry _carsSizeRepositry;
        private readonly IServiceRepositry _serviceRepositry;
       

        public CarController(ICarsRepositry carsRepositry ,ICarsSizeRepositry carsSizeRepositry,IServiceRepositry serviceRepositry)
        {

            _carsRepositry = carsRepositry;
            _carsSizeRepositry = carsSizeRepositry;
            _serviceRepositry = serviceRepositry;
        
        }
        //list all car
        [HttpGet]
        public ActionResult Index()
        {
           List<Car> lista=_carsRepositry.GetAllCars();
            return View(lista);
        }


        [HttpGet]
        public ActionResult Create()
        {
            CarSizeService c2= new CarSizeService();
            c2.ServicesVM = _serviceRepositry.GetAllServce();
            c2.CarSizesVM=_carsSizeRepositry.GetAllCarSize();
           
            return View(c2);
        }

        [HttpPost]
        public ActionResult Create(Car car)
        { 
            _carsRepositry.Create(car);
			List<Car> lista = _carsRepositry.GetAllCars();
			return View("Index",lista);
        }

        public ViewResult Delete(int id)
        {
            _carsRepositry.Delete(id);
            
            return View();
        }
    }
}
