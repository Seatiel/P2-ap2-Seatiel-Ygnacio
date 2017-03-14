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
        Empleados Empleado;
        EmpleadosEmails Detalle;

        public rEmpleados()
        {
            InitializeComponent();
            Limpiar();
        }

        private void rEmpleados_Load(object sender, EventArgs e)
        {
            LlenarComboRetenciones();
            LlenarComboTiposEmails();
        }

        private Empleados LlenarClase()
        {
            var empleado = new Empleados();
            empleado.Nombres = NombrestextBox.Text;
            empleado.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            empleado.Sueldo = Utilidades.ToInt(SueldotextBox.Text);
            empleado.RetencionId = (int)RetencionescomboBox.SelectedValue;
            return empleado;
        }

        public void Limpiar()
        {
            Empleado = new Empleados();
            Detalle = new EmpleadosEmails();

            EmpleadoIdtextBox.Clear();
            NombrestextBox.Clear();
            FechaNacimientodateTimePicker.Value = DateTime.Today;
            SueldotextBox.Clear();
            EmailtextBox.Clear();
            EmpleadosRetencionesdataGridView.DataSource = null;
            EmpleadosEmailsdataGridView.DataSource = null;
        }

        private void LlenarComboRetenciones()
        {
            List<Entidades.Retenciones> lista = BLL.RetencionesBLL.ListarTodo();

            RetencionescomboBox.DataSource = lista;
            RetencionescomboBox.DisplayMember = "Descripcion";
            RetencionescomboBox.ValueMember = "RetencionId";

            /*if (RetencionescomboBox.Items.Count >= 1)
                RetencionescomboBox.SelectedIndex = -1;*/
        }

        private void LlenarComboTiposEmails()
        {
            List<TiposEmails> lista = BLL.TiposEmailBLL.ListarTodo();
            TiposcomboBox.DataSource = lista;
            TiposcomboBox.DisplayMember = "Descripcion";
            TiposcomboBox.ValueMember = "TipoId";
        }

        private void LLenarGridEmpleadosRetenciones(Empleados empleado)
        {
            EmpleadosRetencionesdataGridView.DataSource = null;
            EmpleadosRetencionesdataGridView.DataSource = empleado.Retencion;
        }

        private void LlenarGridEmpleadosEmails(Empleados empleado)
        {
            EmpleadosEmailsdataGridView.DataSource = null;
            EmpleadosEmailsdataGridView.DataSource = empleado.Detalle.ToList();

            this.EmpleadosEmailsdataGridView.Columns["EmpleadoEmailId"].Visible = false;
            this.EmpleadosEmailsdataGridView.Columns["EmpleadoId"].Visible = false;
            this.EmpleadosEmailsdataGridView.Columns["Empleado"].Visible = false;
            this.EmpleadosEmailsdataGridView.Columns["TipoEmail"].Visible = false;
        }

        public bool Validar()
        {
            bool retorno = true;
            if ((string.IsNullOrEmpty(NombrestextBox.Text)) || (string.IsNullOrEmpty(SueldotextBox.Text)) || (string.IsNullOrEmpty(EmailtextBox.Text)) || (EmpleadosEmailsdataGridView.DataSource == null) || (EmpleadosRetencionesdataGridView.DataSource == null))
            {
                ValidarerrorProvider.SetError(NombrestextBox, "Debe de ingresar el Nombre.");
                ValidarerrorProvider.SetError(SueldotextBox, "Debe de ingresar el Sueldo.");
                ValidarerrorProvider.SetError(EmailtextBox, "Debe de ingresar el Email.");
                ValidarerrorProvider.SetError(EmpleadosEmailsdataGridView, "Debe agregar los Datos.");
                ValidarerrorProvider.SetError(EmpleadosRetencionesdataGridView, "Debe agregar los Datos.");
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
                    LLenarGridEmpleadosRetenciones(empleado);
                    LlenarGridEmpleadosEmails(empleado);                    
                }
                else
                {
                    MessageBox.Show("El Empleado no ha sido creado");
                }
            }
        }

        private void AgregarRetencionbutton_Click(object sender, EventArgs e)
        {
            var retencion = new Retenciones();
            retencion = (Retenciones)RetencionescomboBox.SelectedItem;
            Empleado.Retencion.Add(retencion);
            LLenarGridEmpleadosRetenciones(Empleado);
        }

        private void AgregarEmailbutton_Click(object sender, EventArgs e)
        {
            Empleado.AgregarDetalle(Detalle.TipoEmail, EmailtextBox.Text);
            LlenarGridEmpleadosEmails(Empleado);
        }

        
    }
}
