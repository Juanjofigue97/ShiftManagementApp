using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.PersonsCases;

public class UpdatePersonUseCase
{
    private readonly IPersonRepository _personRepository;

    public UpdatePersonUseCase(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task ExecuteAsync(Person person)
    {
        if (person == null || person.Id <= 0)
            throw new ArgumentException("Invalid person details");

        var existingPerson = await _personRepository.GetPersonById(person.Id);
        if (existingPerson == null)
            throw new KeyNotFoundException("Person not found");

        await _personRepository.UpdatePerson(person);
    }
}