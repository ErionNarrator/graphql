using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DAO
{
    public class GroupRepository : IGroupRepository
    {
        private readonly KindergartenDbContext db;
        public GroupRepository(KindergartenDbContext db)
        {
            this.db = db;
        }
        
        public IQueryable<Group> GetGroupOnly()
        {
            return db.Groups.AsQueryable();
        }

        public async Task<Group> AddGroup(Group group)
        {
            db.Groups.Add(group);
            await db.SaveChangesAsync();
            return group;
        }

        public Group GetGroupById(long id)
        {
            var group = db.Groups.Include(p => p.Kids).FirstOrDefault(p => p.GroupId == id);
            if (group != null) return group!;
            return null!;
        }
    }
}
