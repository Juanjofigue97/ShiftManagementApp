using ShiftManagementApp.Application;
using ShiftManagementApp.Application.Dtos.RequestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Infrastructure.Mappers;

public class PersonMapper : IMapper<PersonRequestDTO, Person>
{
    public Person ToEntity(PersonRequestDTO dto)
        => new Person()
        {
            IdCard = dto.IdCard,
            Email = dto.Email,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            PersonType = dto.PersonType,
            PhoneNumber = dto.PhoneNumber
        };
}
