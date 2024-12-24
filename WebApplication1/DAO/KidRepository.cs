using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DAO
{
    public class KidRepository : IKidRepository
    {
        private readonly KindergartenDbContext db;
        public KidRepository(KindergartenDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Kid> GetKidOnly()
        {
            return db.Kids.AsQueryable();
        }

        public async Task<Kid> AddKid(Kid kid)
        {
            db.Kids.Add(kid);
            await db.SaveChangesAsync();
            return kid;
        }

        public Kid GetKidById(long id)
        {
            var kid = db.Kids.Include(p => p. KidId).FirstOrDefault(p => p.KidId == id);
            if (kid != null) return kid!;
            return null!;
        }
    }
}
