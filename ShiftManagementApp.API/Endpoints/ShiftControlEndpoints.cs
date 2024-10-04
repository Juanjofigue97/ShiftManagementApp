using ShiftManagementApp.Application.Dtos.RequestDTO;
using ShiftManagementApp.Application.UseCases.ShiftControlCases;
using ShiftManagementApp.Library.Entities;

namespace ShiftManagementApp.API.Endpoints;

public static class ShiftControlEndpoints
{
    public static void ConfigureShiftControlApi(this WebApplication app)
    {
        // Obtener todos los ShiftControl
        app.MapGet("/shiftcontrols", async (GetAllShiftControlsUseCase getAllShiftControlsUseCase) =>
        {
            var shiftControls = await getAllShiftControlsUseCase.ExecuteAsync();
            return Results.Ok(shiftControls);
        })
        .WithName("GetAllShiftControls")
        .WithOpenApi();

        // Obtener un ShiftControl por ID
        app.MapGet("/shiftcontrols/{id:int}", async (int id, GetShiftControlByIdUseCase getShiftControlByIdUseCase) =>
        {
            var shiftControl = await getShiftControlByIdUseCase.ExecuteAsync(id);
            if (shiftControl is null) return Results.NotFound();
            return Results.Ok(shiftControl);
        })
        .WithName("GetShiftControlById")
        .WithOpenApi();

        // Crear un nuevo ShiftControl
        app.MapPost("/shiftcontrols", async (ShiftControlRequestDTO shiftControlRequest, CreateShiftControlUseCase<ShiftControlRequestDTO> createShiftControlUseCase) =>
        {
            await createShiftControlUseCase.ExecuteAsync(shiftControlRequest);
            return Results.Created();
        })
        .WithName("AddShiftControl")
        .WithOpenApi();

        // Actualizar un ShiftControl existente
        app.MapPut("/shiftcontrols/{id:int}", async (int id, ShiftControlRequestDTO shiftControlRequest, UpdateShiftControlUseCase<ShiftControlRequestDTO> updateShiftControlUseCase) =>
        {
            if (id != shiftControlRequest.Id) return Results.BadRequest("ID mismatch");
            await updateShiftControlUseCase.ExecuteAsync(id,shiftControlRequest);
            return Results.Ok(shiftControlRequest);
        })
        .WithName("UpdateShiftControl")
        .WithOpenApi();

        // Eliminar un ShiftControl por ID
        app.MapDelete("/shiftcontrols/{id:int}", async (int id, DeleteShiftControlUseCase deleteShiftControlUseCase) =>
        {
            await deleteShiftControlUseCase.ExecuteAsync(id);
            return Results.Ok();
        })
        .WithName("DeleteShiftControl")
        .WithOpenApi();
    }
}
