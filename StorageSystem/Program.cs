using Microsoft.EntityFrameworkCore;
using System;
using StorageSystem.Models;
using StorageSystem.Interfaces;
using StorageSystem.Services;
using StorageSystem.Config;

var builder = WebApplication.CreateBuilder(args);
var allowedOrigins = "allowedOrigins";

string? DbConnectionString;

if (builder.Environment.IsDevelopment())
{
    DbConnectionString = builder.Configuration.GetConnectionString("DbConnectionDevelopment");
}
else
{
    DbConnectionString = builder.Configuration.GetConnectionString("DbConnectionProduction");
}

// Add services to the container.

builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<IStorageBinService, StorageBinService>();
builder.Services.AddScoped<IItemStorageBinService, ItemStorageBinService>();

var Configuration = builder.Configuration;

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(DbConnectionString));

builder.Services.AddAuthorization();

builder.Services.AddHttpContextAccessor();

builder.Services
    .AddIdentityApiEndpoints<ApplicationUser>(options => { })
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.ConfigureApplicationCookie(options => { options.Cookie.SameSite = SameSiteMode.None; });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowedOrigins,
    policy =>
    {
        policy
        .WithOrigins("http://localhost:5173")
        .AllowAnyHeader()
        .AllowCredentials()
        .AllowAnyMethod();

    });

});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapCustomisedIdentityApi<ApplicationUser>();

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
