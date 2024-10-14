using MyShop.Models;

namespace MyShop.Repositry
{
    public interface ICarsSizeRepositry
    {
        public List<CarSize> GetAllCarSize();

        public void Create(CarSize carSize);

        public void Delete(int id);
    }
}
