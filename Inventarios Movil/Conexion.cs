using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Inventarios_Movil
{
    class Conexion
    {
        public static SqlConnection conectar() 
        {
            try 
            {
                SqlConnection cn = new SqlConnection();
                //cn.ConnectionString = "Server=server-cln,14335;Database=bdrotativos;User Id=eliasb;Password=23032004;";
                cn.ConnectionString = "Server=sqltest,1433;Database=bdrotativos;User Id=sa;Password=03170754;";
                cn.Open();
                return cn;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
    }
}
