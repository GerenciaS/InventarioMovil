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
    public partial class FrmCaptura : Form
    {
        cUsuario usuario;
        string conteo;
        string ubicacion;
        string[] registro = new string[6];
        int registros;
        public FrmCaptura()
        {
            InitializeComponent();
        }
        public FrmCaptura(cUsuario pUsuario, string pConteo, string pUbicacion)
        {
            InitializeComponent();
            usuario = pUsuario;
            conteo = pConteo;
            ubicacion = pUbicacion;
        }
        private void FrmCaptura_Load(object sender, EventArgs e)
        {
            SqlConnection cn = Conexion.conectar();
            SqlCommand comando = new SqlCommand("Select count(*) as regs from conteos where cod_estab=@estab and ubicacion=@ubicacion",cn);
            comando.Parameters.AddWithValue("@estab",usuario.estab);
            comando.Parameters.AddWithValue("@ubicacion",ubicacion);
            registros =  Convert.ToInt32( comando.ExecuteScalar());
            lblRegistros.Text = registros.ToString() + " registros en la ubicacion";
        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void cmdTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                SqlConnection cn = Conexion.conectar();
                try
                {
                    lblProucto.Text = "";                    
                    SqlCommand comando = new SqlCommand("select prodestab.cod_prod,prodestab.codigo_barras_pieza as barras,prodestab.descripcion,prodestab.costo,prodestab.precio "
                    + " from prodestab left join barras_adicionales on prodestab.cod_prod=barras_adicionales.cod_prod where prodestab.cod_estab=@estab and (prodestab.cod_prod=@prod or prodestab.codigo_barras_pieza=@prod)", cn);
                    comando.Parameters.AddWithValue("@estab", usuario.estab);
                    comando.Parameters.AddWithValue("@prod", txtProducto.Text.Trim());
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = comando;
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow fila in dt.Rows)
                        {
                            registro[0]=usuario.estab.Trim();
                            registro[1]=fila["cod_prod"].ToString().Trim();
                            registro[2]= ubicacion.Trim();
                            registro[3]= "";
                            registro[4]=DateTime.Now.ToString("yyyyMMdd");
                            registro[5]=fila["barras"].ToString().Trim();
                            lblProucto.Text = fila["descripcion"].ToString() + "Costo:" + fila["costo"].ToString() + " Precio:" + fila["precio"].ToString();
                        }
                    }
                    else
                    {
                        comando.CommandText = "select prodestab.cod_prod,case when barras_adicionales.codigo_barras_pieza='' then barras_adicionales.codigo_barras_unidad else barras_adicionales.codigo_barras_pieza end as barras, prodestab.descripcion,prodestab.costo,prodestab.precio "
                        + " from prodestab left join barras_adicionales on prodestab.cod_prod=barras_adicionales.cod_prod where prodestab.cod_estab=@estab and (barras_adicionales.codigo_barras_pieza=@prod "
                        + " or barras_adicionales.codigo_barras_unidad=@prod)";
                        dt.Rows.Clear();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow fila in dt.Rows)
                            {
                                registro[0] = usuario.estab.Trim();
                                registro[1] = fila["cod_prod"].ToString().Trim();
                                registro[2] = ubicacion.Trim();
                                registro[3] = "";
                                registro[4] = DateTime.Now.ToString("yyyyMMdd");
                                registro[5] = fila["barras"].ToString().Trim();
                                lblProucto.Text = fila["descripcion"].ToString() + " Costo:" + fila["costo"].ToString() + " Precio" + fila["precio"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado");
                        }
                    }
                    if (lblProucto.Text != "")
                    {
                        txtCantidad.Enabled = true;
                        txtCantidad.Focus();
                    }
                    if (cn.State.ToString() == "Open") { cn.Close(); }
                }
                catch (Exception ex) 
                {
                    if (cn.State.ToString() == "Open") { cn.Close(); }
                    MessageBox.Show(ex.Message);
                }                
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {                
                try 
                {
                    SqlConnection cn = Conexion.conectar();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = cn;
                    switch (conteo)
                    {
                        case "0":
                            comando.CommandText = "Insert into conteos(cod_estab,cod_prod,ubicacion,conteo1,conteo2,codigo_barras)"
                            + " Values('" + registro[0].ToString() + "','" + registro[1].ToString() + "','" + registro[2].ToString() + "'," + txtCantidad.Text.Trim() + ",0,'" + registro[5].ToString() + "')";
                            break;
                        case "1":
                            comando.CommandText = "Insert into conteos(cod_estab,cod_prod,ubicacion,conteo1,conteo2,codigo_barras)"
                            + " Values('" + registro[0].ToString() + "','" + registro[1].ToString() + "','" + registro[2].ToString() + "',0," + txtCantidad.Text.Trim() + ",'" + registro[5].ToString() + "')";
                            break;
                    }
                    comando.ExecuteNonQuery();
                    registros++;
                    lblRegistros.Text = registros.ToString() + " Registros en la ubicacion";
                    txtProducto.Focus();
                    txtProducto.SelectAll();
                    txtCantidad.Text = "";
                    txtCantidad.Enabled = false;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}