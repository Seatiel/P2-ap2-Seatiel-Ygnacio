namespace P2_ap2_Seatiel_Ygnacio.UI.Consultas
{
    partial class cEmpleados
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
            this.EmpleadosDetalledataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrartextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.FiltrarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosDetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltrarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpleadosDetalledataGridView
            // 
            this.EmpleadosDetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpleadosDetalledataGridView.Location = new System.Drawing.Point(12, 138);
            this.EmpleadosDetalledataGridView.Name = "EmpleadosDetalledataGridView";
            this.EmpleadosDetalledataGridView.RowTemplate.Height = 24;
            this.EmpleadosDetalledataGridView.Size = new System.Drawing.Size(604, 317);
            this.EmpleadosDetalledataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar:";
            // 
            // FiltrartextBox
            // 
            this.FiltrartextBox.Location = new System.Drawing.Point(80, 37);
            this.FiltrartextBox.Name = "FiltrartextBox";
            this.FiltrartextBox.Size = new System.Drawing.Size(274, 22);
            this.FiltrartextBox.TabIndex = 2;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(518, 21);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(80, 38);
            this.Buscarbutton.TabIndex = 3;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha:";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(80, 76);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(145, 22);
            this.FechadateTimePicker.TabIndex = 5;
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Location = new System.Drawing.Point(360, 35);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(152, 24);
            this.FiltrarcomboBox.TabIndex = 6;
            // 
            // FiltrarerrorProvider
            // 
            this.FiltrarerrorProvider.ContainerControl = this;
            // 
            // cEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 467);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FiltrartextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpleadosDetalledataGridView);
            this.Name = "cEmpleados";
            this.Text = "cEmpleados";
            this.Load += new System.EventHandler(this.cEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosDetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltrarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpleadosDetalledataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FiltrartextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.ErrorProvider FiltrarerrorProvider;
    }
}