using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;

namespace ShiftManagementApp.Application.UseCases.ShiftControlCases;

public class GetShiftControlByIdUseCase
{
    private readonly IShiftControlRepository _shiftControlRepository;

    public GetShiftControlByIdUseCase(IShiftControlRepository shiftControlRepository)
    {
        _shiftControlRepository = shiftControlRepository;
    }

    public async Task<ShiftControl> ExecuteAsync(int id)
    {
        if (id <= 0)
            throw new ArgumentException("ID must be greater than 0", nameof(id));

        var shiftControl = await _shiftControlRepository.GetShiftControlById(id);
        if (shiftControl == null)
            throw new KeyNotFoundException($"ShiftControl with ID {id} was not found");

        return shiftControl;
    }
}
