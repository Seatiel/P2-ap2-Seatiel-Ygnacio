using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class EmpleadosBLL
    {
        public static bool Guardar(Entidades.Empleados empleado)
        {
            using (var db = new Parcial2Ap2Db())
            {
                try
                {
                    db.Empleado.Add(empleado);
                    foreach (var er in empleado.Retencion)
                    {
                        db.Entry(er).State = System.Data.Entity.EntityState.Unchanged;
                    }
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
                return false;
            }
        }

        public static bool Mofidicar(Entidades.Empleados existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Empleados>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }

        public static bool Eliminar(Entidades.Empleados existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Entidades.Empleados>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }

        public static Entidades.Empleados Buscar(Expression<Func<Entidades.Empleados, bool>> tipo)
        {
            Entidades.Empleados Result = null;
            using (var repoitorio = new Repositorio<Entidades.Empleados>())
            {
                Result = repoitorio.Buscar(tipo);
                if (Result != null)
                {
                    Result.Retencion.Count();
                    Result.Detalle.Count();
                }
            }

            return Result;
        }

        public static List<Entidades.Empleados> Lista(Expression<Func<Entidades.Empleados, bool>> busqueda)
        {
            List<Entidades.Empleados> Result = null;
            using (var db = new Repositorio<Entidades.Empleados>())
            {
                try
                {
                    Result = db.Lista(busqueda); //EntitySet.Where(busqueda).ToList();
                }
                catch
                {

                }
                return Result;
            }
        }

        public static List<Entidades.Empleados> ListarTodo()
        {
            List<Entidades.Empleados> listar = null;

            using (var db = new Repositorio<Entidades.Empleados>())
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
