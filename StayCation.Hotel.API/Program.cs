using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Core.Services;
using StayCation.Hotel.Core.Utilities;
using StayCation.Hotel.Infrastructure;
using StayCation.Hotel.Infrastructure.Repositories;
using StayCation.Hotel.Models.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IBlogServices, BlogServices>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<ICategoryServices, CategoryServices>();
builder.Services.AddScoped<IDetailServices, DetailServices>();
builder.Services.AddScoped<IHotelService, HotelService>();
builder.Services.AddScoped<IImageServices, ImageServices>();
builder.Services.AddScoped<ILocationServices, LocationServices>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddScoped<IUserServices, UserServices>();

// Add services to the container.
IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .AddCommandLine(args)
    .Build();
string connectionString = config["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<HotelDbContext>(options =>
        options.UseSqlServer(connectionString));
builder.Services.AddAutoMapper(typeof(HotelAutoMapper));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var scope = app.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<HotelDbContext>();
//HotelSeeder.SeedData(dbContext);

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
