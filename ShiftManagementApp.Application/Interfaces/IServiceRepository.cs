using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.Interfaces;

public interface IServiceRepository
{
    Service GetServiceById(int id);
    IEnumerable<Service> GetAllServices();
    void AddService(Service service);
    void UpdateService(Service service);
    void DeleteService(int id);
}
