using AgendaMedica.BL.Modelos;
using AgendaMedica.BL.Servicios;
using AgendaMedica.DAL.Registros;
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
    public partial class FrmCita : Form
    {
        public FrmCita()
        {
            InitializeComponent();
        }

        private int idCita = 0;
        private void FrmCita_Load(object sender, EventArgs e)
        {
            CargarPacientes();
            CargarMedicos();
            CargarCitas();

            cmbDuracion.Items.Add(30);
            cmbDuracion.Items.Add(45);
            cmbDuracion.Items.Add(60);

            cmbTipoCita.Items.Add("Presencial");
            cmbTipoCita.Items.Add("Virtual");
            cmbTipoCita.Items.Add("Urgencia");

            cmbEstado.Items.Add("Programada");
            cmbEstado.Items.Add("Confirmada");
            cmbEstado.Items.Add("Atendida");
            cmbEstado.Items.Add("Cancelada");
            cmbEstado.Items.Add("No asistió");
            cmbEstado.Items.Add("Reprogramada");
        }
        private void CargarPacientes()
        {
            PacienteDAL dal = new PacienteDAL();

            DataTable dt = dal.MostrarPacientes();

            cmbPaciente.DataSource = dt;

            cmbPaciente.DisplayMember = "nombre";

            cmbPaciente.ValueMember = "id_paciente";
            
        }
        private void CargarMedicos()
        {
            MedicoDAL dal = new MedicoDAL();

            DataTable dt = dal.MostrarMedicos();

            cmbMedico.DataSource = dt;

            cmbMedico.DisplayMember = "nombre";

            cmbMedico.ValueMember = "id_medico";
        }
        private void CargarCitas()
        {
            CitaDAL dal = new CitaDAL();

            dataGridView1.DataSource = dal.MostrarCitas();
        }

        private void Limpiar()
        {
            idCita = 0;

            cmbPaciente.SelectedIndex = 0;
            cmbMedico.SelectedIndex = 0;

            cmbDuracion.SelectedIndex = -1;
            cmbTipoCita.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cita cita = new Cita();

                cita.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);

                cita.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue);

                cita.Fecha = dtpFecha.Value.Date;

                cita.HoraInicio = dtpHoraInicio.Value.TimeOfDay;

                cita.DuracionMinutos = Convert.ToInt32(cmbDuracion.Text);

                cita.HoraFin = cita.HoraInicio.Add(TimeSpan.FromMinutes(cita.DuracionMinutos));

                cita.TipoCita = cmbTipoCita.Text;

                cita.EstadoCita = cmbEstado.Text;

                MessageBox.Show( "Paciente: " + cita.IdPaciente +
                                 "\nMedico: " + cita.IdMedico);

                CitaBL bl = new CitaBL();

                bl.ValidarCita(cita);

                CitaDAL dal = new CitaDAL();

                if (dal.ExisteSolapamiento(
                    cita.IdMedico,
                    cita.Fecha,
                    cita.HoraInicio,
                    cita.HoraFin))
                {
                    MessageBox.Show("El médico ya tiene una cita en esa hora");
                    return;
                }
                if (dal.PacienteOcupado(
                    cita.IdPaciente,
                    cita.Fecha,
                    cita.HoraInicio,
                    cita.HoraFin))
                {
                    MessageBox.Show("El paciente ya tiene una cita en esa hora");
                    return;
                }

                dal.Guardar(cita);

                CargarCitas();

                Limpiar();

                MessageBox.Show("Cita registrada correctamente");
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
                idCita = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_cita"].Value);

                cmbPaciente.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["id_paciente"].Value;

                cmbMedico.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["id_medico"].Value;

                dtpFecha.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["fecha"].Value);

                TimeSpan horaInicio = (TimeSpan)dataGridView1.Rows[e.RowIndex].Cells["hora_inicio"].Value;

                dtpHoraInicio.Value = DateTime.Today.Add(horaInicio);

                cmbDuracion.Text = dataGridView1.Rows[e.RowIndex].Cells["duracion_minutos"].Value.ToString();

                cmbTipoCita.Text = dataGridView1.Rows[e.RowIndex].Cells["tipo_cita"].Value.ToString();

                cmbEstado.Text = dataGridView1.Rows[e.RowIndex].Cells["estado_cita"].Value.ToString();

                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Cita cita = new Cita();

                cita.IdCita = idCita;

                cita.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);

                cita.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue);

                cita.Fecha = dtpFecha.Value.Date;

                cita.HoraInicio = dtpHoraInicio.Value.TimeOfDay;

                cita.DuracionMinutos = Convert.ToInt32(cmbDuracion.Text);

                cita.HoraFin = cita.HoraInicio.Add(TimeSpan.FromMinutes(cita.DuracionMinutos));

                cita.TipoCita = cmbTipoCita.Text;

                cita.EstadoCita = cmbEstado.Text;

                CitaDAL dal = new CitaDAL();

                dal.Actualizar(cita);

                CargarCitas();

                Limpiar();

                MessageBox.Show("Cita actualizada correctamente");
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
                if (idCita == 0)
                {
                    MessageBox.Show("Seleccione una cita");
                    return;
                }

                CitaDAL dal = new CitaDAL();

                dal.Eliminar(idCita);

                CargarCitas();

                Limpiar();

                MessageBox.Show("Cita eliminada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
            }
        }
    }
}
