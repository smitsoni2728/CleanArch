using Application.IRepository;
using Domain.Models;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Audit.Core;
using Audit.WebApi;

// var logger = NLog.LogManager.Setup().ReloadConfiguration().GetCurrentClassLogger();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IEmployeeRepo, EmployeeRepository>();
builder.Services.AddDbContext<TrainingContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("constring"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false)
       .Build();

// builder.Logging.ClearProviders();
// builder.Host.UseNLog();
var _loggrer = new LoggerConfiguration()
.ReadFrom.Configuration(builder.Configuration).Enrich.FromLogContext().CreateLogger();

Configuration.Setup().UseFileLogProvider(config => 
    config.DirectoryBuilder(_ => $@"D:\Shyam\CleanArch\Api\LogFile\{DateTime.Now}")
    .FilenameBuilder(_ => "logs"));
// Log.Logger = new LoggerConfiguration().WriteTo.File("D:\\Shyam\\CleanArch\\Api\\Log\\Logs.log", rollingInterval: RollingInterval.Day).CreateLogger();

builder.Logging.AddSerilog(_loggrer);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();

app.UseCors();

app.UseAuditMiddleware();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();