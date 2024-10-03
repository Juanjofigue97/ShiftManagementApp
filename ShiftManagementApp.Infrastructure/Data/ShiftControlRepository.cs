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

public class ShiftControlRepository : IShiftControlRepository
{
    private readonly ShiftManagementDbContext _dbContext;

    public ShiftControlRepository(ShiftManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // Obtener todos los ShiftControl
    public async Task<IEnumerable<ShiftControl>> GetAllShiftControlsAsync()
    {
        return await _dbContext.ShiftControls.ToListAsync();
    }

    // Obtener ShiftControl por ID
    public async Task<ShiftControl> GetShiftControlById(int id)
    {
        return await _dbContext.ShiftControls
            .FindAsync(id);
    }

    // Obtener ShiftControl por persona
    public async Task<IEnumerable<ShiftControl>> GetShiftControlsByPerson(int personId)
    {
        return await _dbContext.ShiftControls
            .Where(sc => sc.PersonID == personId).ToListAsync();
    }

    // Agregar un nuevo ShiftControl
    public async Task AddShiftControl(ShiftControl shiftControl)
    {
        await _dbContext.ShiftControls.AddAsync(shiftControl);
        await _dbContext.SaveChangesAsync();
    }

    // Actualizar ShiftControl existente
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

