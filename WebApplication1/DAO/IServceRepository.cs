using WebApplication1.Models;

namespace WebApplication1.DAO
{
    public interface IServiceRepository
    {
        IQueryable<Service> GetServiceOnly();
        Task<Service> AddService(Service service);
        Service GetServiceById (long id);
    }
}
