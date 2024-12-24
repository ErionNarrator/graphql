using WebApplication1.Models;

namespace WebApplication1.DAO
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly KindergartenDbContext db;
        public TeacherRepository(KindergartenDbContext db)
        {
            this.db = db;
        }
        public IQueryable<Teacher> GetTeacherOnly()
        {
            return db.Teachers.AsQueryable();
        }

        public async Task<Teacher> AddTeacher(Teacher teacher)
        {
            db.Teachers.Add(teacher);
            await db.SaveChangesAsync();
            return teacher;
        }
    }
}
