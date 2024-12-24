using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DAO
{
    public class ServceRepository : IServiceRepository
    {
        private readonly KindergartenDbContext db;
        public ServceRepository(KindergartenDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Service> GetServiceOnly()
        {
            return db.Services.AsQueryable();
        }
        
        public async Task<Service> AddService(Service service)
        {
            db.Services.Add(service);
            await db.SaveChangesAsync();
            return service;
        }

        public Service GetServiceById(long id)
        {
            var service = db.Services.Include(p => p.ServiceId).FirstOrDefault(p => p.ServiceId == id);
            if (service != null) return service!;
            return null!;
        }
    }
}
