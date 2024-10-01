using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Infrastructure.Context;
using ShiftManagementApp.Infrastructure.Data;

namespace ShiftManagementApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //services.AddDbContext<ShiftManagementDbContext>(options =>
        //        options.UseSqlServer(connectionString));
        
        services.AddTransient<IPersonRepository,PersonRepository>();
        return services;
    }
}