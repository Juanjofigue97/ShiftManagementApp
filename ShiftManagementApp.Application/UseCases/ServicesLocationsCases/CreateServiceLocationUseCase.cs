using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ServicesLocationsCases;

public class CreateServiceLocationUseCase<TDTO>
{
    private readonly IServiceLocationRepository _serviceLocationRepository;
    private readonly IMapper<TDTO, ServiceLocation> _mapper;


    public CreateServiceLocationUseCase(IServiceLocationRepository serviceLocationRepository, IMapper<TDTO, ServiceLocation> mapper)
    {
        _serviceLocationRepository = serviceLocationRepository;
        _mapper = mapper;
    }

    public async Task ExecuteAsync(TDTO serviceLocationDTO)
    {
        var serviceLocation = _mapper.ToEntity(serviceLocationDTO);
        if (serviceLocation == null)
            throw new ArgumentNullException(nameof(serviceLocation));

        if (string.IsNullOrWhiteSpace(serviceLocation.LocationName))
            throw new ArgumentException("Location Name is required");

        await _serviceLocationRepository.AddServiceLocationAsync(serviceLocation);
    }
}
