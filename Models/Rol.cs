using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WebServices.Models
{
    public class Rol
    {
        public Rol()
        {
            Empleado = new HashSet<Empleado>();
        }
        public int RolId { get; set; }
        public string Descripcion { get; set; }

        // PROPIEDAD DE NAVEGACIÓN
        public ICollection<Empleado> Empleado { get; set; }
    }
}
