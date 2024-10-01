using ShiftManagementApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.PersonsCases;

public class DeletePersonUseCase
{
    private readonly IPersonRepository _personRepository;

    public DeletePersonUseCase(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task ExecuteAsync(int id)
    {
        if (id <= 0)
            throw new ArgumentException("Invalid person ID");

        var person = await _personRepository.GetPersonById(id);
        if (person == null)
            throw new KeyNotFoundException("Person not found");

        await _personRepository.DeletePerson(id);
    }
}

