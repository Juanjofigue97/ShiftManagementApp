using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ShiftControlCases;

public class GetAllShiftControlsUseCase
{
    private readonly IShiftControlRepository _shiftControlRepository;

    public GetAllShiftControlsUseCase(IShiftControlRepository shiftControlRepository)
    {
        _shiftControlRepository = shiftControlRepository;
    }

    public async Task<IEnumerable<ShiftControl>> ExecuteAsync()
    {
        return await _shiftControlRepository.GetAllShiftControlsAsync();
    }
}

