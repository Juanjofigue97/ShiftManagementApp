using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Library.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ShiftControl
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El ID de la persona es obligatorio.")]
    [ForeignKey("Person")]
    public int PersonID { get; set; }

    [Required(ErrorMessage = "El ID del servicio es obligatorio.")]
    [ForeignKey("Service")]
    public int ServiceID { get; set; }

    [Required(ErrorMessage = "El ID de la ubicación del servicio es obligatorio.")]
    [ForeignKey("ServiceLocation")]
    public int ServiceLocationID { get; set; }

    [Required(ErrorMessage = "La hora de inicio es obligatoria.")]
    public DateTime StartTime { get; set; }

    [Required(ErrorMessage = "La hora de finalización es obligatoria.")]
    public DateTime EndTime { get; set; }

    [Required(ErrorMessage = "El estado es obligatorio.")]
    [Range(0, 2, ErrorMessage = "El estado debe ser 0 (inactivo) o 1 (activo).")]
    public int Status { get; set; }

    // Propiedades de navegación
    public Person? Person { get; set; }
    public Service? Service { get; set; }
    public ServiceLocation? ServiceLocation { get; set; }
}
