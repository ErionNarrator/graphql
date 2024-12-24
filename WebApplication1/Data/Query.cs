using WebApplication1.DAO;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class Query
    {

        //[UseProjection]
        //[UseFiltering]
        //[UseSorting]
        //public IQueryable<Post> GetPosts([Service] BlogDbContext context) => context.Posts;

        //[UseProjection]
        //[UseFiltering]
        //[UseSorting]
        //public IQueryable<Comment> GetComment([Service] BlogDbContext context) => context.Comments;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Service")]
        public IQueryable<Service> GetServices([Service] IServiceRepository serviceRepository) => serviceRepository.GetServiceOnly();

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Kid")]

        public IQueryable<Kid> GetKids([Service] IKidRepository kidRepository) => kidRepository.GetKidOnly();

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Groups")]
        public IQueryable<Group> GetGroups([Service] IGroupRepository groupRepository) => groupRepository.GetGroupOnly();    

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Teacher")]

        public IQueryable<Teacher> GetComments([Service] ITeacherRepository teacherRepository) => teacherRepository.GetTeacherOnly();
    }
}
