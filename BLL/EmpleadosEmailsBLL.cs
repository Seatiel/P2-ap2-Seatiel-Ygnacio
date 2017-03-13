using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class EmpleadosEmailsBLL
    {
        public static Entidades.EmpleadosEmails Guardar(Entidades.EmpleadosEmails nuevo)
        {
            Entidades.EmpleadosEmails creado = null;
            using (var repositorio = new Repositorio<Entidades.EmpleadosEmails>())
            {
                creado = repositorio.Guardar(nuevo);
            }

            return creado;

        }


        public static bool Mofidicar(Entidades.EmpleadosEmails existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.EmpleadosEmails>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }

        public static bool Eliminar(Entidades.EmpleadosEmails existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.EmpleadosEmails>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static Entidades.EmpleadosEmails Buscar(Expression<Func<Entidades.EmpleadosEmails, bool>> tipo)
        {
            Entidades.EmpleadosEmails Result = null;
            using (var repoitorio = new Repositorio<Entidades.EmpleadosEmails>())
            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }

        public static List<Entidades.EmpleadosEmails> Lista(Expression<Func<Entidades.EmpleadosEmails, bool>> busqueda)
        {
            List<Entidades.EmpleadosEmails> Result = null;
            using (var db = new Repositorio<Entidades.EmpleadosEmails>())
            {
                try
                {
                    Result = db.Lista(busqueda).ToList(); //EntitySet.Where(busqueda).ToList();
                }
                catch
                {

                }
                return Result;
            }
        }
    }
}
