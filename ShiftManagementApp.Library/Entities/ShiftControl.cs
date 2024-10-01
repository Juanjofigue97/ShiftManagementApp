using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Library.Entities;

public class ShiftControl
{
    public int Id { get; set; }
    public int PersonID { get; set; }
    public int ServiceID { get; set; }
    public int ServiceLocationID { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int Status { get; set; }

    // Navigation properties
    public Person? Person { get; set; }
    public Service? Service { get; set; }
    public ServiceLocation? ServiceLocation { get; set; }
}
