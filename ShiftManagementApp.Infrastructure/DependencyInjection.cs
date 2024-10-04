using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShiftManagementApp.Application.Dtos.RequestDTO;
using ShiftManagementApp.Application;
using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Infrastructure.Context;
using ShiftManagementApp.Infrastructure.Data;
using ShiftManagementApp.Infrastructure.Mappers;
using ShiftManagementApp.Library.Entities;

namespace ShiftManagementApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //services.AddDbContext<ShiftManagementDbContext>(options =>
        //        options.UseSqlServer(connectionString));
        
        services.AddScoped<IPersonRepository,PersonRepository>();
        services.AddScoped<IServiceRepository,ServiceRepository>();
        services.AddScoped<IServiceLocationRepository,ServiceLocationRepository>();
        services.AddScoped<IShiftControlRepository,ShiftControlRepository>();

        services.AddScoped<IMapper<PersonRequestDTO, Person>, PersonMapper>();
        services.AddScoped<IMapper<ServiceLocationRequestDTO, ServiceLocation>, ServiceLocationMapper>();
        services.AddScoped<IMapper<ShiftControlRequestDTO, ShiftControl>, ShiftControlMapper>();

        return services;
    }
}