using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.Interfaces;

public interface IServiceRepository
{
    Task<Service> GetServiceByIdAsync(int id);               
    Task<IEnumerable<Service>> GetAllServicesAsync();        
    Task AddServiceAsync(Service service);                   
    Task UpdateServiceAsync(Service service);                
    Task DeleteServiceAsync(int id);                        
}

