using MyShop.Models;

namespace MyShop.Repositry
{
    public interface IServiceRepositry
    {
        public List<Service> GetAllServce();

        public void Create(Service service);

        public void Delete(int id);
    }
}
