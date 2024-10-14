using MyShop.Models;

namespace MyShop.Repositry
{
    public class CarsSizeRepositry : ICarsSizeRepositry
    {
        private readonly ApplicationDbContext _context;
        public CarsSizeRepositry(ApplicationDbContext applicationDb)
        {
            _context = applicationDb;   
        }
        public void Create(CarSize carSize)
        {
            _context.Sizes.Add(carSize);
            _context.SaveChanges(); 
        }

        public void Delete(int id)
        {
           CarSize C1=(from cars in _context.Sizes
                       where cars.CarSizeID==id
                       select cars).FirstOrDefault();
            _context.Sizes.Remove(C1);  
            _context.SaveChanges();
        }

        public List<CarSize> GetAllCarSize()
        {
            List<CarSize> lista=(from cars in _context.Sizes
                                 select cars).ToList();
            return lista;
        }
    }
}
