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
    public partial class FrmRol : Form
    {
        public FrmRol()
        {
            InitializeComponent();
        }
        private int idRol = 0;

        private void CargarRoles()
        {
            RolDAL dal = new RolDAL();

            dataGridView1.DataSource =
                dal.MostrarRoles();
        }
        private void Limpiar()
        {
            idRol = 0;

            txtRol.Clear();

            txtRol.Focus();
        }
        private void FrmRol_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Rol rol = new Rol();

                rol.NombreRol =
                    txtRol.Text;

                RolBL bl = new RolBL();

                bl.ValidarRol(rol);

                RolDAL dal = new RolDAL();

                dal.Guardar(rol);

                CargarRoles();

                Limpiar();

                MessageBox.Show(
                    "Rol guardado correctamente");
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
                idRol = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["id_rol"].Value);

                txtRol.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["nombre_rol"]
                    .Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Rol rol = new Rol();

                rol.IdRol = idRol;
                rol.NombreRol = txtRol.Text;

                RolDAL dal = new RolDAL();

                dal.Actualizar(rol);

                CargarRoles();

                Limpiar();

                MessageBox.Show(
                    "Rol actualizado");
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
                if (idRol == 0)
                {
                    MessageBox.Show(
                        "Seleccione un rol");

                    return;
                }

                RolDAL dal = new RolDAL();

                dal.Eliminar(idRol);

                CargarRoles();

                Limpiar();

                MessageBox.Show(
                    "Rol eliminado");
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
