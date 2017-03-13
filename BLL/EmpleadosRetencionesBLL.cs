using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class EmpleadosRetencionesBLL
    {
        public static Entidades.EmpleadosRetenciones Guardar(Entidades.EmpleadosRetenciones nuevo)
        {
            Entidades.EmpleadosRetenciones creado = null;
            using (var repositorio = new Repositorio<Entidades.EmpleadosRetenciones>())
            {
                creado = repositorio.Guardar(nuevo);
            }

            return creado;

        }


        public static bool Mofidicar(Entidades.EmpleadosRetenciones existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.EmpleadosRetenciones>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }

        public static bool Eliminar(Entidades.EmpleadosRetenciones existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.EmpleadosRetenciones>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static Entidades.EmpleadosRetenciones Buscar(Expression<Func<Entidades.EmpleadosRetenciones, bool>> tipo)
        {
            Entidades.EmpleadosRetenciones Result = null;
            using (var repoitorio = new Repositorio<Entidades.EmpleadosRetenciones>())
            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }

        public static List<Entidades.EmpleadosRetenciones> Lista(Expression<Func<Entidades.EmpleadosRetenciones, bool>> busqueda)
        {
            List<Entidades.EmpleadosRetenciones> Result = null;
            using (var db = new Repositorio<Entidades.EmpleadosRetenciones>())
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
