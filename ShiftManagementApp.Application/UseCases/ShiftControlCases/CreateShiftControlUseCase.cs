using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ShiftControlCases;

public class CreateShiftControlUseCase<TDTO>
{
    private readonly IShiftControlRepository _ShiftControlRepository;
    private readonly IMapper<TDTO, ShiftControl> _mapper;


    public CreateShiftControlUseCase(IShiftControlRepository shiftControlRepository, IMapper<TDTO, ShiftControl> mapper)
    {
        _ShiftControlRepository = shiftControlRepository;
        _mapper = mapper;
    }

    public async Task ExecuteAsync(TDTO ShiftControlDTO)
    {
        var shiftControl = _mapper.ToEntity(ShiftControlDTO);
        if (shiftControl == null)
            throw new ArgumentNullException(nameof(shiftControl));

        if (shiftControl.PersonID == 0)
            throw new ArgumentException("Person is Required");

        await _ShiftControlRepository.AddShiftControl(shiftControl);
    }
}
