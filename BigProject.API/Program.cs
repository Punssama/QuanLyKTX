using BigProject.API;
using BigProject.API.Controllers;
using BigProject.API.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var conn = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlServer(conn));

builder.Services.AddControllers();

var app = builder.Build();
app.MapGet("/", () => "Hello Worlddddđđddd!");
app.UseRouting();
app.MapControllers();
app.Run();
