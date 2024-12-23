using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
builder.Services.AddDbContext<KindergartenDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString
("DefaultConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<IPostRepository, PostRepository>();
//builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddProjections().
    AddSorting().AddFiltering();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}
app.UseHttpsRedirection();
app.UseRouting();
app.UseCors(cors => cors
.AllowAnyMethod()
.AllowAnyHeader()
.SetIsOriginAllowed(origin => true)
.AllowCredentials()
);
using (var scop = app.Services.CreateScope())
{
    var services = scop.ServiceProvider;
    var dbContext = services.GetRequiredService<KindergartenDbContext>();
    dbContext.Database.EnsureCreated();
    DataSeeder.SeedDate(dbContext);
}
app.MapGraphQL("/graphgl");

app.Run();
