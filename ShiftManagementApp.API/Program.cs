using Microsoft.EntityFrameworkCore;
using ShiftManagementApp.API.Endpoints;
using ShiftManagementApp.Application;
using ShiftManagementApp.Infrastructure;
using ShiftManagementApp.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

var FrontEnt = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: FrontEnt,
                      builder =>
                      {
                          builder.WithOrigins("http://localhost:5173")
                                 .AllowAnyHeader()
                                 .AllowAnyMethod();
                      });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ShiftManagementDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddInfrastructure();
builder.Services.AddApplication();


var app = builder.Build();

app.UseCors(FrontEnt);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Add Endpoints

app.ConfigurePersonApi();
app.ConfigureServiceApi();
app.ConfigureServiceLocationApi();

app.Run();
