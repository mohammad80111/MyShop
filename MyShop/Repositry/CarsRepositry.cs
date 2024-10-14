using MyShop.Models;

namespace MyShop.Repositry
{
    public class CarsRepositry : ICarsRepositry
    {
        private readonly ApplicationDbContext _context;

        public CarsRepositry(ApplicationDbContext applicationDb)
        {
            _context = applicationDb;
            
        }
        public void Create(Car car)
        {
            _context.Cars.Add(car); 
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Car car=(from ca in  _context.Cars
                     where ca.CarID == id  
                     select ca).FirstOrDefault();
            _context.Cars.Remove(car);  
            _context.SaveChanges(); 

        }

        public List<Car> GetAllCars()
        {
            List<Car> lista=(from ca in _context.Cars
                             select ca).ToList();
            return lista;
        }
    }
}
