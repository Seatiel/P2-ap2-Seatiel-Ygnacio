using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class TiposEmailBLL
    {
        public static bool Guardar(TiposEmails nuevo)
        {
            using (var db = new Repositorio<TiposEmails>())
            {
                try
                {
                    return db.Guardar(nuevo);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }


        public static bool Mofidicar(Entidades.TiposEmails existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.TiposEmails>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }

        public static bool Eliminar(Entidades.TiposEmails existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.TiposEmails>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static Entidades.TiposEmails Buscar(Expression<Func<Entidades.TiposEmails, bool>> tipo)
        {
            Entidades.TiposEmails Result = null;
            using (var repoitorio = new Repositorio<Entidades.TiposEmails>())
            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }

        public static List<Entidades.TiposEmails> Lista(Expression<Func<Entidades.TiposEmails, bool>> busqueda)
        {
            List<Entidades.TiposEmails> Result = null;
            using (var db = new Repositorio<Entidades.TiposEmails>())
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

        public static List<Entidades.TiposEmails> ListarTodo()
        {
            List<Entidades.TiposEmails> listar = null;

            using (var db = new Repositorio<Entidades.TiposEmails>())
            {
                try
                {
                    listar = db.ListarTodo();
                }
                catch
                {

                }
            }
            return listar;
        }
    }
}
