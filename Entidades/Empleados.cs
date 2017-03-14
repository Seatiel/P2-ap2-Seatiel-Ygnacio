using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Sueldo { get; set; }
        public int RetencionId { get; set; }

        public List<Retenciones> Retencion { get; set; }

        public virtual ICollection<EmpleadosEmails> Detalle { get; set; }
        
        public Empleados()
        {
            this.Retencion = new List<Retenciones>();

            this.Detalle = new HashSet<EmpleadosEmails>();
        }

        public void AgregarDetalle(TiposEmails tipoEmail, string descripcion)
        {
            this.Detalle.Add(new EmpleadosEmails(tipoEmail.TipoId, descripcion));
        }

    }
}
