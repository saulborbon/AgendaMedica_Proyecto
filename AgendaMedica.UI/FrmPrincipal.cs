using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMedica.UI
{
    public partial class FrmPrincipal : Form
    {
        private string rolUsuario;
        public FrmPrincipal(string rol)
        {
            InitializeComponent();

            rolUsuario = rol;

            ConfigurarPermisos();
        }

        private void ConfigurarPermisos()
        {
            if (rolUsuario == "Recepcion")
            {
                btnUsuarios.Visible = false;
                btnRoles.Visible = false;
            }
        }


        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FrmPaciente frm = new FrmPaciente();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FrmMedico frm = new FrmMedico();
            frm.ShowDialog();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FrmCita frm = new FrmCita();
            frm.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.ShowDialog();
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            FrmEspecialidad frm = new FrmEspecialidad();
            frm.ShowDialog();
        }

        private void btnHmedico_Click(object sender, EventArgs e)
        {
            FrmHistorialMedico frm = new FrmHistorialMedico();
            frm.ShowDialog();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FrmRol frm = new FrmRol();
            frm.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();
            frm.ShowDialog();
        }

        private void btnHorarioAtencion_Click(object sender, EventArgs e)
        {
            FrmHorarioAtencion frm = new FrmHorarioAtencion();
            frm.ShowDialog();
        }
    }
}
