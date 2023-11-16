using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventarios_Movil
{
    public partial class FrmAcceso : Form
    {
        cUsuario usuario = new cUsuario();
        public FrmAcceso()
        {
            InitializeComponent();
        }

        private void FrmAcceso_Load(object sender, EventArgs e)
        {
            txtEstab.Focus();
        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void txtEstab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
            {
                e.Handled = true;
                txtUsuario.Focus();
            }
            if(Convert.ToChar(Keys.Escape)==e.KeyChar)
            {
                Application.Exit();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtUsuario.Text.Length > 0)
            {
                e.Handled = true;
                txtUsuario.Enabled = false;
                txtEstab.Enabled = false;
                usuario.usuario = Convert.ToInt16(txtUsuario.Text);
                usuario.estab = txtEstab.Text.Trim();
                if (usuario.encontrar())
                {
                    txtUsuarioNombre.Text = usuario.nombre;
                    txtEstabNombre.Text = usuario.estabNombre;
                    txtPass.Enabled = true;
                    txtPass.Focus();
                }
                else
                {
                    MessageBox.Show("El usuario no existe o no tiene acceso al establecimiento", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtUsuario.Enabled = true;
                    txtEstab.Enabled = true;

                }
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            if(e.KeyChar==Convert.ToChar(Keys.Escape))
            {
                txtUsuario.Enabled = true;
                txtEstab.Enabled = true;
                txtUsuario.Focus();
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPass.Text == usuario.clave)
                {
                    this.Hide();
                    FrmUbicacion f = new FrmUbicacion(usuario);
                    f.Text = "usuario: " + usuario.nombre.Trim() + " | estab: " + usuario.estabNombre.Trim();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtPass.SelectAll();
                }
            }
        }
    }
}