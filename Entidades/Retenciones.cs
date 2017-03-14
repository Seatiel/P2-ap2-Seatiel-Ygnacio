using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Retenciones
    {
        [Key]
        public int RetencionId { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }

        public List<Empleados> Emplado { get; set; }

        //public virtual ICollection<EmpleadosRetenciones> Detalle { get; set; } //Muchos

        public Retenciones()
        {
            this.Emplado = new List<Empleados>();
        }       

    }
}
