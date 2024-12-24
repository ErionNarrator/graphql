using WebApplication1.Models;

namespace WebApplication1.DAO
{
    public interface IGroupRepository
    {
        IQueryable<Group> GetGroupOnly();
        Task<Group> AddGroup(Group group);
        Group GetGroupById(long id);
    }
}
