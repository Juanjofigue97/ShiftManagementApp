using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ServicesLocationsCases;

public class UpdateServiceLocationUseCase
{
    private readonly IServiceLocationRepository _serviceLocationRepository;

    public UpdateServiceLocationUseCase(IServiceLocationRepository serviceLocationRepository)
    {
        _serviceLocationRepository = serviceLocationRepository;
    }

    public async Task ExecuteAsync(ServiceLocation serviceLocation)
    {
        if (serviceLocation == null)
            throw new ArgumentNullException(nameof(serviceLocation));

        if (string.IsNullOrWhiteSpace(serviceLocation.LocationName))
            throw new ArgumentException("Location Name is required");

        await _serviceLocationRepository.UpdateServiceLocationAsync(serviceLocation);
    }
}
