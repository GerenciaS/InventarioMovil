using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Inventarios_Movil
{
    public class cUsuario
    {
        private int _usuario;
        private string _nombre;
        private string _clave;
        private string _status;
        private string _estab;
        private string _estabNombre;
        private string _dbestab;

        public Int32 usuario 
        {
            set { _usuario = value;}
            get {return _usuario;}
        }
        public string nombre 
        {
            set { _nombre = value; }
            get { return _nombre; }
        }
        public string clave 
        {
            set { _clave = value; }
            get { return _clave; }
        }
        public string status 
        {
            set { _status = value; }
            get { return _status; }
        }
        public string estab 
        {
            set { _estab = value; }
            get { return _estab; }
        }
        public string estabNombre 
        {
            set { _estabNombre=value; }
            get { return _estabNombre; }
        }
        public string dbEstab 
        {
            set { _dbestab = value; }
            get { return _dbestab;}
        }
        public cUsuario() { }

        public cUsuario(int pUsuario, string pNombre, string pClave, string pStatus) 
        {
            this._usuario = pUsuario;
            this._nombre = pNombre;
            this._clave = pClave;
            this._status = pStatus;
        }
        public Boolean encontrar() 
        {
            try 
            {
                SqlConnection cn = Conexion.conectar();
                
                SqlCommand comand = new SqlCommand("SP_BUSCAR_USUARIO", cn);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@Usuario", this._usuario);
                comand.Parameters.AddWithValue("@Establecimiento", this._estab);

                //SqlDataAdapter da = new SqlDataAdapter(comand);
                //DataTable dr = new DataTable();
                //da.Fill(dr);
                SqlDataReader dr = comand.ExecuteReader();
                
                //SqlConnection cn = Conexion.conectar();
                //SqlCommand comando = new SqlCommand();
                //comando.Connection = cn;
                //comando.CommandText = "select usuarios.usuario,usuarios.nombre,usuarios.clave,usuarios.status,establecimientos_usuario.cod_estab,establecimientos.nombre,establecimientos.DB "
                //+ "from usuarios inner join opciones_usuario on usuarios.usuario=opciones_usuario.usuario "
                //+ "inner join establecimientos_usuario on usuarios.usuario=establecimientos_usuario.usuario "
                //+ "inner join establecimientos on establecimientos_usuario.cod_estab=establecimientos.cod_estab "
                //+ "where usuarios.usuario=@usuario and opciones_usuario.opcion='F017' and establecimientos_usuario.cod_estab=@estab and establecimientos_usuario.acceso='1'";
                //comando.Parameters.AddWithValue("@usuario", this._usuario);
                //comando.Parameters.AddWithValue("@estab", this._estab);
                //SqlDataReader dr = comando.ExecuteReader();
              
                while(dr.Read())
                {
                    this._nombre = dr.GetString(1);
                    this._clave = dr.GetString(2);
                    this._status = dr.GetString(3);
                    this._estab = dr.GetString(4);
                    this._estabNombre = dr.GetString(5);
                    this._dbestab = dr.GetString(6);
                }
                if(dr.IsClosed==false){dr.Close();}
                if (cn.State.ToString() == "Open") { cn.Close(); }
                return true;
            }
            catch { return false; }
        }
    }
}
