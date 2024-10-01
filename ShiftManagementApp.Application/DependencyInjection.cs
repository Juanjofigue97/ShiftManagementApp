using Microsoft.Extensions.DependencyInjection;
using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Application.UseCases;

namespace ShiftManagementApp.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<GetAllPersonsUseCase>();
        return services;
    }
}