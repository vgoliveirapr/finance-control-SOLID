using FinanceControl.Application.Factories;
using FinanceControl.Application.Services;
using FinanceControl.Infraestructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//services created for finantial transaction use
builder.Services.AddSingleton<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<DataRepositoryService>();
builder.Services.AddScoped<TransactionCreditService>();
builder.Services.AddScoped<TransactionDebitService>();
builder.Services.AddScoped<TransactionServiceFactory>();

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
