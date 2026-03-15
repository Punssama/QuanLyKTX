using BigProject.API;
using BigProject.API.Controllers;
using BigProject.API.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var conn = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlServer(conn));

builder.Services.AddScoped<BigProject.API.Services.ITaiKhoanServices, BigProject.API.Services.TaiKhoanServices>();

builder.Services.AddControllers();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.UseRouting();
app.MapControllers();
app.Run();
