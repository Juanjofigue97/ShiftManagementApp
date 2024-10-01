using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.PersonsCases;

public class GetPersonByIdUseCase
{
    private readonly IPersonRepository _personRepository;

    public GetPersonByIdUseCase(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<Person> ExecuteAsync(int id)
    {
        if (id <= 0)
            throw new ArgumentException("Invalid person ID");

        var person = await _personRepository.GetPersonById(id);
        if (person == null)
            throw new KeyNotFoundException("Person not found");

        return person;
    }
}
