using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Library.Entities;

using System.ComponentModel.DataAnnotations;

public class Service
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre del servicio es obligatorio.")]
    [MaxLength(100, ErrorMessage = "El nombre del servicio no puede tener más de 100 caracteres.")]
    public string? ServiceName { get; set; }

    [MaxLength(500, ErrorMessage = "La descripción no puede tener más de 500 caracteres.")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "La duración del servicio es obligatoria.")]
    [Range(1, int.MaxValue, ErrorMessage = "La duración del servicio debe ser mayor a 0.")]
    public int ServiceDuration { get; set; }

    [Required(ErrorMessage = "El estado de validez es obligatorio.")]
    public bool IsValid { get; set; } = true; 
}

