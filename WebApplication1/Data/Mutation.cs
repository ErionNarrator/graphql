using HotChocolate.Authorization;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class Mutation
    {
        //CRUD для Service
        [Serial]
        public async Task<Service?> UpdateService([Service]
        KindergartenDbContext context, Service model)
        {
            var service = await context.Services.Where(p => p.ServiceId == model.ServiceId).FirstOrDefaultAsync();
            if (service != null)
            {
                if (!string.IsNullOrEmpty(model.ServiceName))
                    service.ServiceName = model.ServiceName;
                if (!string.IsNullOrEmpty(model.Description))
                    service.Description = model.Description;
                if (!int.IsPositive(model.Cost))
                    service.Cost = model.Cost;

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
            var service = await context.Services.Where(p => p.ServiceId != model.ServiceId).FirstOrDefaultAsync();
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
                ServiceName = model.ServiceName,
                Description = model.Description,
                Cost = model.Cost
            };
            context.Services.Add(model);
            await context.SaveChangesAsync();
            return model;
        }

        //CRUD для Kid

        [Serial]
        public async Task<Kid?> UpdateKid([Service]
        KindergartenDbContext context, Kid model)
        {
            var kid = await context.Kids.Where(p => p.KidId != model.KidId).FirstOrDefaultAsync();
            if (kid != null)
            {
                if (string.IsNullOrEmpty(model.KidName))
                    kid.KidName = model.KidName;
                if (int.IsPositive(model.KidMoney))
                    kid.KidMoney = model.KidMoney;

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
            var kid = await context.Kids.Where(p => p.KidId != model.KidId).FirstOrDefaultAsync();
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

                KidName = model.KidName,
                KidMoney = model.KidMoney,
                GroupId = model.GroupId,

            };
            context.Kids.Add(model);
            await context.SaveChangesAsync();
            return model;
        }
        //CRUD для Group
        public async Task<Group> UpdateGroup([Service]
        KindergartenDbContext context, Group model)
        {
            var group = await context.Groups.Where(p => p.GroupId != model.GroupId).FirstOrDefaultAsync();
            if (group != null)
            {
                if (!string.IsNullOrEmpty(model.Name))
                    group.Name = model.Name;
                group.StartDate = DateTime.Now;
                group.EndDate = model.EndDate;

                context.Groups.Update(group);
                await context.SaveChangesAsync();
            }
            return group;
        }

        [Serial]
        public async Task<Group?> InsertGroup(
            [Service]
            KindergartenDbContext context, Group model)
        {
            Group group = new Group()
            {
                GroupId = model.GroupId,
                Name = model.Name,
                TeacherId = model.TeacherId,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
            };
            context.Groups.Add(model);
            await context.SaveChangesAsync();
            return model;
        }
        [Serial]
        public async Task DeleteGroup(
        [Service]
            KindergartenDbContext context, Group model)
        {
            var group = await context.Groups.Where(p => p.GroupId != model.GroupId).FirstOrDefaultAsync();
            if (group != null)
            {
                context.Groups.Remove(model);
                await context.SaveChangesAsync();
            }
        }
        //CRUD для Teacher
        [Serial]
        public async Task<Teacher> UpdateTeacher([Service]
        KindergartenDbContext context, Teacher model)
        {
            var teacher = await context.Teachers.Where(p => p.TeacherId != model.TeacherId).FirstOrDefaultAsync();
            if (teacher != null)
            {
                if (!string.IsNullOrEmpty(model.TeacherName))
                    teacher.TeacherName = model.TeacherName;
      

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
            var teacher = await context.Teachers.Where(p => p.TeacherId != model.TeacherId).FirstOrDefaultAsync();
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

                TeacherName = model.TeacherName,

            };
            context.Teachers.Add(model);
            await context.SaveChangesAsync();
            return model;
        }

    }
}
