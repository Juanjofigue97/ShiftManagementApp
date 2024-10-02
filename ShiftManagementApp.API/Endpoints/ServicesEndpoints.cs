using ShiftManagementApp.Application.UseCases.ServicesCases;
using ShiftManagementApp.Library.Entities;

namespace ShiftManagementApp.API.Endpoints;

public static class ServicesEndpoints
{
    public static void ConfigureServiceApi(this WebApplication app)
    {
        app.MapGet("/services", async (GetAllServicesUseCase getAllServicesUseCase) =>
        {
            var services = await getAllServicesUseCase.ExecuteAsync();
            return Results.Ok(services);
        })
        .WithName("GetAllServices")
        .WithOpenApi();

        app.MapGet("/services/{id:int}", async (int id, GetServiceByIdUseCase getServiceByIdUseCase) =>
        {
            var service = await getServiceByIdUseCase.ExecuteAsync(id);
            if (service is null) return Results.NotFound();
            return Results.Ok(service);
        })
        .WithName("GetServiceById")
        .WithOpenApi();

        app.MapPost("/services", async (Service service, CreateServiceUseCase createServiceUseCase) =>
        {
            await createServiceUseCase.ExecuteAsync(service);
            return Results.Created($"/services/{service.Id}", service);
        })
        .WithName("CreateService")
        .WithOpenApi();

        app.MapPut("/services/{id:int}", async (int id, Service service, UpdateServiceUseCase updateServiceUseCase) =>
        {
            if (id != service.Id) return Results.BadRequest("ID mismatch");
            await updateServiceUseCase.ExecuteAsync(service);
            return Results.Ok(service);
        })
        .WithName("UpdateService")
        .WithOpenApi();

        app.MapDelete("/services/{id:int}", async (int id, DeleteServiceUseCase deleteServiceUseCase) =>
        {
            await deleteServiceUseCase.ExecuteAsync(id);
            return Results.NoContent(); // Código 204
        })
        .WithName("DeleteService")
        .WithOpenApi();
    }
}


