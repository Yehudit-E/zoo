using Microsoft.EntityFrameworkCore;
using Zoo.API.Controllers;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;
using Zoo.Core.Interfaces.IServices;
using Zoo.Data;
using Zoo.Data.Repository;
using Zoo.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(
    options =>{ 
        options.UseSqlServer("Data Source = DESKTOP-8ED3CL9; Initial Catalog = db_zoo; Integrated Security = true; "); 
    }
);

builder.Services.AddScoped<IAnimalsService, AnimalsService>();
builder.Services.AddScoped<IEmployeesService, EmployeesService>();
builder.Services.AddScoped<IOrdersService, OrdersService>();
builder.Services.AddScoped<IShowsService, ShowsService>();
builder.Services.AddScoped<ITicketsService, TicketsService>();
builder.Services.AddScoped<IVisitorsService, VisitorsService>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
