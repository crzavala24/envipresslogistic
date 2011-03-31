using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnvipressLogistic.LogicaNegocio;

namespace EnvipressLogistic.CAD
{
    public class CADEmpleado
    {
        gestorDataBase gestor = new gestorDataBase();
        string sql;
        string tabla = "EMPLEADO";
        string error;

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
            }
            catch (Exception ex)
            {
                error = ex.Message;
                aux = false;
            }

            return aux;
        }
    }
}
