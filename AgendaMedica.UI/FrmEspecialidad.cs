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
    public partial class FrmEspecialidad : Form
    {
        public FrmEspecialidad()
        {
            InitializeComponent();
        }

        private int idEspecialidad = 0;

        private void CargarEspecialidades()
        {
            EspecialidadDAL dal = new EspecialidadDAL();
            dataGridView1.DataSource = dal.MostrarEspecialidades();
        }
        private void Limpiar()
        {
            idEspecialidad = 0;

            txtEspecialidad.Clear();
            txtDescripcion.Clear();
            txtEspecialidad.Focus();
        }
        private void FrmEspecialidad_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidad especialidad =
                    new Especialidad();

                especialidad.NombreEspecialidad =
                    txtEspecialidad.Text;

                especialidad.Descripcion =
                    txtDescripcion.Text;

                EspecialidadBL bl =
                    new EspecialidadBL();

                bl.ValidarEspecialidad(
                    especialidad);

                EspecialidadDAL dal =
                    new EspecialidadDAL();

                dal.Guardar(especialidad);

                CargarEspecialidades();

                Limpiar();

                MessageBox.Show(
                    "Especialidad guardada correctamente");
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
                idEspecialidad =
                    Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["id_especialidad"].Value);

                txtEspecialidad.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["nombre_especialidad"]
                    .Value.ToString();

                txtDescripcion.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["descripcion"]
                    .Value.ToString();
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidad especialidad =
                    new Especialidad();

                especialidad.IdEspecialidad =
                    idEspecialidad;

                especialidad.NombreEspecialidad =
                    txtEspecialidad.Text;

                especialidad.Descripcion =
                    txtDescripcion.Text;

                EspecialidadDAL dal =
                    new EspecialidadDAL();

                dal.Actualizar(especialidad);

                CargarEspecialidades();

                Limpiar();

                MessageBox.Show(
                    "Especialidad actualizada");
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
                if (idEspecialidad == 0)
                {
                    MessageBox.Show(
                        "Seleccione una especialidad");
                    return;
                }

                EspecialidadDAL dal =
                    new EspecialidadDAL();

                dal.Eliminar(idEspecialidad);

                CargarEspecialidades();

                Limpiar();

                MessageBox.Show(
                    "Especialidad eliminada");
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
    }
}
