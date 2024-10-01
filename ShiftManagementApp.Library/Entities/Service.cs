using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Library.Entities;

public class Service
{
    public int Id { get; set; }
    public string? ServiceName { get; set; }
    public string? Description { get; set; }
    public int ServiceDuration { get; set; }
}
