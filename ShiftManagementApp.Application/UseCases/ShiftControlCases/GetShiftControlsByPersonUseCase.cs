using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ShiftControlCases;

public class GetShiftControlsByPersonUseCase
{
    private readonly IShiftControlRepository _shiftControlRepository;

    public GetShiftControlsByPersonUseCase(IShiftControlRepository shiftControlRepository)
    {
        _shiftControlRepository = shiftControlRepository;
    }

    public async Task<IEnumerable<ShiftControl>> ExecuteAsync(int personId)
    {
        if (personId <= 0)
            throw new ArgumentException("Person ID must be greater than 0", nameof(personId));

        var shiftControls = await _shiftControlRepository.GetShiftControlsByPerson(personId);
        if (!shiftControls.Any())
            throw new KeyNotFoundException($"No ShiftControls found for person ID {personId}");

        return shiftControls;
    }
}
