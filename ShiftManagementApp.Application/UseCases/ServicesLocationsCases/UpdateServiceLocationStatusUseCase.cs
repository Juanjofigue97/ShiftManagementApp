using ShiftManagementApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.UseCases.ServicesLocationsCases;

public class UpdateServiceLocationStatusUseCase
{
    private readonly IServiceLocationRepository _serviceLocationRepository;
    private readonly IShiftControlRepository _shiftControlRepository;

    public UpdateServiceLocationStatusUseCase(IServiceLocationRepository serviceLocationRepository, IShiftControlRepository shiftControlRepository)
    {
        _serviceLocationRepository = serviceLocationRepository;
        _shiftControlRepository = shiftControlRepository;
        _dbContext = dbContext;
    }

    public async Task<bool> ExecuteAsync(int serviceLocationId, int shiftControlId, bool isAttended)
    {
        // Iniciar la transacción
            try
            {
                var serviceLocation = await _serviceLocationRepository.GetServiceLocationByIdAsync(serviceLocationId);
                if (serviceLocation == null)
                    throw new Exception("Service location not found");

                serviceLocation.Status = isAttended ? 1 : 0;
                var serviceLocationUpdateSuccess = await _serviceLocationRepository.UpdateServiceStatusLocationAsync(serviceLocation);
                
                if (!serviceLocationUpdateSuccess)
                    throw new Exception("Failed to update ServiceLocation status.");

                // Validar que el shiftControlId exista
                var shiftControl = await _shiftControlRepository.GetShiftByIdAsync(shiftControlId);
                if (shiftControl == null)
                    throw new Exception("Shift control not found");

                // Actualizar el estado de ShiftControl
                shiftControl.Status = isAttended ? "Attended" : "Canceled";
                var shiftControlUpdateSuccess = await _shiftControlRepository.UpdateShiftControlAsync(shiftControl);

                if (!shiftControlUpdateSuccess)
                    throw new Exception("Failed to update ShiftControl status.");

                // Guardar todos los cambios
                await _dbContext.SaveChangesAsync();

                // Confirmar la transacción
                await transaction.CommitAsync();

                return true;
            }
            catch
            {
                // Si algo falla, deshacer los cambios
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}
