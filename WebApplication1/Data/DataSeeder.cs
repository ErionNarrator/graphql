using WebApplication1.Models;
using Faker;
using System.Data.SqlTypes;
using Microsoft.Extensions.Hosting;
using System.Security.Cryptography;

namespace WebApplication1.Data
{
    public static class DataSeeder
    {
       
        public static void SeedDate(KindergartenDbContext db)
        {
            if (!db.Kids.Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    var kid = new Kid()
                    {   
                        KidName = Name.FullName(),
                        KidMoney = r.Next(1, 1000)
                    };
                    db.Kids.Add(kid);
                }
                db.SaveChanges();
            }
            if (!db.Teachers.Any())
            {
                for (int t = 0; t < 10; t++)
                {
                    var teacher = new Teacher()
                    {
                        TeacherName = Name.FullName()
                    };
                    db.Teachers.Add(teacher);
                }
                db.SaveChanges();

            }
            if (!db.Groups.Any())
            {
                var groups = db.Groups.ToList();
                var kids = db.Kids.ToList();
                for (int g = 0; g < 10; g++)
                {
                    var group = new Group()
                    {
                        Name = Name.FullName(),
                        KidId = db.Kids.OrderBy(k => Guid.NewGuid()).First().KidId,
                        TeacherId = db.Teachers.OrderBy(c => Guid.NewGuid()).First().TeacherId,
                    };
                    db.Groups.Add(group);

                }
                db.SaveChanges();

            }
            if (!db.Services.Any())
            {
                var teachers = db.Teachers.ToList();
                for (int s = 0; s < 10; s++)
                {
                    Random random = new Random();
                    var service = new Service()
                    {
                        ServiceName = Name.FullName(),
                        Description= Lorem.Sentence(2),
                        Cost = random.Next(1, 1000),
                        TeacherId = db.Teachers.OrderBy(c => Guid.NewGuid()).First().TeacherId,

                    };
                    db.Services.Add(service);
                }
                db.SaveChanges();
            }
        }
    }
}
