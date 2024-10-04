using ShiftManagementApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ServicesLocationsCases;

public class UpdateServiceLocationStatusUseCase
{
    private readonly IServiceLocationRepository _serviceLocationRepository;

    public UpdateServiceLocationStatusUseCase(IServiceLocationRepository serviceLocationRepository)
    {
        _serviceLocationRepository = serviceLocationRepository;
    }

    public async Task<bool> ExecuteAsync(int serviceLocationId, bool isAttended)
    {
        // Validar que exista el serviceLocationId
        var serviceLocation = await _serviceLocationRepository.GetServiceLocationByIdAsync(serviceLocationId);
        if (serviceLocation == null)
            throw new Exception("Service location not found");

        serviceLocation.Status = isAttended ? 1 : 0; 
        return await _serviceLocationRepository.UpdateServiceStatusLocationAsync(serviceLocation);
    }
}