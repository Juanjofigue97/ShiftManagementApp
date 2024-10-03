using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.Dtos.RequestDTO;

public class ShiftControlRequestDTO
{
    public int Id { get; set; }

    public int PersonID { get; set; }

    public int ServiceID { get; set; }

    public int ServiceLocationID { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int Status { get; set; }

}
