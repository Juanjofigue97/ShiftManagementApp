using Microsoft.Extensions.DependencyInjection;
using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Application.UseCases.PersonsCases;
using ShiftManagementApp.Application.UseCases.ServicesCases;
using ShiftManagementApp.Application.UseCases.ServicesLocationsCases;

namespace ShiftManagementApp.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddPersonServices();
        services.AddServiceServices();
        services.AddServiceLocationServices();

        return services;
    }

    private static IServiceCollection AddPersonServices(this IServiceCollection services)
    {
        services.AddScoped<GetAllPersonsUseCase>();
        services.AddScoped<GetPersonByIdUseCase>();
        services.AddScoped<DeletePersonUseCase>();
        services.AddScoped<UpdatePersonUseCase>();

        return services;
    }

    private static IServiceCollection AddServiceServices(this IServiceCollection services)
    {
        services.AddScoped<GetAllServicesUseCase>();
        services.AddScoped<CreateServiceUseCase>();
        services.AddScoped<GetServiceByIdUseCase>();
        services.AddScoped<DeleteServiceUseCase>();
        services.AddScoped<UpdateServiceUseCase>();

        return services;
    }

    private static IServiceCollection AddServiceLocationServices(this IServiceCollection services)
    {
        services.AddScoped<GetAllServiceLocationsUseCase>();
        services.AddScoped<CreateServiceLocationUseCase>();
        services.AddScoped<GetServiceLocationByIdUseCase>();
        services.AddScoped<DeleteServiceLocationUseCase>();
        services.AddScoped<UpdateServiceLocationUseCase>();

        return services;
    }
}
