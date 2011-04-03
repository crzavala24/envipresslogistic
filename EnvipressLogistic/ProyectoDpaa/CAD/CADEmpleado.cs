using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;
using EnvipressLogistic.LogicaNegocio;

namespace EnvipressLogistic.CAD
{
    public class CADEmpleado
    {
        gestorDataBase gestor = new gestorDataBase();
        string sql;
        string tabla = "EMPLEADO";
        string error;

        //Función para insertar un nuevo empleado en nuestra tabla
        public bool InsertarEmpleado(Empleado empleado)
        {
            bool aux = true;

            try
            {
                sql = "INSERT into " + tabla + 
                    "(nif, nombre, apellido, fecha_nac, edad, estado_civil, nacionalidad, provincia, localidad, domicilio, cc, puesto, fecha_alta, fecha_baja) values ('" +
                    empleado.Dni + "','" + empleado.Nombre + "','" + empleado.Apellidos + "'," + empleado.FechaNacimiento + "," +
                    empleado.Edad + ",'" + empleado.EstadoCivil + "','" + empleado.Nacionalidad + "','" + empleado.Provincia + "','" +
                    empleado.Localidad + "','" + empleado.Domicilio + "'," + empleado.CuentaCorriente + ",'" + empleado.Puesto + "'," +
                    empleado.FechaAlta + "," + empleado.FechaBaja + ")";

                gestor.execNonQuery(sql, tabla, error);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                aux = false;
            }

            return aux;
        }

        //Función para modificar un empleado de nuestra base de datos
        public bool ModificarEmpleado(Empleado empleado)
        {
            bool aux = true;

            try
            {
                sql = "UPDATE " + tabla +
                    "SET nombre='" + empleado.Nombre + "', apellido='" + empleado.Apellidos + "', fecha_nac=" +
                    empleado.FechaNacimiento + ", edad=" + empleado.Edad + ", estado_civil='" + empleado.EstadoCivil + "', nacionalidad='" +
                    empleado.Nacionalidad + "', provincia='" + empleado.Provincia + "', localidad='" + empleado.Localidad + "', domicilio='" +
                    empleado.Domicilio + "', cc=" + empleado.CuentaCorriente + ", puesto='" + empleado.Puesto + "', fecha_alta=" +
                    empleado.FechaAlta + ", fecha_baja=" + empleado.FechaBaja + "WHERE nif='" + empleado.Dni + "'";

                gestor.execNonQuery(sql, tabla, error);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                aux = false;
            }

            return aux;
        }

        //Función para eliminar un empleado de la base de datos
        public bool EliminarEmpleado(Empleado empleado)
        {
            bool aux = true;

            try
            {
                sql = "DELETE from " + tabla + " WHERE nif='" + empleado.Dni + "'";
            }
            catch (Exception ex)
            {
                error = ex.Message;
                aux = false;
            }

            return aux;
        }

        //Función que muestra todos los empleados de la base de datos
        public DataSet getDSEmpleados()
        {
            DataSet DSAux = new DataSet();
            try
            {
                tabla = "EMPLEADO";
                sql = "SELECT * from EMPLEADO";
                DSAux = gestor.exec(sql, tabla, error);
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return DSAux;
        }

        //Esta muestra un único Empleado coincidente con el dni
        public DataSet getDSEmpleados(string dni)
        {
            DataSet DSAux = new DataSet();

            try
            {
                tabla = "EMPLEADO";
                sql = "SELECT * from EMPLEADO WHERE nif='" + dni + "'";
                DSAux = gestor.exec(sql, tabla, error);
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return DSAux;
        }

    }
}
