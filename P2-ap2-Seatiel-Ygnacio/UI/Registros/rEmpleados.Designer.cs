namespace P2_ap2_Seatiel_Ygnacio.UI.Registros
{
    partial class rEmpleados
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
            this.components = new System.ComponentModel.Container();
            this.EmpleadoIdtextBox = new System.Windows.Forms.TextBox();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.SueldotextBox = new System.Windows.Forms.TextBox();
            this.FechaNacimientodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.ValidarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmpleadosRetencionesgroupBox = new System.Windows.Forms.GroupBox();
            this.RetencionescomboBox = new System.Windows.Forms.ComboBox();
            this.EmpleadosRetencionesdataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.AgregarRetencionbutton = new System.Windows.Forms.Button();
            this.EmpleadosEmailsgroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.TiposcomboBox = new System.Windows.Forms.ComboBox();
            this.EmpleadosEmailsdataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarEmailbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarerrorProvider)).BeginInit();
            this.EmpleadosRetencionesgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosRetencionesdataGridView)).BeginInit();
            this.EmpleadosEmailsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosEmailsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpleadoIdtextBox
            // 
            this.EmpleadoIdtextBox.Location = new System.Drawing.Point(150, 24);
            this.EmpleadoIdtextBox.Name = "EmpleadoIdtextBox";
            this.EmpleadoIdtextBox.Size = new System.Drawing.Size(36, 22);
            this.EmpleadoIdtextBox.TabIndex = 0;
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(150, 65);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(213, 22);
            this.NombrestextBox.TabIndex = 1;
            // 
            // SueldotextBox
            // 
            this.SueldotextBox.Location = new System.Drawing.Point(150, 147);
            this.SueldotextBox.Name = "SueldotextBox";
            this.SueldotextBox.Size = new System.Drawing.Size(213, 22);
            this.SueldotextBox.TabIndex = 2;
            // 
            // FechaNacimientodateTimePicker
            // 
            this.FechaNacimientodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientodateTimePicker.Location = new System.Drawing.Point(150, 106);
            this.FechaNacimientodateTimePicker.Name = "FechaNacimientodateTimePicker";
            this.FechaNacimientodateTimePicker.Size = new System.Drawing.Size(213, 22);
            this.FechaNacimientodateTimePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empleado Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sueldo:";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(162, 653);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(94, 39);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(317, 653);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(94, 39);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(477, 653);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(94, 39);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(230, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(100, 34);
            this.Buscarbutton.TabIndex = 11;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ValidarerrorProvider
            // 
            this.ValidarerrorProvider.ContainerControl = this;
            // 
            // EmpleadosRetencionesgroupBox
            // 
            this.EmpleadosRetencionesgroupBox.Controls.Add(this.RetencionescomboBox);
            this.EmpleadosRetencionesgroupBox.Controls.Add(this.EmpleadosRetencionesdataGridView);
            this.EmpleadosRetencionesgroupBox.Controls.Add(this.label7);
            this.EmpleadosRetencionesgroupBox.Controls.Add(this.AgregarRetencionbutton);
            this.EmpleadosRetencionesgroupBox.Location = new System.Drawing.Point(12, 175);
            this.EmpleadosRetencionesgroupBox.Name = "EmpleadosRetencionesgroupBox";
            this.EmpleadosRetencionesgroupBox.Size = new System.Drawing.Size(731, 194);
            this.EmpleadosRetencionesgroupBox.TabIndex = 12;
            this.EmpleadosRetencionesgroupBox.TabStop = false;
            this.EmpleadosRetencionesgroupBox.Text = "Empleados Retenciones";
            // 
            // RetencionescomboBox
            // 
            this.RetencionescomboBox.FormattingEnabled = true;
            this.RetencionescomboBox.Location = new System.Drawing.Point(6, 54);
            this.RetencionescomboBox.Name = "RetencionescomboBox";
            this.RetencionescomboBox.Size = new System.Drawing.Size(228, 24);
            this.RetencionescomboBox.TabIndex = 58;
            // 
            // EmpleadosRetencionesdataGridView
            // 
            this.EmpleadosRetencionesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpleadosRetencionesdataGridView.Location = new System.Drawing.Point(6, 82);
            this.EmpleadosRetencionesdataGridView.Name = "EmpleadosRetencionesdataGridView";
            this.EmpleadosRetencionesdataGridView.RowTemplate.Height = 24;
            this.EmpleadosRetencionesdataGridView.Size = new System.Drawing.Size(719, 106);
            this.EmpleadosRetencionesdataGridView.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Retenciones:";
            // 
            // AgregarRetencionbutton
            // 
            this.AgregarRetencionbutton.Location = new System.Drawing.Point(614, 42);
            this.AgregarRetencionbutton.Name = "AgregarRetencionbutton";
            this.AgregarRetencionbutton.Size = new System.Drawing.Size(100, 34);
            this.AgregarRetencionbutton.TabIndex = 56;
            this.AgregarRetencionbutton.Text = "Agregar";
            this.AgregarRetencionbutton.UseVisualStyleBackColor = true;
            this.AgregarRetencionbutton.Click += new System.EventHandler(this.AgregarRetencionbutton_Click);
            // 
            // EmpleadosEmailsgroupBox
            // 
            this.EmpleadosEmailsgroupBox.Controls.Add(this.label5);
            this.EmpleadosEmailsgroupBox.Controls.Add(this.EmailtextBox);
            this.EmpleadosEmailsgroupBox.Controls.Add(this.TiposcomboBox);
            this.EmpleadosEmailsgroupBox.Controls.Add(this.EmpleadosEmailsdataGridView);
            this.EmpleadosEmailsgroupBox.Controls.Add(this.label6);
            this.EmpleadosEmailsgroupBox.Controls.Add(this.AgregarEmailbutton);
            this.EmpleadosEmailsgroupBox.Location = new System.Drawing.Point(12, 384);
            this.EmpleadosEmailsgroupBox.Name = "EmpleadosEmailsgroupBox";
            this.EmpleadosEmailsgroupBox.Size = new System.Drawing.Size(731, 244);
            this.EmpleadosEmailsgroupBox.TabIndex = 13;
            this.EmpleadosEmailsgroupBox.TabStop = false;
            this.EmpleadosEmailsgroupBox.Text = "Empleados Email\'s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Email:";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(293, 67);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(269, 22);
            this.EmailtextBox.TabIndex = 52;
            // 
            // TiposcomboBox
            // 
            this.TiposcomboBox.FormattingEnabled = true;
            this.TiposcomboBox.Location = new System.Drawing.Point(9, 65);
            this.TiposcomboBox.Name = "TiposcomboBox";
            this.TiposcomboBox.Size = new System.Drawing.Size(228, 24);
            this.TiposcomboBox.TabIndex = 55;
            // 
            // EmpleadosEmailsdataGridView
            // 
            this.EmpleadosEmailsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpleadosEmailsdataGridView.Location = new System.Drawing.Point(6, 100);
            this.EmpleadosEmailsdataGridView.Name = "EmpleadosEmailsdataGridView";
            this.EmpleadosEmailsdataGridView.RowTemplate.Height = 24;
            this.EmpleadosEmailsdataGridView.Size = new System.Drawing.Size(719, 127);
            this.EmpleadosEmailsdataGridView.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Tipos Emails:";
            // 
            // AgregarEmailbutton
            // 
            this.AgregarEmailbutton.Location = new System.Drawing.Point(614, 55);
            this.AgregarEmailbutton.Name = "AgregarEmailbutton";
            this.AgregarEmailbutton.Size = new System.Drawing.Size(100, 34);
            this.AgregarEmailbutton.TabIndex = 51;
            this.AgregarEmailbutton.Text = "Agregar";
            this.AgregarEmailbutton.UseVisualStyleBackColor = true;
            this.AgregarEmailbutton.Click += new System.EventHandler(this.AgregarEmailbutton_Click);
            // 
            // rEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 704);
            this.Controls.Add(this.EmpleadosEmailsgroupBox);
            this.Controls.Add(this.EmpleadosRetencionesgroupBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaNacimientodateTimePicker);
            this.Controls.Add(this.SueldotextBox);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.EmpleadoIdtextBox);
            this.Name = "rEmpleados";
            this.Text = "rEmpleados";
            this.Load += new System.EventHandler(this.rEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ValidarerrorProvider)).EndInit();
            this.EmpleadosRetencionesgroupBox.ResumeLayout(false);
            this.EmpleadosRetencionesgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosRetencionesdataGridView)).EndInit();
            this.EmpleadosEmailsgroupBox.ResumeLayout(false);
            this.EmpleadosEmailsgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosEmailsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmpleadoIdtextBox;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.TextBox SueldotextBox;
        private System.Windows.Forms.DateTimePicker FechaNacimientodateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider ValidarerrorProvider;
        private System.Windows.Forms.GroupBox EmpleadosEmailsgroupBox;
        private System.Windows.Forms.GroupBox EmpleadosRetencionesgroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.ComboBox TiposcomboBox;
        private System.Windows.Forms.DataGridView EmpleadosEmailsdataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgregarEmailbutton;
        private System.Windows.Forms.ComboBox RetencionescomboBox;
        private System.Windows.Forms.DataGridView EmpleadosRetencionesdataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AgregarRetencionbutton;
    }
}