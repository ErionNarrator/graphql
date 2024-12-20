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
        public IQueryable<Service> GetServices([Service] KindergartenDbContext context) => context.Services;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Kid> GetKids([Service] KindergartenDbContext context) => context.Kids;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Group> GetGroups([Service] KindergartenDbContext context) => context.Groups;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Teacher> GetTeachers([Service] KindergartenDbContext context) => context.Teachers;

    }
}
