using Microsoft.EntityFrameworkCore;
using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Infrastructure.Context;
using ShiftManagementApp.Library.Entities;

namespace ShiftManagementApp.Infrastructure.Data;

public class ServiceRepository : IServiceRepository
{
    private readonly ShiftManagementDbContext _dbContext;

    public ServiceRepository(ShiftManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Service> GetServiceByIdAsync(int id)
    {
        return await _dbContext.Services.FindAsync(id);
    }

    public async Task<IEnumerable<Service>> GetAllServicesAsync()
    {
        return await _dbContext.Services.ToListAsync();
    }

    public async Task AddServiceAsync(Service service)
    {
        await _dbContext.Services.AddAsync(service);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateServiceAsync(Service service)
    {
        _dbContext.Services.Update(service);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteServiceAsync(int id)
    {
        var service = await _dbContext.Services.FindAsync(id);
        if (service != null)
        {
            _dbContext.Services.Remove(service);
            await _dbContext.SaveChangesAsync();
        }
    }
}

