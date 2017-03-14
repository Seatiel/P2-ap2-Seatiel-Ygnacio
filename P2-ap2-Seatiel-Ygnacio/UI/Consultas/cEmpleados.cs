using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P2_ap2_Seatiel_Ygnacio.UI.Consultas
{
    public partial class cEmpleados : Form
    {
        public cEmpleados()
        {
            InitializeComponent();
        }

        private void cEmpleados_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        public void LlenarCombo()
        {
            FiltrarcomboBox.Items.Insert(0, "Nombres y Fecha");
            FiltrarcomboBox.Items.Insert(1, "Todos");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Todos";
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(FiltrartextBox.Text))
            {
                FiltrarerrorProvider.SetError(FiltrartextBox, "Llenar los campos vacios.");
                return false;
            }
            return true;
        }

        public void FiltrarOpcion()
        {
            if (string.IsNullOrEmpty(FiltrartextBox.Text))
            {
                if (FiltrarcomboBox.SelectedIndex == 0)
                {
                    EmpleadosDetalledataGridView.DataSource = BLL.EmpleadosBLL.Lista(emp => emp.Equals(FiltrarcomboBox.Text));
                    EmpleadosDetalledataGridView.DataSource = BLL.EmpleadosBLL.Lista(emp => emp.FechaNacimiento.Equals(FechadateTimePicker.Value.Date));
                }
            }            
            else
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                EmpleadosDetalledataGridView.DataSource = BLL.EmpleadosBLL.ListarTodo();
                this.EmpleadosDetalledataGridView.Columns["Detalle"].Visible = false;
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            FiltrarOpcion();
        }


    }
}
