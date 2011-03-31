using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using EnvipressLogistic;

namespace EnvipressLogistic
{
    public class gestorDataBase
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlConnection conexion = new SqlConnection();
        public static DataTable dataTable;
        private string ruta;

        public gestorDataBase()
        {
            dataTable = new DataTable();
            ruta = Conexion.Conectar.CadenaConexion;
        }

        public DataSet exec(string sql, string tabla, string error)
        {
            DataSet bdvirtual = new DataSet();
            try
            {
                conexion = new SqlConnection(ruta);
                dataAdapter = new SqlDataAdapter(sql, conexion);
                dataAdapter.Fill(bdvirtual, tabla);
                dataTable = bdvirtual.Tables[tabla];
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                conexion.Close();
            }
            return bdvirtual;
        }

        public DataAdapter getDataAdapter(string sql)
        {
            try
            {
                conexion = new SqlConnection(ruta);
                dataAdapter = new SqlDataAdapter(sql, conexion);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
            return dataAdapter;
        }

        //Para ejecutar consultas (insert, delete y update)
        public bool execNonQuery(string sql, string tabla, string error)
        {
            DataSet bdvirtual = new DataSet();
            bool correcto = false;
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                con = new SqlConnection(ruta);
                comando = new SqlCommand(sql, con);
                con.Open();
                comando.ExecuteNonQuery();
                dataAdapter = new SqlDataAdapter(sql, con);
                dataAdapter.Fill(bdvirtual, tabla);
                dataTable = bdvirtual.Tables[tabla];
                con.Close();
                correcto = true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                conexion.Close();
            }
            return correcto;
        }
    }
}
