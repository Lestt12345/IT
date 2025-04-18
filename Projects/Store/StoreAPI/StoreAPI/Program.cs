using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// ������ DbContext � ������������� SQL Server (��� ���� ��)
builder.Services.AddDbContext<StoreDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ������ ���������� (���� ������������ Web API)
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ������������ ����������
app.MapControllers();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
