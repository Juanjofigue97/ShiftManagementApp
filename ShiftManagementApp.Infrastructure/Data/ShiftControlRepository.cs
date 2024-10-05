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

public class ShiftControlRepository : ,IShiftControlRepository
{
    private readonly ShiftManagementDbContext _dbContext;

    public ShiftControlRepository(ShiftManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<ShiftControl>> GetAllShiftControlsAsync()
    {
        return await _dbContext.ShiftControls
            .Include(s => s.Service)
            .Include(p => p.Person)
            .Include(sl => sl.ServiceLocation)
            .ToListAsync();
    }

    // Obtener ShiftControl por ID
    public async Task<ShiftControl> GetShiftControlById(int id)
    {
        return await _dbContext.ShiftControls
            .FindAsync(id);
    }
    public async Task<IEnumerable<ShiftControl>> GetShiftControlsByPerson(int personId)
    {
        return await _dbContext.ShiftControls
            .Where(sc => sc.PersonID == personId).ToListAsync();
    }
    public async Task AddShiftControl(ShiftControl shiftControl)
    {
        await _dbContext.ShiftControls.AddAsync(shiftControl);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateShiftControl(ShiftControl shiftControl)
    {
        _dbContext.ShiftControls.Update(shiftControl);
        await _dbContext.SaveChangesAsync();
    }

    // Eliminar ShiftControl por ID
    public async Task DeleteShiftControl(int id)
    {
        var shiftControl = await _dbContext.ShiftControls.FindAsync(id);
        if (shiftControl != null)
        {
            _dbContext.ShiftControls.Remove(shiftControl);
            await _dbContext.SaveChangesAsync();
        }
    }
}

