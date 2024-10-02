using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ServicesLocationsCases;

public class GetServiceLocationByIdUseCase
{
    private readonly IServiceLocationRepository _serviceLocationRepository;

    public GetServiceLocationByIdUseCase(IServiceLocationRepository serviceLocationRepository)
    {
        _serviceLocationRepository = serviceLocationRepository;
    }

    public async Task<ServiceLocation?> ExecuteAsync(int id)
    {
        return await _serviceLocationRepository.GetServiceLocationByIdAsync(id);
    }
}

