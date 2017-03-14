using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class EmpleadosRetencionesBLL
    {
        public static bool Guardar(Entidades.EmpleadosRetenciones detalle)
        {
            using (var db = new Repositorio<Entidades.EmpleadosRetenciones>())
            {
                try
                {
                    return db.Guardar(detalle);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Guardar(List<EmpleadosRetenciones> lista)
        {            
            try
            {
                foreach (var detalle in lista)
                {
                    Guardar(detalle);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
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

        
    }
}
