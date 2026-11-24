namespace AgendaMedica.UI
{
    partial class FrmPrincipal
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
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEspecialidad = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnHmedico = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(129, 49);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(72, 32);
            this.btnPacientes.TabIndex = 0;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.Location = new System.Drawing.Point(9, 95);
            this.btnMedicos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(88, 28);
            this.btnMedicos.TabIndex = 1;
            this.btnMedicos.Text = "Medicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Location = new System.Drawing.Point(226, 93);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(84, 29);
            this.btnCitas.TabIndex = 2;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(443, 76);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(63, 28);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEspecialidad
            // 
            this.btnEspecialidad.Location = new System.Drawing.Point(9, 49);
            this.btnEspecialidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEspecialidad.Name = "btnEspecialidad";
            this.btnEspecialidad.Size = new System.Drawing.Size(88, 32);
            this.btnEspecialidad.TabIndex = 4;
            this.btnEspecialidad.Text = "Especialidad";
            this.btnEspecialidad.UseVisualStyleBackColor = true;
            this.btnEspecialidad.Click += new System.EventHandler(this.btnEspecialidad_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(67, 7);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(177, 24);
            this.lbltitulo.TabIndex = 5;
            this.lbltitulo.Text = "AGENDA MEDICA";
            // 
            // btnHmedico
            // 
            this.btnHmedico.Location = new System.Drawing.Point(226, 49);
            this.btnHmedico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHmedico.Name = "btnHmedico";
            this.btnHmedico.Size = new System.Drawing.Size(84, 32);
            this.btnHmedico.TabIndex = 6;
            this.btnHmedico.Text = "Historial Medico";
            this.btnHmedico.UseVisualStyleBackColor = true;
            this.btnHmedico.Click += new System.EventHandler(this.btnHmedico_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(129, 95);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(72, 28);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Location = new System.Drawing.Point(328, 49);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(63, 32);
            this.btnRoles.TabIndex = 8;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(328, 95);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(63, 28);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 358);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnRoles);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnHmedico);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btnEspecialidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnMedicos);
            this.Controls.Add(this.btnPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEspecialidad;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnHmedico;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnReportes;
    }
}