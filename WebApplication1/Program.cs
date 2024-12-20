using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<KindergartenDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString
("DefaultConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGraphQL().AddQueryType<Query>().AddMutationType<Mutation>().
    AddProjections().AddFiltering().AddSorting();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}
using (var scop = app.Services.CreateScope())
{
    var services = scop.ServiceProvider;
    var dbContext = services.GetRequiredService<KindergartenDbContext>();
    dbContext.Database.EnsureCreated();
    DataSeeder.SeedDate(dbContext);
}
app.MapGraphQL("/graphgl");

app.Run();
