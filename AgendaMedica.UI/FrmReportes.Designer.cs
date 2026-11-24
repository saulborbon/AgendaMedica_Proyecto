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
            this.btnCitaDia.BackColor = System.Drawing.Color.Beige;
            this.btnCitaDia.Location = new System.Drawing.Point(23, 25);
            this.btnCitaDia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCitaDia.Name = "btnCitaDia";
            this.btnCitaDia.Size = new System.Drawing.Size(68, 32);
            this.btnCitaDia.TabIndex = 0;
            this.btnCitaDia.Text = "Citas por día";
            this.btnCitaDia.UseVisualStyleBackColor = false;
            this.btnCitaDia.Click += new System.EventHandler(this.btnCitaDia_Click);
            // 
            // btnCitaMedico
            // 
            this.btnCitaMedico.BackColor = System.Drawing.Color.Beige;
            this.btnCitaMedico.Location = new System.Drawing.Point(111, 28);
            this.btnCitaMedico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCitaMedico.Name = "btnCitaMedico";
            this.btnCitaMedico.Size = new System.Drawing.Size(88, 30);
            this.btnCitaMedico.TabIndex = 1;
            this.btnCitaMedico.Text = "Cita por Medico";
            this.btnCitaMedico.UseVisualStyleBackColor = false;
            this.btnCitaMedico.Click += new System.EventHandler(this.btnCitaMedico_Click);
            // 
            // btnCancelada
            // 
            this.btnCancelada.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelada.Location = new System.Drawing.Point(221, 28);
            this.btnCancelada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelada.Name = "btnCancelada";
            this.btnCancelada.Size = new System.Drawing.Size(68, 31);
            this.btnCancelada.TabIndex = 2;
            this.btnCancelada.Text = "Canceladas";
            this.btnCancelada.UseVisualStyleBackColor = false;
            this.btnCancelada.Click += new System.EventHandler(this.btnCancelada_Click);
            // 
            // btnAtendida
            // 
            this.btnAtendida.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAtendida.Location = new System.Drawing.Point(321, 28);
            this.btnAtendida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtendida.Name = "btnAtendida";
            this.btnAtendida.Size = new System.Drawing.Size(67, 32);
            this.btnAtendida.TabIndex = 3;
            this.btnAtendida.Text = "Atendidas";
            this.btnAtendida.UseVisualStyleBackColor = false;
            this.btnAtendida.Click += new System.EventHandler(this.btnAtendida_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(448, 202);
            this.dataGridView1.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(129, 77);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(151, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(23, 76);
            this.cmbMedico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(92, 21);
            this.cmbMedico.TabIndex = 6;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAtendida);
            this.Controls.Add(this.btnCancelada);
            this.Controls.Add(this.btnCitaMedico);
            this.Controls.Add(this.btnCitaDia);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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