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
    public partial class rRetenciones : Form
    {
        public rRetenciones()
        {
            InitializeComponent();
        }

        private Retenciones LlenarClase()
        {
            var retenciones = new Retenciones();
            retenciones.Descripcion = DescripciontextBox.Text;
            retenciones.Valor = Utilidades.ToInt(ValortextBox.Text);
            return retenciones;
        }

        public void Limpiar()
        {
            RetencionesIdtextBox.Clear();
            DescripciontextBox.Clear();            
            ValortextBox.Clear();
        }

        public bool Validar()
        {
            bool retorno = true;
            if ((string.IsNullOrEmpty(DescripciontextBox.Text)) || (string.IsNullOrEmpty(ValortextBox.Text)))
            {
                DescripcionerrorProvider.SetError(DescripciontextBox, "Debe de ingresar la Descripcion.");
                ValorerrorProvider.SetError(ValortextBox, "Debe de ingresar el Valor.");
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
            Retenciones retenciones = null;
            retenciones = LlenarClase();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los campos");
            }
            else if (retenciones != null)
            {
                BLL.RetencionesBLL.Guardar(retenciones);
                MessageBox.Show("Retencion guardada!");
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(RetencionesIdtextBox.Text);
            Retenciones retencion = BLL.RetencionesBLL.Buscar(re => re.RetencionId == id);
            if (!string.IsNullOrEmpty(RetencionesIdtextBox.Text))
            {

                if (BLL.RetencionesBLL.Eliminar(retencion))
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
            int id = Utilidades.ToInt(RetencionesIdtextBox.Text);
            Retenciones retenciones = BLL.RetencionesBLL.Buscar(re => re.RetencionId == id);
            if (!string.IsNullOrEmpty(RetencionesIdtextBox.Text))
            {
                if (retenciones != null)
                {
                    DescripciontextBox.Text = retenciones.Descripcion;
                    ValortextBox.Text = retenciones.Valor.ToString();
                }
                else
                {
                    MessageBox.Show("El Empleado no ha sido creado");
                }
            }
        }
    }
}
