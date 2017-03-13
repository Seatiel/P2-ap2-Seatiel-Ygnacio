using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P2_ap2_Seatiel_Ygnacio
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void registrosEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rEmpleados re = new UI.Registros.rEmpleados();
            re.Show();
        }

        private void retencionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rRetenciones r = new UI.Registros.rRetenciones();
            r.Show();
        }

        private void tiposEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rTiposEmails rt = new UI.Registros.rTiposEmails();
            rt.Show();
        }
    }
}
