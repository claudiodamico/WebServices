using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebServices.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; } 
        public string Nombre { get; set; }
        public int RolId { get; set; }

        // PROPIEDAD DE NAVEGACIÓN
        [ForeignKey("RolId")]
        public Rol Rol { get; set; }
    }
}

