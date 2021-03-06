﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposEmails
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<EmpleadosEmails> Detalle { get; set; } //Muchos

        public TiposEmails()
        {
            this.Detalle = new HashSet<EmpleadosEmails>();
        }
    }
}
