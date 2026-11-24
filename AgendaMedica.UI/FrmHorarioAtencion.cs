using AgendaMedica.BL.Modelos;
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
    public partial class FrmHorarioAtencion : Form
    {
        public FrmHorarioAtencion()
        {
            InitializeComponent();
        }
        private int idHorario = 0;
        private void CargarMedicos()
        {
            MedicoDAL dal = new MedicoDAL();

            DataTable dt = dal.MostrarMedicos();

            cmbMedico.DataSource = dt;

            cmbMedico.DisplayMember = "nombre";

            cmbMedico.ValueMember = "id_medico";
        }

        private void CargarHorarios()
        {
            HorarioAtencionDAL dal = new HorarioAtencionDAL();

            dataGridView1.DataSource = dal.MostrarHorarios();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idHorario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_horario"].Value);

                cmbMedico.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["id_medico"].Value;

                cmbDia.Text = dataGridView1.Rows[e.RowIndex].Cells["dia_semana"].Value.ToString();

                TimeSpan horaInicio = (TimeSpan)dataGridView1.Rows[e.RowIndex].Cells["hora_inicio"].Value;

                dtpHoraInicio.Value = DateTime.Today.Add(horaInicio);

                TimeSpan horaFin = (TimeSpan)dataGridView1.Rows[e.RowIndex].Cells["hora_fin"].Value;

                dtpHoraFin.Value = DateTime.Today.Add(horaFin);
            }
        }

        private void FrmHorarioAtencion_Load(object sender, EventArgs e)
        {
            CargarMedicos();
            CargarHorarios();
            cmbDia.Items.Add("Monday");
            cmbDia.Items.Add("Tuesday");
            cmbDia.Items.Add("Wednesday");
            cmbDia.Items.Add("Thursday");
            cmbDia.Items.Add("Friday");
            cmbDia.Items.Add("Saturday");
            cmbDia.Items.Add("Sunday");
        }

        private void Limpiar()
        {
            idHorario = 0;

            cmbMedico.SelectedIndex = 0;
            cmbDia.SelectedIndex = -1;

            dtpHoraInicio.Value = DateTime.Now;
            dtpHoraFin.Value = DateTime.Now;

            cmbDia.Focus();
        }
        //private void dtpHoraFin_ValueChanged(object sender, EventArgs e)
        //{

        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HorarioAtencion horario = new HorarioAtencion();

            horario.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue);

            horario.DiaSemana = cmbDia.Text;

            horario.HoraInicio = dtpHoraInicio.Value.TimeOfDay;

            horario.HoraFin = dtpHoraFin.Value.TimeOfDay;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                HorarioAtencion horario = new HorarioAtencion();

                horario.IdHorario = idHorario;

                horario.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue);

                horario.DiaSemana = cmbDia.Text;

                horario.HoraInicio = dtpHoraInicio.Value.TimeOfDay;

                horario.HoraFin = dtpHoraFin.Value.TimeOfDay;

                HorarioAtencionDAL dal = new HorarioAtencionDAL();

                dal.Actualizar(horario);

                CargarHorarios();

                Limpiar();

                MessageBox.Show(
                    "Horario actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
