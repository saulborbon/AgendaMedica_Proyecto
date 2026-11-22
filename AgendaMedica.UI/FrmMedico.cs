using AgendaMedica.BL.Modelos;
using AgendaMedica.BL.Servicios;
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
    public partial class FrmMedico : Form
    {
        public FrmMedico()
        {
            InitializeComponent();
        }
        private int idMedico = 0;

        private void CargarMedicos()
        {
            MedicoDAL dal = new MedicoDAL();

            dataGridView1.DataSource =
                dal.MostrarMedicos();
        }
        private void FrmMedico_Load(object sender, EventArgs e)
        {
            CargarMedicos();
            CargarEspecialidades();
        }

        private void Limpiar()
        {
            idMedico = 0;

            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            checkBox1.Checked = true;

            txtCedula.Focus();
        }
        private void CargarEspecialidades()
        {
            EspecialidadDAL dal = new EspecialidadDAL();

            DataTable dt = dal.MostrarEspecialidades();

            cmbEspecialidad.DataSource = dt;

            cmbEspecialidad.DisplayMember = "nombre_especialidad";

            cmbEspecialidad.ValueMember = "id_especialidad";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico();

                medico.Cedula = txtCedula.Text;
                medico.Nombre = txtNombre.Text;
                medico.Apellido = txtApellido.Text;
                medico.Telefono = txtTelefono.Text;
                medico.Correo = txtCorreo.Text;
                medico.Estado = checkBox1.Checked
                                ? "Activo"
                                : "Inactivo";

                MedicoBL bl = new MedicoBL();

                bl.ValidarMedico(medico);

                MedicoDAL dal = new MedicoDAL();

                int idMedicoGuardado = dal.Guardar(medico);

                CargarMedicos();

                if (idMedico <= 0)
                {
                    MessageBox.Show(
                        "Seleccione primero un médico de la tabla.");
                    return;
                }

                MedicoEspecialidadDAL espDAL = new MedicoEspecialidadDAL();

                MessageBox.Show("Id Médico: " + idMedico + "\nId Especialidad: " + cmbEspecialidad.SelectedValue);

                espDAL.AsignarEspecialidad(idMedico, Convert.ToInt32(cmbEspecialidad.SelectedValue));

                Limpiar();

                MessageBox.Show("Médico guardado correctamente");
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

        private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.RowIndex >= 0)
            {
                idMedico = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["id_medico"].Value);

                txtCedula.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["cedula"].Value.ToString();

                txtNombre.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["nombre"].Value.ToString();

                txtApellido.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["apellido"].Value.ToString();

                txtTelefono.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["telefono"].Value.ToString();

                txtCorreo.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["correo"].Value.ToString();

                object valorEstado = dataGridView1.Rows[e.RowIndex].Cells["estado"].Value;

                if (valorEstado != null && valorEstado != DBNull.Value)
                {
                    string estado = valorEstado.ToString();

                    checkBox1.Checked =
                        estado == "Activo" ||
                        estado == "1" ||
                        estado.ToLower() == "true";
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico();

                medico.IdMedico = idMedico;
                medico.Cedula = txtCedula.Text;
                medico.Nombre = txtNombre.Text;
                medico.Apellido = txtApellido.Text;
                medico.Telefono = txtTelefono.Text;
                medico.Correo = txtCorreo.Text;
                medico.Estado = checkBox1.Checked
                                ? "Activo"
                                : "Inactivo";

                MedicoDAL dal = new MedicoDAL();

                dal.Actualizar(medico);

                CargarMedicos();

                Limpiar();

                MessageBox.Show("Médico actualizado");
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
                if (idMedico == 0)
                {
                    MessageBox.Show("Seleccione un médico");
                    return;
                }

                MedicoDAL dal = new MedicoDAL();

                dal.Eliminar(idMedico);

                CargarMedicos();

                Limpiar();

                MessageBox.Show("Médico eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (idMedico == 0)
                    return;

                MedicoEspecialidadDAL dal = new MedicoEspecialidadDAL();

                dal.AsignarEspecialidad(idMedico, Convert.ToInt32(cmbEspecialidad.SelectedValue));
            }
            catch
            {

            }
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            if (idMedico == 0)
            {
                MessageBox.Show("Seleccione un médico");
                return;
            }

            MedicoEspecialidadDAL dal = new MedicoEspecialidadDAL();

            dal.AsignarEspecialidad(idMedico, Convert.ToInt32(cmbEspecialidad.SelectedValue));

            MessageBox.Show("Especialidad asignada correctamente");
        }
    }
    
}
