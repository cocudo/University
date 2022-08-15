// 1. Usings to work with entity framework
using Microsoft.EntityFrameworkCore;
using universityApiBackend.DataAccess;

var builder = WebApplication.CreateBuilder(args);

//TODO: Connection with SQL Server

// 2. Connection with SQL
const string CONNECTIONNAME = "UniversityDb";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// 3. Add context
builder.Services.AddDbContext<UniversityDbContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
