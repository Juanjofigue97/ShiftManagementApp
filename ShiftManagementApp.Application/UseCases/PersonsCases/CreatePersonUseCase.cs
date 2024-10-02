using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.PersonsCases;

public class CreatePersonUseCase
{
    private readonly IPersonRepository _personRepository;

    public CreatePersonUseCase(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task ExecuteAsync(Person person)
    {
        if (person == null)
            throw new ArgumentNullException(nameof(person));

        if (string.IsNullOrWhiteSpace(person.FirstName) || string.IsNullOrWhiteSpace(person.LastName))
            throw new ArgumentException("First and Last Name are required");

        await _personRepository.AddPerson(person);
    }
}
