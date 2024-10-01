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
    private readonly ShiftManagementDbContext _dbcontext;

    public PersonRepository(ShiftManagementDbContext dbContext)
    {
        _dbcontext = dbContext;
    }
    public async Task AddPerson(Person person)
    {
        await _dbcontext.Persons.AddAsync(person);
        await _dbcontext.SaveChangesAsync();
    }

    public Task DeletePerson(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Person>> GetAllPersons()
    {
        return await _dbcontext.Persons.ToListAsync();
    }

    public Task<Person> GetPersonById(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePerson(Person person)
    {
        throw new NotImplementedException();
    }
}
