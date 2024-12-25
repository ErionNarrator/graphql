using WebApplication1.Models;
using Faker;
using System.Data.SqlTypes;
using Microsoft.Extensions.Hosting;
using System.Security.Cryptography;
using System;
using System.Linq;

namespace WebApplication1.Data
{
    public static class DataSeeder
    {
       
        public static void SeedDate(KindergartenDbContext db)
        {
            if (!db.Teachers.Any())
            {
                var teachers = db.Teachers.ToList();
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
                for (int g = 0; g < 10; g++)
                {
                    Random random = new Random();
                    var group = new Group()
                    {
                        Name = Name.FullName(),
                        TeacherId = db.Teachers.OrderBy(c => Guid.NewGuid()).First().TeacherId,
                        StartDate = DateTime.Now.AddDays(-random.Next(1, 30)),
                        EndDate = DateTime.Now.AddDays(random.Next(1, 30)),
                    };
                    db.Groups.Add(group);

                }
                db.SaveChanges();

            }

            if (!db.Kids.Any())
            {
                var kids = db.Kids.ToList();
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    var kid = new Kid()
                    {
                        KidName = Name.FullName(),
                        KidMoney = r.Next(1, 1000),
                        GroupId = db.Groups.OrderBy(g => Guid.NewGuid()).First().GroupId
                    };
                    db.Kids.Add(kid);
                }
                db.SaveChanges();
            }
            
       
            if (!db.Services.Any())
            {
                var services = db.Services.ToList();
                var groups = db.Groups.ToList();

                for (int s = 0; s < 10; s++)
                {
                    Random random = new Random();
                    var service = new Service()
                    {
                        ServiceName = Name.FullName(),
                        Description= Lorem.Sentence(2),
                        Cost = random.Next(1, 1000),
                        GroupId = db.Groups.OrderBy(g => Guid.NewGuid()).First().GroupId

                    };
                    db.Services.Add(service);
                }
                db.SaveChanges();
            }
        }
    }
}
