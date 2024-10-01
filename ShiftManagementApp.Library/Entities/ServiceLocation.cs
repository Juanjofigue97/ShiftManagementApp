using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Library.Entities;

public class ServiceLocation
{
    public int Id { get; set; }
    public string? LocationName { get; set; }
    public int ServiceID { get; set; }
    public int Status { get; set; }
    public Service? Service { get; set; }
}
