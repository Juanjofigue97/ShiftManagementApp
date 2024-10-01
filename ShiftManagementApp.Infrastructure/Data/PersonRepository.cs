using Microsoft.EntityFrameworkCore;
using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Infrastructure.Context;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Infrastructure.Data;

public class PersonRepository : IPersonRepository
{
    private readonly ShiftManagementDbContext _dbContext;

    public PersonRepository(ShiftManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddPerson(Person person)
    {
        await _dbContext.Persons.AddAsync(person);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeletePerson(int id)
    {
        var person = await _dbContext.Persons.FindAsync(id);
        if (person != null)
        {
            _dbContext.Persons.Remove(person);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Person>> GetAllPersons()
    {
        return await _dbContext.Persons.ToListAsync();
    }

    public async Task<Person> GetPersonById(int id)
    {
        return await _dbContext.Persons.FindAsync(id);
    }

    public async Task UpdatePerson(Person person)
    {
        var existingPerson = await _dbContext.Persons.FindAsync(person.Id);
        if (existingPerson != null)
        {
            // Actualiza las propiedades necesarias
            existingPerson.FirstName = person.FirstName;
            existingPerson.LastName = person.LastName;
            existingPerson.Email = person.Email;
            existingPerson.PhoneNumber = person.PhoneNumber;
            existingPerson.PersonType = person.PersonType;

            _dbContext.Persons.Update(existingPerson);
            await _dbContext.SaveChangesAsync();
        }
    }
}
