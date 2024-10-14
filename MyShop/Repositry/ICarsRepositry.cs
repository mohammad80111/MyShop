using MyShop.Models;

namespace MyShop.Repositry
{
    public interface ICarsRepositry
    {
        public List<Car> GetAllCars();

        public void Create(Car car);    

        public void Delete(int id);
    }
}
