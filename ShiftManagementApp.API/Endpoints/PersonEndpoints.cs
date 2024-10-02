using ShiftManagementApp.Application.UseCases.PersonsCases;
using ShiftManagementApp.Application.Dtos.RequestDTO;
using ShiftManagementApp.Library.Entities;

namespace ShiftManagementApp.API.Endpoints;

public static class PersonEndpoints
{
    public static void ConfigurePersonApi(this WebApplication app)
    {
        app.MapGet("/persons", async (GetAllPersonsUseCase getAllPersonsUseCase) =>
        {
            var persons = await getAllPersonsUseCase.ExecuteAsync();
            return Results.Ok(persons);
        })
        .WithName("GetAllPersons")
        .WithOpenApi();

        app.MapGet("/persons/{id:int}", async (int id, GetPersonByIdUseCase getPersonByIdUseCase) =>
        {
            var person = await getPersonByIdUseCase.ExecuteAsync(id);
            if (person is null) return Results.NotFound();
            return Results.Ok(person);
        })
        .WithName("GetPersonById")
        .WithOpenApi();

        app.MapPost("/persons", async (PersonRequestDTO personRequest, CreatePersonUseCase<PersonRequestDTO> addPersonUseCase) =>
        {
            await addPersonUseCase.ExecuteAsync(personRequest);
            return Results.Created();
        })
        .WithName("AddPerson")
        .WithOpenApi();

        app.MapPut("/persons/{id:int}", async (int id, Person person, UpdatePersonUseCase updatePersonUseCase) =>
        {
            if (id != person.Id) return Results.BadRequest("ID mismatch");
            await updatePersonUseCase.ExecuteAsync(person);
            return Results.Ok(person);
        })
        .WithName("UpdatePerson")
        .WithOpenApi();

        app.MapDelete("/persons/{id:int}", async (int id, DeletePersonUseCase deletePersonUseCase) =>
        {
            await deletePersonUseCase.ExecuteAsync(id);
            return Results.Ok();
        })
        .WithName("DeletePerson")
        .WithOpenApi();
    }
}
