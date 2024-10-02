using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;

namespace ShiftManagementApp.Application.UseCases.ServicesCases;

public class GetAllServicesUseCase
{
    private readonly IServiceRepository _serviceRepository;

    public GetAllServicesUseCase(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public async Task<IEnumerable<Service>> ExecuteAsync()
    {
        return await _serviceRepository.GetAllServicesAsync();
    }
}

