using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P2_ap2_Seatiel_Ygnacio.UI.Registros
{
    public partial class rEmpleados : Form
    {
        public rEmpleados()
        {
            InitializeComponent();
        }

        private Empleados LlenarClase()
        {
            var empleado = new Empleados();
            empleado.Nombres = NombrestextBox.Text;
            empleado.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            empleado.Sueldo = Utilidades.ToInt(SueldotextBox.Text);
            return empleado;
        }

        public void Limpiar()
        {
            EmpleadoIdtextBox.Clear();
            NombrestextBox.Clear();
            FechaNacimientodateTimePicker.Value = DateTime.Today;
            SueldotextBox.Clear();
        }

        public bool Validar()
        {
            bool retorno = true;
            if ((string.IsNullOrEmpty(NombrestextBox.Text)) || (string.IsNullOrEmpty(SueldotextBox.Text)))
            {
                NombreerrorProvider.SetError(NombrestextBox, "Debe de ingresar el Nombre.");
                SueldoerrorProvider.SetError(SueldotextBox, "Debe de ingresar el Sueldo.");
                retorno = false;
            }
            return retorno;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Empleados empleado = null;
            empleado = LlenarClase();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los campos");
            }
            else if (empleado != null)
            {
                BLL.EmpleadosBLL.Guardar(empleado);
                MessageBox.Show("Empleado guardado!");
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(EmpleadoIdtextBox.Text);
            Empleados empleado = BLL.EmpleadosBLL.Buscar(em => em.EmpleadoId == id);
            if (!string.IsNullOrEmpty(EmpleadoIdtextBox.Text))
            {

                if (BLL.EmpleadosBLL.Eliminar(empleado))
                {
                    MessageBox.Show("Empleado Eliminado!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Empleado no existe!");
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(EmpleadoIdtextBox.Text);
            Empleados empleado = BLL.EmpleadosBLL.Buscar(em => em.EmpleadoId == id);
            if (!string.IsNullOrEmpty(EmpleadoIdtextBox.Text))
            {                
                if (empleado != null)
                {
                    NombrestextBox.Text = empleado.Nombres;
                    FechaNacimientodateTimePicker.Value = empleado.FechaNacimiento;
                    SueldotextBox.Text = empleado.Sueldo.ToString();
                }
                else
                {
                    MessageBox.Show("El Empleado no ha sido creado");
                }
            }
        }

    }
}
