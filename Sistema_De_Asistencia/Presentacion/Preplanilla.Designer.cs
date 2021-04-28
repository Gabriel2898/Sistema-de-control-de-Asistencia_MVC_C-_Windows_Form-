namespace ORUSCURSO.Presentacion
{
    partial class Preplanilla
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblnumerosemana = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtdesde = new System.Windows.Forms.DateTimePicker();
            this.txthasta = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Panel5.Controls.Add(this.Label5);
            this.Panel5.Controls.Add(this.Label6);
            this.Panel5.Controls.Add(this.lblnumerosemana);
            this.Panel5.Controls.Add(this.Label7);
            this.Panel5.Controls.Add(this.txtdesde);
            this.Panel5.Controls.Add(this.txthasta);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(922, 81);
            this.Panel5.TabIndex = 611;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(1, 36);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(44, 25);
            this.Label5.TabIndex = 600;
            this.Label5.Text = "Del";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(165, 35);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(29, 25);
            this.Label6.TabIndex = 600;
            this.Label6.Text = "al";
            // 
            // lblnumerosemana
            // 
            this.lblnumerosemana.AutoSize = true;
            this.lblnumerosemana.BackColor = System.Drawing.Color.Transparent;
            this.lblnumerosemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblnumerosemana.ForeColor = System.Drawing.Color.White;
            this.lblnumerosemana.Location = new System.Drawing.Point(446, 35);
            this.lblnumerosemana.Name = "lblnumerosemana";
            this.lblnumerosemana.Size = new System.Drawing.Size(24, 25);
            this.lblnumerosemana.TabIndex = 600;
            this.lblnumerosemana.Text = "#";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(315, 35);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(128, 25);
            this.Label7.TabIndex = 600;
            this.Label7.Text = "Semana Nº:";
            // 
            // txtdesde
            // 
            this.txtdesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdesde.Location = new System.Drawing.Point(46, 35);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(109, 26);
            this.txtdesde.TabIndex = 602;
            this.txtdesde.Value = new System.DateTime(2020, 11, 7, 0, 0, 0, 0);
            this.txtdesde.ValueChanged += new System.EventHandler(this.txtdesde_ValueChanged);
            // 
            // txthasta
            // 
            this.txthasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txthasta.Location = new System.Drawing.Point(200, 35);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(109, 26);
            this.txthasta.TabIndex = 602;
            this.txthasta.Value = new System.DateTime(2020, 11, 7, 0, 0, 0, 0);
            this.txthasta.ValueChanged += new System.EventHandler(this.txthasta_ValueChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(922, 436);
            this.reportViewer1.TabIndex = 612;
            this.reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            // 
            // Preplanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Panel5);
            this.Name = "Preplanilla";
            this.Size = new System.Drawing.Size(922, 517);
            this.Load += new System.EventHandler(this.Preplanilla_Load);
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblnumerosemana;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DateTimePicker txtdesde;
        internal System.Windows.Forms.DateTimePicker txthasta;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
    }
}
