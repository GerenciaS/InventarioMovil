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
    public partial class FrmUbicacion : Form
    {
        cUsuario usuario = new cUsuario();
        public FrmUbicacion()
        {
            InitializeComponent();
        }
        public FrmUbicacion(cUsuario pUsuario)
        {
            InitializeComponent();
            usuario = pUsuario;
        }
        private void FrmUbicacion_Load(object sender, EventArgs e)
        {

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn = Conexion.conectar();
                SqlCommand comando = new SqlCommand();
                comando.Connection = cn;
                MessageBox.Show(usuario.estab);
                comando.CommandText = "Select ubicacion from ubicaciones where cod_estab=@estab";
                comando.Parameters.AddWithValue("@estab", usuario.estab);
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    cmbUbicacion.Items.Add(dr.GetString(0));
                }
                if (dr.IsClosed == false) { dr.Close(); }
                if (cn.State.ToString() == "Open") { cn.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdComenzar_Click(object sender, EventArgs e)
        {           
            
            if(rbExistente.Checked)
            {
                if (cmbUbicacion.Text != "" && cmbConteo.Text != "")
                {
                    FrmCaptura f = new FrmCaptura(usuario, Convert.ToString(cmbConteo.SelectedIndex), cmbUbicacion.Text);
                    f.ShowDialog();
                    return;
                }
            }
            if(rbNuevo.Checked)
            {
                if(txtUbicacion.Text!="" && cmbConteo.Text!="")
                {
                    SqlConnection cn = Conexion.conectar();
                    SqlCommand comando = new SqlCommand("insert into ubicaciones(cod_estab,ubicacion)values(@estab,@ubicacion)", cn);
                    comando.Parameters.AddWithValue("@estab",usuario.estab);
                    comando.Parameters.AddWithValue("@ubicacion",txtUbicacion.Text.Trim());
                    comando.ExecuteNonQuery();
                    if (cn.State.ToString() == "Open") { cn.Close(); }
                    FrmCaptura f = new FrmCaptura(usuario, Convert.ToString(cmbConteo.SelectedIndex), cmbUbicacion.Text);
                    f.ShowDialog();
                    return;
                }
            }
            
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbExistente_Click(object sender, EventArgs e)
        {
            if (rbExistente.Checked == true) 
            {
                cmbUbicacion.Enabled = true;
                cmdCargar.Enabled = true;
                txtUbicacion.Enabled = false;
            }
        }

        private void rbNuevo_Click(object sender, EventArgs e)
        {
            if (rbNuevo.Checked == true) 
            {
                cmbUbicacion.Enabled = false;
                cmdCargar.Enabled = false;
                txtUbicacion.Enabled = true;
            }
        }
    }
}