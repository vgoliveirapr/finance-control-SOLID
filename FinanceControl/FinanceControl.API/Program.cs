using FinanceControl.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using FinanceControl.API.Application;
using FinanceControl.API.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

var connectionString = Environment.GetEnvironmentVariable("FINANCE_DB_CONNECTION");

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Databases
builder.Services.AddDbContext<FinanceControlDbContext>(options =>
    options.UseMySql(connectionString,
    new MySqlServerVersion(new Version(11, 7, 2))));

//services created for finantial transaction use
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();


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
