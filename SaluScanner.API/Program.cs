using Microsoft.EntityFrameworkCore;
using SaluScanner.Core.Services;
using SaluScanner.Core.UnitOfWorks;
using SaluScanner.Repository.DbContexts;
using SaluScanner.Repository.Repositories;
using SaluScanner.Repository.UnitOfWorks;
using SaluScanner.Service.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddScoped(typeof(IProductService), typeof(ProductService));


builder.Services.AddDbContext<SqlServerDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnectionString"), option =>
    {
        // Get me Assembly (App) that has SqlServerDbContext in it.
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(SqlServerDbContext)).GetName().Name);
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
