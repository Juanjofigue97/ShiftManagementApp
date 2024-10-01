using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.Interfaces;

public interface IPersonRepository
{
    Task<Person> GetPersonById(int id);
    Task <IEnumerable<Person>> GetAllPersons();
    Task AddPerson(Person person);
    Task UpdatePerson(Person person);
    Task DeletePerson(int id);
}
