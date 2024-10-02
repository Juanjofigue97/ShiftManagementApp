using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

public class Person
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "La cédula es un campo obligatorio.")]
    [Range(1, int.MaxValue, ErrorMessage = "El valor del IdCard debe ser mayor a 0.")]
    public int IdCard { get; set; }

    [Required(ErrorMessage = "El nombre es un campo obligatorio.")]
    [MaxLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "El apellido es un campo obligatorio.")]
    [MaxLength(100, ErrorMessage = "El apellido no puede tener más de 100 caracteres.")]
    public string? LastName { get; set; }

    [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
    public string? Email { get; set; }

    [Phone(ErrorMessage = "El número de teléfono no es válido.")]
    public string? PhoneNumber { get; set; }

    [Required(ErrorMessage = "El tipo de persona es obligatorio.")]
    [Range(1, int.MaxValue, ErrorMessage = "El valor del tipo de persona debe ser mayor a 0.")]
    public int PersonType { get; set; }
}
