﻿namespace P2_ap2_Seatiel_Ygnacio
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retencionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosEmpleadosToolStripMenuItem,
            this.tiposEmailsToolStripMenuItem,
            this.retencionesToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registrosEmpleadosToolStripMenuItem
            // 
            this.registrosEmpleadosToolStripMenuItem.Name = "registrosEmpleadosToolStripMenuItem";
            this.registrosEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.registrosEmpleadosToolStripMenuItem.Text = "Registros Empleados";
            this.registrosEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.registrosEmpleadosToolStripMenuItem_Click);
            // 
            // tiposEmailsToolStripMenuItem
            // 
            this.tiposEmailsToolStripMenuItem.Name = "tiposEmailsToolStripMenuItem";
            this.tiposEmailsToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.tiposEmailsToolStripMenuItem.Text = "Registros Tipos Emails";
            this.tiposEmailsToolStripMenuItem.Click += new System.EventHandler(this.tiposEmailsToolStripMenuItem_Click);
            // 
            // retencionesToolStripMenuItem
            // 
            this.retencionesToolStripMenuItem.Name = "retencionesToolStripMenuItem";
            this.retencionesToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.retencionesToolStripMenuItem.Text = "Registros Retenciones";
            this.retencionesToolStripMenuItem.Click += new System.EventHandler(this.retencionesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.empleadosToolStripMenuItem.Text = "Consultas Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.Text = "Formulario Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposEmailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retencionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
    }
}

