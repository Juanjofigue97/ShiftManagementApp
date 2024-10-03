using ShiftManagementApp.Application.Dtos.RequestDTO;
using ShiftManagementApp.Application.UseCases.ServicesLocationsCases;
using ShiftManagementApp.Library.Entities;

namespace ShiftManagementApp.API.Endpoints;

public static class ServiceLocationEndpoints
{
    public static void ConfigureServiceLocationApi(this WebApplication app)
    {
        app.MapGet("/servicelocations", async (GetAllServiceLocationsUseCase getAllServiceLocationsUseCase) =>
        {
            var serviceLocations = await getAllServiceLocationsUseCase.ExecuteAsync();
            return Results.Ok(serviceLocations);
        })
        .WithName("GetAllServiceLocations")
        .WithOpenApi();

        app.MapGet("/servicelocations/{id:int}", async (int id, GetServiceLocationByIdUseCase getServiceLocationByIdUseCase) =>
        {
            var serviceLocation = await getServiceLocationByIdUseCase.ExecuteAsync(id);
            if (serviceLocation is null) return Results.NotFound();
            return Results.Ok(serviceLocation);
        })
        .WithName("GetServiceLocationById")
        .WithOpenApi();

        app.MapPost("/servicelocations", async (ServiceLocationRequestDTO serviceLocationRequest, CreateServiceLocationUseCase<ServiceLocationRequestDTO> createServiceLocationUseCase) =>
        {
            await createServiceLocationUseCase.ExecuteAsync(serviceLocationRequest);
            return Results.Created();
        })
        .WithName("AddServiceLocation")
        .WithOpenApi();

        app.MapPut("/servicelocations/{id:int}", async (int id, ServiceLocation serviceLocation, UpdateServiceLocationUseCase updateServiceLocationUseCase) =>
        {
            if (id != serviceLocation.Id) return Results.BadRequest("ID mismatch");
            await updateServiceLocationUseCase.ExecuteAsync(serviceLocation);
            return Results.Ok(serviceLocation);
        })
        .WithName("UpdateServiceLocation")
        .WithOpenApi();

        app.MapDelete("/servicelocations/{id:int}", async (int id, DeleteServiceLocationUseCase deleteServiceLocationUseCase) =>
        {
            await deleteServiceLocationUseCase.ExecuteAsync(id);
            return Results.Ok();
        })
        .WithName("DeleteServiceLocation")
        .WithOpenApi();
    }
}
