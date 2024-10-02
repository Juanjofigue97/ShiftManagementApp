using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ServicesCases;

public class UpdateServiceUseCase
{
    private readonly IServiceRepository _serviceRepository;

    public UpdateServiceUseCase(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public async Task ExecuteAsync(Service service)
    {
        if (service == null)
            throw new ArgumentNullException(nameof(service));

        if (string.IsNullOrWhiteSpace(service.ServiceName))
            throw new ArgumentException("Service Name is required");

        await _serviceRepository.UpdateServiceAsync(service);
    }
}


