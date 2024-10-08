﻿using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.PersonsCases;

public class CreatePersonUseCase<TDTO>
{
    private readonly IPersonRepository _personRepository;
    private readonly IMapper<TDTO, Person> _mapper;

    public CreatePersonUseCase(IPersonRepository personRepository, IMapper<TDTO, Person> mapper)
    {
        _personRepository = personRepository;
        _mapper = mapper;
    }

    public async Task ExecuteAsync(TDTO personDTO)
    {
        var person = _mapper.ToEntity(personDTO);
        
        if (person == null)
            throw new ArgumentNullException(nameof(person));

        if (string.IsNullOrWhiteSpace(person.FirstName) || string.IsNullOrWhiteSpace(person.LastName))
            throw new ArgumentException("First and Last Name are required");

        await _personRepository.AddPerson(person);
    }
}
