using ShiftManagementApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ShiftControlCases;

public class DeleteShiftControlUseCase
{
    private readonly IShiftControlRepository _shiftControlRepository;

    public DeleteShiftControlUseCase(IShiftControlRepository shiftControlRepository)
    {
        _shiftControlRepository = shiftControlRepository;
    }

    public async Task ExecuteAsync(int id)
    {
        var shiftControl = await _shiftControlRepository.GetShiftControlById(id);
        if (shiftControl == null)
            throw new KeyNotFoundException($"ShiftControl with ID {id} was not found");

        await _shiftControlRepository.DeleteShiftControl(id);
    }
}

