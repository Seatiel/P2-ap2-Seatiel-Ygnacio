using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Parcial2Ap2Db : DbContext  
    {
        public Parcial2Ap2Db() : base ("ConStr")
        {

        }

        public DbSet<Entidades.Retenciones> Retencion { get; set; }
        public DbSet<Entidades.TiposEmails> TipoEmail { get; set; }
        public DbSet<Entidades.Empleados> Empleado { get; set; }
        public DbSet<Entidades.EmpleadosRetenciones> EmpleadoDescuento { get; set; }
        public DbSet<Entidades.EmpleadosEmails> EmpleadoEmail { get; set; }

    }
}
