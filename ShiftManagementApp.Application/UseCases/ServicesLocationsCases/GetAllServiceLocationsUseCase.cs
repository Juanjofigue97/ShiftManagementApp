using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ServicesLocationsCases;

public class GetAllServiceLocationsUseCase
{
    private readonly IServiceLocationRepository _serviceLocationRepository;

    public GetAllServiceLocationsUseCase(IServiceLocationRepository serviceLocationRepository)
    {
        _serviceLocationRepository = serviceLocationRepository;
    }

    public async Task<IEnumerable<ServiceLocation>> ExecuteAsync()
    {
        return await _serviceLocationRepository.GetAllServiceLocationsAsync();
    }
}

