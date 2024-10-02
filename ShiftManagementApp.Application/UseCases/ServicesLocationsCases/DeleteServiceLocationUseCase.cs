using ShiftManagementApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ServicesLocationsCases;

public class DeleteServiceLocationUseCase
{
    private readonly IServiceLocationRepository _serviceLocationRepository;

    public DeleteServiceLocationUseCase(IServiceLocationRepository serviceLocationRepository)
    {
        _serviceLocationRepository = serviceLocationRepository;
    }

    public async Task ExecuteAsync(int id)
    {
        await _serviceLocationRepository.DeleteServiceLocationAsync(id);
    }
}

