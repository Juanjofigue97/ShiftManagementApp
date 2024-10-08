﻿using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Application.Dtos.RequestDTO;

public class ServiceLocationRequestDTO
{
    public int Id { get; set; }
    public string? LocationName { get; set; }
    public int ServiceID { get; set; }
    public int Status { get; set; }
}
