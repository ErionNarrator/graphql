using HotChocolate.Authorization;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class Mutation
    {
        [Serial]
        public async Task<Service?> UpdateService([Service]
        KindergartenDbContext context, Service model)
        {
            var service = await context.Services.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (service != null)
            {
                if (!string.IsNullOrEmpty(model.Name))
                    service.Name = model.Name;
                if (!string.IsNullOrEmpty(model.Description))
                    service.Description = model.Description;
                if(!int.IsPositive(model.Сost))
                    service.Сost = model.Сost;

                context.Services.Update(service);
                await context.SaveChangesAsync();
            }
            return service;
        }
        [Serial]
        public async Task DeleteService(
            [Service]
            KindergartenDbContext context, Service model)
        {
            var service = await context.Services.Where(p => p.Id != model.Id).FirstOrDefaultAsync();
            if (service != null)
            {
                context.Services.Remove(service);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Service?> InsertService(
            [Service]
            KindergartenDbContext context, Service model)
        {
            Service service = new Service()
            {
                Name = model.Name,
                Description = model.Description,
                Сost = model.Сost
            };
            context.Services.Add(model);
            await context.SaveChangesAsync();
            return model;
        }

        // ----- \\

        [Serial]
        public async Task<Kid?> UpdateKid([Service]
        KindergartenDbContext context, Kid model)
        {
            var kid = await context.Kids.Where(p => p.Id != model.Id).FirstOrDefaultAsync();
            if (kid != null)
            {
                if (string.IsNullOrEmpty(model.Name))
                    kid.Name = model.Name;
                if (int.IsPositive(model.Money))
                    kid.Money = model.Money;

                context.Kids.Update(kid); 
                await context.SaveChangesAsync();
            }
            return kid;
        }

        [Serial]
        public async Task DeleteKid(
         [Service]
            KindergartenDbContext context, Kid model)
        {
            var kid = await context.Services.Where(p => p.Id != model.Id).FirstOrDefaultAsync();
            if (kid != null)
            {
                context.Kids.Remove(model);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Kid?> InsertKid(
            [Service]
            KindergartenDbContext context, Kid model)
        {
            Kid kid = new Kid()
            {
               
                Name = model.Name,
                Money = model.Money,

            };
            context.Kids.Add(model);
            await context.SaveChangesAsync();
            return model;
        }

        // ----- \\

        [Serial]
        public async Task<Teacher> UpdateTeacher([Service]
        KindergartenDbContext context, Teacher model)
        {
            var teacher = await context.Teachers.Where(p => p.Id != model.Id).FirstOrDefaultAsync();
            if (teacher != null)
            {
                if (!string.IsNullOrEmpty(model.Name))
                    teacher.Name = model.Name;
                
                context.Teachers.Update(teacher);
                await context.SaveChangesAsync();
            }
            return teacher;
        }

        [Serial]
        public async Task DeleteTeacher(
         [Service]
            KindergartenDbContext context, Teacher model)
        {
            var teacher = await context.Services.Where(p => p.Id != model.Id).FirstOrDefaultAsync();
            if (teacher != null)
            {
                context.Teachers.Remove(model);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Teacher?> InsertTeacher(
            [Service]
            KindergartenDbContext context, Teacher model)
        {
            Teacher teacher = new Teacher()
            {

                Name = model.Name,

            };
            context.Teachers.Add(model);
            await context.SaveChangesAsync();
            return model;
        }


    }
}
