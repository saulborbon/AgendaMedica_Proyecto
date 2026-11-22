using AgendaMedica.DAL.Conexion;
using AgendaMedica.DAL.Registros;
using MySql.Data.MySqlClient;
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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void CargarMedicos()
        {
            MedicoDAL dal = new MedicoDAL();

            DataTable dt = dal.MostrarMedicos();

            cmbMedico.DataSource = dt;

            cmbMedico.DisplayMember = "nombre";

            cmbMedico.ValueMember = "id_medico";
        }
        private void FrmReportes_Load(object sender, EventArgs e)
        {
            CargarMedicos();
        }

        private void btnCitaDia_Click(object sender, EventArgs e)
        {
            CitaDAL dal = new CitaDAL();

            dataGridView1.DataSource = dal.CitasPorDia(dtpFecha.Value.Date);
        }

        private void btnCitaMedico_Click(object sender, EventArgs e)
        {
            CitaDAL dal = new CitaDAL();

            dataGridView1.DataSource = dal.CitasMedico(Convert.ToInt32(cmbMedico.SelectedValue));
        }

        private void btnCancelada_Click(object sender, EventArgs e)
        {
            CitaDAL dal = new CitaDAL();

            dataGridView1.DataSource = dal.CitasCanceladas();
        }

        private void btnAtendida_Click(object sender, EventArgs e)
        {
            CitaDAL dal = new CitaDAL();

            dataGridView1.DataSource = dal.PacientesAtendidos();
        }

        
    }
    
}
