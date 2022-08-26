using Microsoft.EntityFrameworkCore;
using Qbotech.GymIsLife.Core.Domain.Interfaces;
using Qbotech.GymIsLife.Infrastructure.MySqlDatabase.Data;
using Qbotech.GymIsLife.Infrastructure.MySqlDatabase.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Get connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DEV-CnxMySQL");
//Add dbcontext
builder.Services.AddDbContext<GILDatabaseContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


builder.Services.AddTransient<IUsersRepository, UsersRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
