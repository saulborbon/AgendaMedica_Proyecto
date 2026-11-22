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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        private int idUsuario = 0;

        private void CargarRoles()
        {
            RolDAL dal = new RolDAL();

            DataTable dt = dal.MostrarRoles();

            comboBox1.DataSource = dt;

            comboBox1.DisplayMember = "nombre_rol";

            comboBox1.ValueMember = "id_rol";
        }
        private void CargarUsuarios()
        {
            UsuarioDAL dal = new UsuarioDAL();

            dataGridView1.DataSource = dal.MostrarUsuarios();
        }
        private void Limpiar()
        {
            idUsuario = 0;

            txtUsuario.Clear();

            txtContra.Clear();

            checkBox1.Checked = true;
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarUsuarios();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                usuario.IdRol = Convert.ToInt32(comboBox1.SelectedValue);

                usuario.Username = txtUsuario.Text;

                usuario.Password = txtContra.Text;

                usuario.Estado = checkBox1.Checked
                                 ? "Activo"
                                 : "Inactivo";

                UsuarioBL bl = new UsuarioBL();

                bl.ValidarUsuario(usuario);

                UsuarioDAL dal = new UsuarioDAL();

                dal.Guardar(usuario);

                CargarUsuarios();

                Limpiar();

                MessageBox.Show("Usuario guardado");
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
                idUsuario =
                    Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["id_usuario"].Value);

                comboBox1.SelectedValue =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["id_rol"].Value;

                txtUsuario.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["username"].Value.ToString();

                txtContra.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["password"].Value.ToString();

                checkBox1.Checked =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["estado"].Value.ToString() == "Activo";
            }
            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                usuario.IdUsuario = idUsuario;

                usuario.IdRol = Convert.ToInt32(comboBox1.SelectedValue);

                usuario.Username = txtUsuario.Text;

                usuario.Password = txtContra.Text;

                usuario.Estado = checkBox1.Checked
                                 ? "Activo"
                                 : "Inactivo";

                UsuarioDAL dal = new UsuarioDAL();

                dal.Actualizar(usuario);

                CargarUsuarios();

                Limpiar();

                MessageBox.Show("Usuario actualizado");
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
                if (idUsuario == 0)
                {
                    MessageBox.Show("Seleccione un usuario");
                    return;
                }

                UsuarioDAL dal = new UsuarioDAL();

                dal.Eliminar(idUsuario);

                CargarUsuarios();

                Limpiar();

                MessageBox.Show("Usuario eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
