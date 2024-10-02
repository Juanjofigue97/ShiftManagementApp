using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ServicesCases;

public class GetServiceByIdUseCase
{
    private readonly IServiceRepository _serviceRepository;

    public GetServiceByIdUseCase(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public async Task<Service> ExecuteAsync(int id)
    {
        if (id <= 0)
            throw new ArgumentException("Invalid service ID");

        return await _serviceRepository.GetServiceByIdAsync(id);
    }
}

