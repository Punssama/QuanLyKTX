using BigProject.API;
using BigProject.API.Controllers;
using BigProject.API.Models;
using BigProject.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var conn = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlServer(conn));

builder.Services.AddControllers();
builder.Services.AddScoped<ITaiKhoanService, TaiKhoanService>();
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.UseRouting();
app.MapControllers();
app.Run();
