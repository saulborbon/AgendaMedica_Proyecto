using AgendaMedica.DAL.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AgendaMedica.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void CargarUsuarios()
        {
            comboBox1.Items.Clear();

            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = "SELECT username FROM usuarios WHERE estado = 'Activo'";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["username"].ToString());
                }
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();

                using (MySqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();

                    string sql =
                    @"SELECT r.nombre_rol FROM usuarios u INNER JOIN roles r ON u.id_rol = r.id_rol
                    WHERE u.username = @usuario AND u.password = @password";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@usuario", comboBox1.Text);

                    cmd.Parameters.AddWithValue("@password", txtContra.Text);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        string rol = resultado.ToString();

                        FrmPrincipal frm = new FrmPrincipal(rol);

                        frm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}

