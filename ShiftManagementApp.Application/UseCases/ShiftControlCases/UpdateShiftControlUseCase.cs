using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ShiftControlCases;

public class UpdateShiftControlUseCase<TDTO>
{
    private readonly IShiftControlRepository _shiftControlRepository;
    private readonly IMapper<TDTO, ShiftControl> _mapper;

    public UpdateShiftControlUseCase(IShiftControlRepository shiftControlRepository, IMapper<TDTO, ShiftControl> mapper)
    {
        _shiftControlRepository = shiftControlRepository;
        _mapper = mapper;
    }

    public async Task ExecuteAsync(int id, TDTO shiftControlDTO)
    {
        var existingShiftControl = await _shiftControlRepository.GetShiftControlById(id);
        if (existingShiftControl == null)
            throw new KeyNotFoundException($"ShiftControl with ID {id} was not found");

        var updatedShiftControl = _mapper.ToEntity(shiftControlDTO);
        updatedShiftControl.Id = id; // Make sure the ID stays the same.

        await _shiftControlRepository.UpdateShiftControl(updatedShiftControl);
    }
}

