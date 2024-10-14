using MyShop.Models;

namespace MyShop.Repositry
{
    public class ServiceRepositry : IServiceRepositry
    {
        private readonly ApplicationDbContext _context;

        public ServiceRepositry(ApplicationDbContext applicationDb)
        {
            _context = applicationDb;
            
        }
        public void Create(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Service S1=(from ser in _context.Services
                        where ser.ServiceId == id
                        select ser).FirstOrDefault();  
            _context.Services.Remove(S1);
            _context.SaveChanges();
        }

        public List<Service> GetAllServce()
        {
            List<Service> list =(from ser in _context.Services
                                 select ser).ToList();
            return list;
        }
    }
}
