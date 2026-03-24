using BigProject.API;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var conn = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlServer(conn));

builder.Services.AddScoped<BigProject.API.Services.ITaiKhoanServices, BigProject.API.Services.TaiKhoanServices>();
builder.Services.AddScoped<BigProject.API.Services.IPhongOServices, BigProject.API.Services.PhongOServices>();
builder.Services.AddScoped<BigProject.API.Services.IHopDongServices, BigProject.API.Services.HopDongServices>();
builder.Services.AddScoped<BigProject.API.Services.IBaoCaoThongKeServices, BigProject.API.Services.BaoCaoThongKeServices>();

builder.Services.AddControllers();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.UseRouting();
app.MapControllers();
app.Run();
