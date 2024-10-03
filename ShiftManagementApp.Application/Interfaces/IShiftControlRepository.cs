using ShiftManagementApp.Library.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.Interfaces;

public interface IShiftControlRepository
{
    Task<IEnumerable<ShiftControl>> GetAllShiftControlsAsync();
    Task <ShiftControl> GetShiftControlById(int id);
    Task<IEnumerable<ShiftControl>> GetShiftControlsByPerson(int personId);
    Task AddShiftControl(ShiftControl shiftControl);
    Task UpdateShiftControl(ShiftControl shiftControl);
    Task DeleteShiftControl(int id);
}
