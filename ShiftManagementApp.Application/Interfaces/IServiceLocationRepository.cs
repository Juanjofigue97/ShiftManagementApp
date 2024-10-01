using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.Interfaces;

internal interface IServiceLocationRepository
{
    ServiceLocation GetLocationById(int id);
    IEnumerable<ServiceLocation> GetAllLocations();
    void AddLocation(ServiceLocation location);
    void UpdateLocation(ServiceLocation location);
    void DeleteLocation(int id);
}
