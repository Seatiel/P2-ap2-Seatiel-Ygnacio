using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EmpleadosEmails
    {
        [Key]
        public int EmpleadoEmailId { get; set; }
        public int EmpleadoId { get; set; }
        public int TipoId { get; set; }
        public string Email { get; set; }

        public virtual TiposEmails TipoEmail { get; set; } //Uno

        public virtual Empleados Empleado { get; set; }

        public EmpleadosEmails()
        {
            this.TipoEmail = new TiposEmails();
        }

        public EmpleadosEmails(int tipoId, string email)
        {
            this.TipoId = tipoId;
            this.Email = email;
        }

    }
}
