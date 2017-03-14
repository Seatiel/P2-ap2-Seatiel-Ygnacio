using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class RetencionesBLL
    {
        public static bool Guardar(Entidades.Retenciones retencion)
        {
            using (var db = new Repositorio<Entidades.Retenciones>())
            {
                try
                {
                    return db.Guardar(retencion);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }


        public static bool Mofidicar(Entidades.Retenciones existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Retenciones>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }

        public static bool Eliminar(Entidades.Retenciones existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Retenciones>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static Entidades.Retenciones Buscar(Expression<Func<Entidades.Retenciones, bool>> tipo)
        {
            Entidades.Retenciones Result = null;
            using (var repoitorio = new Repositorio<Entidades.Retenciones>())
            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }

        public static List<Entidades.Retenciones> Lista(Expression<Func<Entidades.Retenciones, bool>> busqueda)
        {
            List<Entidades.Retenciones> Result = null;
            using (var db = new Repositorio<Entidades.Retenciones>())
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

        public static List<Entidades.Retenciones> ListarTodo()
        {
            List<Entidades.Retenciones> listar = null;

            using (var db = new Repositorio<Entidades.Retenciones>())
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
