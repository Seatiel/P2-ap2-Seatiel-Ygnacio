using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class TiposEmailBLL
    {
        public static Entidades.TiposEmail Guardar(Entidades.TiposEmail nuevo)
        {
            Entidades.TiposEmail creado = null;
            using (var repositorio = new Repositorio<Entidades.TiposEmail>())
            {
                creado = repositorio.Guardar(nuevo);
            }

            return creado;

        }


        public static bool Mofidicar(Entidades.TiposEmail existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.TiposEmail>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }

        public static bool Eliminar(Entidades.TiposEmail existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.TiposEmail>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static Entidades.TiposEmail Buscar(Expression<Func<Entidades.TiposEmail, bool>> tipo)
        {
            Entidades.TiposEmail Result = null;
            using (var repoitorio = new Repositorio<Entidades.TiposEmail>())
            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }

        public static List<Entidades.TiposEmail> Lista(Expression<Func<Entidades.TiposEmail, bool>> busqueda)
        {
            List<Entidades.TiposEmail> Result = null;
            using (var db = new Repositorio<Entidades.TiposEmail>())
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
