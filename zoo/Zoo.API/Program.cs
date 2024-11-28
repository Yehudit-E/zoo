
using Zoo.API.Controllers;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;
using Zoo.Data;
using Zoo.Data.Repository;
using Zoo.Service.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<DataContext>();
builder.Services.AddScoped<IService<Animal>, AnimalsService>();
builder.Services.AddScoped<IRepository<Animal>, AnimalsRepository>();
builder.Services.AddScoped<IService<Employee>, EmployeesService>();
builder.Services.AddScoped<IRepository<Employee>, EmployeesRepository>();
builder.Services.AddScoped<IService<Order>, OrdersService>();
builder.Services.AddScoped<IRepository<Order>, OrdersRepository>();
builder.Services.AddScoped<IService<Show>, ShowsService>();
builder.Services.AddScoped<IRepository<Show>, ShowsRepository>();
builder.Services.AddScoped<IService<Ticket>, TicketsService>();
builder.Services.AddScoped<IRepository<Ticket>, TicketsRepository>();
builder.Services.AddScoped<IService<Visitor>, VisitorsService>();
builder.Services.AddScoped<IRepository<Visitor>, VisitorsRepository>();



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
