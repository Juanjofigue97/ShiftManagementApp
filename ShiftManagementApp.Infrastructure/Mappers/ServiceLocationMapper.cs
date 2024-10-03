using ShiftManagementApp.Application.Dtos.RequestDTO;
using ShiftManagementApp.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShiftManagementApp.Library.Entities;

namespace ShiftManagementApp.Infrastructure.Mappers;

public class ServiceLocationMapper : IMapper<ServiceLocationRequestDTO, ServiceLocation>
{
    public ServiceLocation ToEntity(ServiceLocationRequestDTO dto)
     => new ServiceLocation()
     {
         Id = dto.Id,
         LocationName = dto.LocationName,
         ServiceID = dto.ServiceID,
         Status = dto.Status,
     };
}
