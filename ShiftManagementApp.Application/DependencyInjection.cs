using Microsoft.Extensions.DependencyInjection;
using ShiftManagementApp.Application.Dtos.RequestDTO;
using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Application.UseCases.PersonsCases;
using ShiftManagementApp.Application.UseCases.ServicesCases;
using ShiftManagementApp.Application.UseCases.ServicesLocationsCases;
using ShiftManagementApp.Application.UseCases.ShiftControlCases;

namespace ShiftManagementApp.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddPersonServices();
        services.AddServiceServices();
        services.AddServiceLocationServices();
        services.AddShiftControlServices();
        return services;
    }

    private static IServiceCollection AddPersonServices(this IServiceCollection services)
    {
        services.AddScoped<GetAllPersonsUseCase>();
        services.AddScoped<GetPersonByIdUseCase>();
        services.AddScoped<DeletePersonUseCase>();
        services.AddScoped<UpdatePersonUseCase>();
        services.AddScoped<CreatePersonUseCase<PersonRequestDTO>>();

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
        services.AddScoped<CreateServiceLocationUseCase<ServiceLocationRequestDTO>>();
        services.AddScoped<GetServiceLocationByIdUseCase>();
        services.AddScoped<DeleteServiceLocationUseCase>();
        services.AddScoped<UpdateServiceLocationUseCase>();

        return services;
    }
    private static IServiceCollection AddShiftControlServices(this IServiceCollection services)
    {
        services.AddScoped<GetAllShiftControlsUseCase>();
        services.AddScoped<CreateShiftControlUseCase<ShiftControlRequestDTO>>();
        services.AddScoped<GetShiftControlByIdUseCase>();
        services.AddScoped<DeleteShiftControlUseCase>();
        services.AddScoped<UpdateShiftControlUseCase<ShiftControlRequestDTO>>();

        return services;
    }
}
