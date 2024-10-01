using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.Interfaces;

public interface IShiftControlRepository
{
    ShiftControl GetShiftControlById(int id);
    IEnumerable<ShiftControl> GetShiftControlsByPerson(int personId);
    void AddShiftControl(ShiftControl shiftControl);
    void UpdateShiftControl(ShiftControl shiftControl);
    void DeleteShiftControl(int id);
}
