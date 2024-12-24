using WebApplication1.Models;

namespace WebApplication1.DAO
{
    public interface ITeacherRepository
    {
        IQueryable<Teacher> GetTeacherOnly();
        Task<Teacher> AddTeacher(Teacher teacher);
    }
}
