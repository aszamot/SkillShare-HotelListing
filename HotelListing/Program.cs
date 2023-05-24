using Serilog;
using Serilog.Events;
using Microsoft.OpenApi.Models;
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using HotelListing.Configurations;
using HotelListing.Repositories.IRepository;
using HotelListing.Repositories.Repository;
using Microsoft.AspNetCore.Identity;
using HotelListing.Extensions;
using HotelListing.Services.Auth;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//COURSE: Configuring Serilog
builder.Host.UseSerilog();

//COURSE: Configuring database context to use sql server with connection string defined in appsetings.json
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
});

//COURSE: configuring authetication and identity and JWT
builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJWT(builder.Configuration);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//COURSE: Configuring CORS to allow everyone to access API
builder.Services.AddCors(o =>
{
    o.AddPolicy("AllowAll", builder =>
    builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
});

//COURSE: adding automapper to now what to map
builder.Services.AddAutoMapper(typeof(MapperInitializer));

//COURSE: adding UnitOfWork to work with DI
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
//COURSE: adding AuthManager to work with DI
builder.Services.AddScoped<IAuthManager, AuthManager>();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "HotelListing", Version = "v1" });
});

builder.Services.AddControllers().AddNewtonsoftJson(
    options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
    );

builder.Services.AddRouting(options => options.LowercaseUrls = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//COURSE: Allow app to use Cors
app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

//COURSE: Configuring Serilog to make a log file daily with propper timestamps
Log.Logger = new LoggerConfiguration()
    .WriteTo.File(
    path: "c:\\hotellistings\\logs\\log-.txt",
    outputTemplate: "{Timestamp:yyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
    rollingInterval: RollingInterval.Day,
    restrictedToMinimumLevel: LogEventLevel.Information
    ).CreateLogger();

try
{
    Log.Information("Application is starting");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application failed to start");
}
finally
{
    Log.CloseAndFlush();
}