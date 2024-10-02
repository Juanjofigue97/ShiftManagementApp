using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Library.Entities;

public class ServiceLocation
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre de la ubicación es obligatorio.")]
    [MaxLength(200, ErrorMessage = "El nombre de la ubicación no puede tener más de 200 caracteres.")]
    public string? LocationName { get; set; }

    [Required(ErrorMessage = "El ID del servicio es obligatorio.")]
    [ForeignKey("Service")]
    public int ServiceID { get; set; }

    [Required(ErrorMessage = "El estado es obligatorio.")]
    [Range(0, 1, ErrorMessage = "El estado debe ser 0 (inactivo) o 1 (activo).")]
    public int Status { get; set; }

    public Service? Service { get; set; }  // Relación con la entidad Service
}