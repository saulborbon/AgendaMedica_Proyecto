using AgendaMedica.BL.Servicios;
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
using AgendaMedica.BL.Modelos;

namespace AgendaMedica.UI
{
    public partial class FrmHistorialMedico : Form
    {
        public FrmHistorialMedico()
        {
            InitializeComponent();
        }
        private int idHistorial = 0;

        private void CargarPacientes()
        {
            PacienteDAL dal = new PacienteDAL();

            DataTable dt =
                dal.MostrarPacientes();

            cmbPaciente.DataSource = dt;

            cmbPaciente.DisplayMember = "nombre";

            cmbPaciente.ValueMember = "id_paciente";
        }
        private void CargarCitas()
        {
            CitaDAL dal = new CitaDAL();

            DataTable dt =
                dal.MostrarCitas();

            cmbCita.DataSource = dt;

            cmbCita.DisplayMember = "id_cita";

            cmbCita.ValueMember = "id_cita";
        }
        private void CargarHistorial()
        {
            HistorialMedicoDAL dal = new HistorialMedicoDAL();
            dataGridView1.DataSource = dal.MostrarHistorial();
        }
     
        private void HistorialMedico_Load(object sender, EventArgs e)
        {
            CargarPacientes();
            CargarCitas();
            CargarHistorial();
        }
        private void Limpiar()
        {
            idHistorial = 0;

            txtDiagnostico.Clear();

            txtObservaciones.Clear();

            txtDiagnostico.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                HistorialMedico historial = new HistorialMedico();

                historial.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);

                historial.IdCita = Convert.ToInt32(cmbCita.SelectedValue);

                historial.FechaRegistro = DateTime.Now;

                historial.Diagnostico = txtDiagnostico.Text;

                historial.Observaciones = txtObservaciones.Text;

                HistorialMedicoBL bl = new HistorialMedicoBL();

                bl.ValidarHistorial(historial);

                HistorialMedicoDAL dal = new HistorialMedicoDAL();

                dal.Guardar(historial);

                CargarHistorial();

                Limpiar();

                MessageBox.Show(
                    "Historial guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.RowIndex >= 0)
            {
                idHistorial =
                    Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["id_historial"].Value);

                cmbPaciente.SelectedValue =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["id_paciente"].Value;

                cmbCita.SelectedValue =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["id_cita"].Value;

                txtDiagnostico.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["diagnostico"]
                    .Value.ToString();

                txtObservaciones.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["observaciones"]
                    .Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                HistorialMedico historial = new HistorialMedico();

                historial.IdHistorial = idHistorial;

                historial.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);

                historial.IdCita = Convert.ToInt32(cmbCita.SelectedValue);

                historial.FechaRegistro = DateTime.Now;

                historial.Diagnostico = txtDiagnostico.Text;

                historial.Observaciones = txtObservaciones.Text;

                HistorialMedicoDAL dal = new HistorialMedicoDAL();

                dal.Actualizar(historial);

                CargarHistorial();

                Limpiar();

                MessageBox.Show(
                    "Historial actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idHistorial == 0)
                {
                    MessageBox.Show(
                        "Seleccione un historial");

                    return;
                }

                HistorialMedicoDAL dal = new HistorialMedicoDAL();

                dal.Eliminar(idHistorial);

                CargarHistorial();

                Limpiar();

                MessageBox.Show(
                    "Historial eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
