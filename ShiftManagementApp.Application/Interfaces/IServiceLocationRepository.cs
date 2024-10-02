using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.Interfaces;

public interface IServiceLocationRepository
{
    Task<ServiceLocation> GetServiceLocationByIdAsync(int id);
    Task<IEnumerable<ServiceLocation>> GetAllServiceLocationsAsync();
    Task AddServiceLocationAsync(ServiceLocation serviceLocation);
    Task UpdateServiceLocationAsync(ServiceLocation serviceLocation);
    Task DeleteServiceLocationAsync(int id);
}