using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvipressLogistic.LogicaNegocio
{
    class ENAlmacen
    {
        //Campos privados para mantener el estado de la Entidad Almacen.
        private int numAlmacen;
        private string nombreAlmacen;
        private string domicilioAlmacen;
        private string provinciaAlamcen;
        private string localidadAlmacen;
        private string codigoPostalAlmacen;
        private string estadoAlmacen;
        private float capacidadAlmacen;
        private float capacidadOcupadaAlmacen;
        private float capacidadLibreAlmacen;

        //Propiedades publicas para exponer el estado de los Almacenes.

        public int NumAlmacen
        {
            get { return numAlmacen; }
            set { numAlmacen = value; }
        }

        public string NombreAlmacen
        {
            get { return nombreAlmacen; }
            set { nombreAlmacen = value; }
        }

        public string DomicilioAlmacen
        {
            get { return domicilioAlmacen; }
            set { domicilioAlmacen = value; }
        }

        public string ProvinciaAlmacen
        {
            get { return provinciaAlamcen; }
            set { provinciaAlamcen = value; }
        }

        public string LocalidadAlmacen
        {
            get { return localidadAlmacen; }
            set { localidadAlmacen = value; }
        }

        public string CodigoPostalAlmacen
        {
            get { return codigoPostalAlmacen; }
            set { codigoPostalAlmacen = value; }
        }

        public string EstadoAlamcen
        {
            get { return estadoAlmacen; }
            set { estadoAlmacen = value; }
        }

        public float CapacidadAlamcen
        {
            get { return capacidadAlmacen; }
            set { capacidadAlmacen = value; }
        }

        public float CapacidadOcupadaAlmacen
        {
            get { return capacidadOcupadaAlmacen; }
            set { capacidadOcupadaAlmacen = value; }
        }

        public float CapacidadLibreAlmacen
        {
            get { return CapacidadLibreAlmacen; }
            set { capacidadLibreAlmacen = value; }
        }

        public void NuevoAlmacen(string nom, string dom, string pro, string loc, string codPos, string est, float cap, float capOcu, float capLib)
        {
            ENAlmacen Almacen;

            


        }
    }
}
