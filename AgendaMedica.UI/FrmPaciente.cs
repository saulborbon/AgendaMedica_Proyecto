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
using AgendaMedica.BL.Servicios;
using AgendaMedica.DAL.Registros;

namespace AgendaMedica.UI
{
    public partial class FrmPaciente : Form
    {
        private int idPaciente = 0; //Esta variablealamcena el id del paciente seleccionado en DataGridView
        public FrmPaciente()
        {
            InitializeComponent();
        }
        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void CargarPacientes()
        {
            PacienteDAL dal = new PacienteDAL();
            dataGridView1.DataSource = dal.MostrarPacientes();
        }

        private void Limpiar()
        {
            idPaciente = 0;

            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            dateTimePicker1.Value = DateTime.Now;

            txtCedula.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();

                paciente.Cedula = txtCedula.Text;
                paciente.Nombre = txtNombre.Text;
                paciente.Apellido = txtApellido.Text;
                paciente.Telefono = txtTelefono.Text;
                paciente.Correo = txtCorreo.Text;
                paciente.FechaNacimiento = dateTimePicker1.Value;

                PacienteBL bl = new PacienteBL();
                bl.ValidarPaciente(paciente);

                PacienteDAL dal = new PacienteDAL();
                dal.Guardar(paciente);

                MessageBox.Show("Paciente guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idPaciente == 0)
                {
                    MessageBox.Show("Seleccione un paciente a eliminar");
                    return;
                }
                PacienteDAL dal = new PacienteDAL();
                dal.Eliminar(idPaciente);

                CargarPacientes();
                Limpiar();
                MessageBox.Show("Paciente eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idPaciente == 0)
                {
                    MessageBox.Show("Selecciona un paciente");
                    return;
                }
                Paciente paciente = new Paciente();

                paciente.IdPaciente = idPaciente;
                paciente.Cedula = txtCedula.Text;
                paciente.Nombre = txtNombre.Text;
                paciente.Apellido = txtApellido.Text;
                paciente.Telefono = txtTelefono.Text;
                paciente.Correo = txtCorreo.Text;
                paciente.FechaNacimiento = dateTimePicker1.Value;

                PacienteDAL dal = new PacienteDAL();
                dal.Actualizar(paciente);

                CargarPacientes();
                Limpiar();

                MessageBox.Show("Información actualizada");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPaciente = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_paciente"].Value);

                txtCedula.Text = dataGridView1.Rows[e.RowIndex].Cells["cedula"].Value.ToString();

                txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();

                txtApellido.Text = dataGridView1.Rows[e.RowIndex].Cells["apellido"].Value.ToString();

                txtTelefono.Text = dataGridView1.Rows[e.RowIndex].Cells["telefono"].Value.ToString();

                txtCorreo.Text = dataGridView1.Rows[e.RowIndex].Cells["correo"].Value.ToString();

                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["fecha_nacimiento"].Value);
            }

        }
    }
}
