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
    public partial class rTiposEmails : Form
    {
        public rTiposEmails()
        {
            InitializeComponent();
        }

        private TiposEmail LlenarClase()
        {
            var tipoEmail = new TiposEmail();
            tipoEmail.Descripcion = DescripciontextBox.Text;
            return tipoEmail;
        }

        public void Limpiar()
        {
            TiposEmailsIdtextBox.Clear();
            DescripciontextBox.Clear();
        }

        public bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                DescripcionerrorProvider.SetError(DescripciontextBox, "Debe de ingresar la Descripcion.");                
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
            TiposEmail tipoEmail = null;
            tipoEmail = LlenarClase();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los campos");
            }
            else if (tipoEmail != null)
            {
                BLL.TiposEmailBLL.Guardar(tipoEmail);
                MessageBox.Show("Tipo de Email guardado!");
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(TiposEmailsIdtextBox.Text);
            TiposEmail tipoEmail = BLL.TiposEmailBLL.Buscar(te => te.TipoId == id);
            if (!string.IsNullOrEmpty(TiposEmailsIdtextBox.Text))
            {
                if (BLL.TiposEmailBLL.Eliminar(tipoEmail))
                {
                    MessageBox.Show("Tipo Email Eliminado!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("El Tipo de Email no existe!");
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(TiposEmailsIdtextBox.Text);
            TiposEmail tipoEmail = BLL.TiposEmailBLL.Buscar(te => te.TipoId == id);
            if (!string.IsNullOrEmpty(TiposEmailsIdtextBox.Text))
            {
                if (tipoEmail != null)
                {
                    DescripciontextBox.Text = tipoEmail.Descripcion;                    
                }
                else
                {
                    MessageBox.Show("El Tipo de Email no ha sido creado");
                }
            }
        }


    }
}
