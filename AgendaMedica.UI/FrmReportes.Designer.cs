namespace AgendaMedica.UI
{
    partial class FrmReportes
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
            this.btnCitaDia = new System.Windows.Forms.Button();
            this.btnCitaMedico = new System.Windows.Forms.Button();
            this.btnCancelada = new System.Windows.Forms.Button();
            this.btnAtendida = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCitaDia
            // 
            this.btnCitaDia.Location = new System.Drawing.Point(31, 31);
            this.btnCitaDia.Name = "btnCitaDia";
            this.btnCitaDia.Size = new System.Drawing.Size(90, 40);
            this.btnCitaDia.TabIndex = 0;
            this.btnCitaDia.Text = "Citas por día";
            this.btnCitaDia.UseVisualStyleBackColor = true;
            this.btnCitaDia.Click += new System.EventHandler(this.btnCitaDia_Click);
            // 
            // btnCitaMedico
            // 
            this.btnCitaMedico.Location = new System.Drawing.Point(148, 34);
            this.btnCitaMedico.Name = "btnCitaMedico";
            this.btnCitaMedico.Size = new System.Drawing.Size(118, 37);
            this.btnCitaMedico.TabIndex = 1;
            this.btnCitaMedico.Text = "Cita por Medico";
            this.btnCitaMedico.UseVisualStyleBackColor = true;
            this.btnCitaMedico.Click += new System.EventHandler(this.btnCitaMedico_Click);
            // 
            // btnCancelada
            // 
            this.btnCancelada.Location = new System.Drawing.Point(295, 34);
            this.btnCancelada.Name = "btnCancelada";
            this.btnCancelada.Size = new System.Drawing.Size(91, 38);
            this.btnCancelada.TabIndex = 2;
            this.btnCancelada.Text = "Canceladas";
            this.btnCancelada.UseVisualStyleBackColor = true;
            this.btnCancelada.Click += new System.EventHandler(this.btnCancelada_Click);
            // 
            // btnAtendida
            // 
            this.btnAtendida.Location = new System.Drawing.Point(428, 34);
            this.btnAtendida.Name = "btnAtendida";
            this.btnAtendida.Size = new System.Drawing.Size(89, 40);
            this.btnAtendida.TabIndex = 3;
            this.btnAtendida.Text = "Atendidas";
            this.btnAtendida.UseVisualStyleBackColor = true;
            this.btnAtendida.Click += new System.EventHandler(this.btnAtendida_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 248);
            this.dataGridView1.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(172, 95);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 5;
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(31, 93);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(121, 24);
            this.cmbMedico.TabIndex = 6;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAtendida);
            this.Controls.Add(this.btnCancelada);
            this.Controls.Add(this.btnCitaMedico);
            this.Controls.Add(this.btnCitaDia);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCitaDia;
        private System.Windows.Forms.Button btnCitaMedico;
        private System.Windows.Forms.Button btnCancelada;
        private System.Windows.Forms.Button btnAtendida;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbMedico;
    }
}