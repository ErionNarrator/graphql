using WebApplication1.Models;

namespace WebApplication1.DAO
{
    public interface IKidRepository
    {
        IQueryable<Kid> GetKidOnly();
        Task<Kid> AddKid(Kid kid);
        Kid GetKidById(long id);
    }
}
