using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Odbc;
using System.Data.Common;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EnvipressLogistic
{
    public sealed class Conexion
    {
        //Patrón singleton con la cadena
        private static readonly Conexion conexion = new Conexion();
        private string cadenaConexion = "";

        private Conexion()
        {
            //Ruta de la cadena de conexión a la BD
            cadenaConexion = @"DataSource=.\SQLEXPRESS;AtachDBFilename=C:\ProyectoDPAA\EnvipressLogisticBD.mdf;Integrated Security=True;Connect Timeaut=30;User Instance=True";
        }

        public static Conexion Conectar
        {
            get { return conexion; }
        }

        public string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
