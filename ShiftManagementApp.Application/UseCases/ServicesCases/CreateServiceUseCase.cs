using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;

namespace ShiftManagementApp.Application.UseCases.ServicesCases;

public class CreateServiceUseCase
{
    private readonly IServiceRepository _serviceRepository;

    public CreateServiceUseCase(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public async Task ExecuteAsync(Service service)
    {
        if (service == null)
            throw new ArgumentNullException(nameof(service));

        if (string.IsNullOrWhiteSpace(service.ServiceName))
            throw new ArgumentException("Service Name is required");

        await _serviceRepository.AddServiceAsync(service);
    }
}
