using ShiftManagementApp.Application.Dtos.RequestDTO;
using ShiftManagementApp.Application;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Infrastructure.Mappers;

public class ShiftControlMapper : IMapper<ShiftControlRequestDTO, ShiftControl>
{
    public ShiftControl ToEntity(ShiftControlRequestDTO dto)
    => new ShiftControl()
    {
        Id = dto.Id,
        PersonID = dto.PersonID,
        ServiceID = dto.ServiceID,
        ServiceLocationID = dto.ServiceLocationID,
        StartTime = dto.StartTime,
        EndTime = dto.EndTime,
        Status = dto.Status,
    };
}
