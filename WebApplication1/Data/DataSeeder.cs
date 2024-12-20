using WebApplication1.Models;
using Faker;
using System.Data.SqlTypes;
using Microsoft.Extensions.Hosting;

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
                        Name = Name.FullName(),
                        Money = r.Next(1, 1000)
                    };
                    db.Kids.Add(kid);
                    for (int j = 0; j < 10; j++)
                    {
                       Random n = new Random();
                        var service = new Service()
                        {
                            Name = Name.FullName(),
                            Description = Lorem.Sentence(10),
                            Сost = n.Next(1, 1000)
                        };
                        db.Services.Add(service);
                    }
                    for (int t = 0; t < 10; t++)
                    {
                        var teacher = new Teacher()
                        {
                            Name = Name.FullName()
                        };
                        db.Teachers.Add(teacher);
                    }
                    for (int g = 0; g < 10; g++)
                    {
                        var group = new Group()
                        {
                            Name = Name.FullName()
                        };
                        db.Groups.Add(group);
                        
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
