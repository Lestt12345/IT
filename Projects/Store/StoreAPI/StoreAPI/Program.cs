using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StoreAPI.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// ������ DbContext � ������������� SQL Server (��� ���� ��)
builder.Services.AddDbContext<StoreDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ������ ���������� (���� ������������ Web API)
builder.Services.AddControllers();

// ������ CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// ������������ �������������� � JWT
builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer(options =>
    {
        var key = Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SecretKey"]);
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
            ValidAudience = builder.Configuration["JwtSettings:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(key)
        };
    });

var app = builder.Build();

// ������������ CORS
app.UseCors();

// ϳ�������� ��������������
app.UseAuthentication();

// ϳ�������� �����������
app.UseAuthorization();

// ������������ ����������
app.MapControllers();

// ������������ ������� �������
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// ������ ��������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
