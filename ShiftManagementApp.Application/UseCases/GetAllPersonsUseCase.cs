using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases;

public class GetAllPersonsUseCase
{
    private readonly IPersonRepository _personRepository;

    public GetAllPersonsUseCase(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<IEnumerable<Person>> ExecuteAsync()
    {
        return await _personRepository.GetAllPersons();
    }
}
