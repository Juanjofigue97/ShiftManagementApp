using Microsoft.EntityFrameworkCore;
using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Infrastructure.Context;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Infrastructure.Data;

public class ServiceLocationRepository : IServiceLocationRepository
{
    private readonly ShiftManagementDbContext _dbContext;

    public ServiceLocationRepository(ShiftManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ServiceLocation> GetServiceLocationByIdAsync(int id)
    {
        return await _dbContext.ServiceLocations.FindAsync(id);
    }

    public async Task<IEnumerable<ServiceLocation>> GetAllServiceLocationsAsync()
    {
        return await _dbContext.ServiceLocations
                    .Include(s => s.Service)
                    .ToListAsync();
    }

    public async Task AddServiceLocationAsync(ServiceLocation serviceLocation)
    {
        await _dbContext.ServiceLocations.AddAsync(serviceLocation);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateServiceLocationAsync(ServiceLocation serviceLocation)
    {
        _dbContext.ServiceLocations.Update(serviceLocation);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteServiceLocationAsync(int id)
    {
        var serviceLocation = await _dbContext.ServiceLocations.FindAsync(id);
        if (serviceLocation != null)
        {
            _dbContext.ServiceLocations.Remove(serviceLocation);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<bool> UpdateServiceStatusLocationAsync(ServiceLocation serviceLocation)
    {
        _dbContext.ServiceLocations.Update(serviceLocation);
        return await _dbContext.SaveChangesAsync() > 0;
    }
}

