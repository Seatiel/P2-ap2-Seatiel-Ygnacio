using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EmpleadosRetenciones
    {
        [Key]
        public int EmpleadoRetencionId { get; set; }
        public int EmpleadoId { get; set; }
        public int RetencionId { get; set; }

        


        
    }
}
