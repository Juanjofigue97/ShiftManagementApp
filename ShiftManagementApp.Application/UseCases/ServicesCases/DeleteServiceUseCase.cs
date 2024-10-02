using ShiftManagementApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ServicesCases;

public class DeleteServiceUseCase
{
    private readonly IServiceRepository _serviceRepository;

    public DeleteServiceUseCase(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public async Task ExecuteAsync(int id)
    {
        if (id <= 0)
            throw new ArgumentException("Invalid service ID");

        await _serviceRepository.DeleteServiceAsync(id);
    }
}
