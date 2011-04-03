using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnvipressLogistic.CAD;
using EnvipressLogistic;

namespace EnvipressLogistic.LogicaNegocio
{
    public class Empleado
    {
        CADEmpleado cadEmpleado = new CADEmpleado();

        private string dni;
        private string nombre;
        private string apellidos;
        private DateTime fecha_nac;
        private int edad;
        private string estado_civil;
        private string nacionalidad;
        private string provincia;
        private string localidad;
        private string domicilio;
        private long cc;
        private string puesto;
        private DateTime fecha_alta;
        private DateTime fecha_baja;
        private int telefono;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fecha_nac; }
            set { fecha_nac = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string EstadoCivil
        {
            get { return estado_civil; }
            set { estado_civil = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public long CuentaCorriente
        {
            get { return cc; }
            set { cc = value; }
        }

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public DateTime FechaAlta
        {
            get { return fecha_alta; }
            set { fecha_alta = value; }
        }

        public DateTime FechaBaja
        {
            get { return fecha_baja; }
            set { fecha_baja = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public bool NuevaAlta(string dni, string nombre, string apellidos, DateTime fecha_nac, int edad, string estado_civil, string nacionalidad, string localidad, string provincia, string domicilio, long cc, string puesto, DateTime fecha_alta, DateTime fecha_baja)
        {
            throw new System.NotImplementedException();
        }

        public bool Baja(string dni)
        {
            throw new System.NotImplementedException();
        }

        public bool Modificar(string dni, string nombre, string apellidos, DateTime fecha_nac, int edad, string estado_civil, string nacionalidad, string localidad, string provincia, string domicilio, long cc, string puesto, DateTime fecha_alta, DateTime fecha_baja)
        {
            throw new System.NotImplementedException();
        }

        //Muestra todos los empleados
        public DataSet getDSEmpleados()
        {
            DataSet DSAux = new DataSet();
            try
            {
                DSAux = cadEmpleado.getDSEmpleados();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return DSAux;
        }

        //Muestra el empleado que coincida con el dni
        public DataSet getDSEmpleados(string dni)
        {
            DataSet DSAux = new DataSet();
            try
            {
               DSAux = cadEmpleado.getDSEmpleados(dni);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return DSAux;
        }

        //Insertar un nuevo Empleado
        public bool InsertarEmpleado()
        {
            CADEmpleado nEmpleado = new CADEmpleado();
            bool correct = false;
            try
            {
                correct = nEmpleado.InsertarEmpleado(this);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return correct;

        }

        public bool ModificarEmpleado()
        {
            CADEmpleado mEmpleado = new CADEmpleado();
            bool correct = false;
            try
            {
               correct = mEmpleado.ModificarEmpleado(this);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return correct;
        }

        public bool EliminarEmpleado()
        {
            CADEmpleado eEmpleado = new CADEmpleado();
            bool correct = false;

            try
            {
                correct = eEmpleado.EliminarEmpleado(this);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            return correct;
        }
    }
}
