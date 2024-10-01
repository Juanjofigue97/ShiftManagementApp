using Microsoft.Extensions.DependencyInjection;
using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Application.UseCases.PersonsCases;

namespace ShiftManagementApp.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<GetAllPersonsUseCase>();
        services.AddScoped<AddPersonUseCase>();
        services.AddScoped<GetPersonByIdUseCase>();
        services.AddScoped<DeletePersonUseCase>();
        services.AddScoped<UpdatePersonUseCase>();
        return services;
    }
}