using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EnvipressLogistic
{
    public class Validacion
    {
        //FUNCIONES DE COMPROBACION DE DATOS CORRECTOS

        //Funcion que comprueba que el texto es solo alfanumérico
        public static bool TextoOk(string texto)
        {
            string patron = @"^[A-Za-z0-9 ]+$";
            bool textoOk = true;

            if (!Regex.Match(texto, patron).Success)
                textoOk = false;
            return textoOk;
        }

        //Funcion que comprueba si un CIF es correcto
        public static bool CifOk(string cif)
        {
            string patron = @"^\D{1}\d{8}$";
            bool cifOk = true;

            if (!Regex.Match(cif, patron).Success)
                cifOk = true;
            return cifOk;
        }

        //Funcion que comprueba si un dni es correcto
        public static bool DniOk(string dn)
        {
            string patron = @"^\d{8}\D{1}$";
            bool dniOk = true;

            if (!Regex.Match(dn, patron).Success)
                dniOk = false;
            return dniOk;
        }

        //Funcion que te devuelve true si el tamaño del string y el tamaño pasado coinciden
        public static bool TamanyoString(string dn, int tam)
        {
            bool ok = false;
            if (dn.Length >= tam)
                ok = true;
            return ok;
        }


        //Funcion que comprueba si una cuenta es correcta
        public static bool CuentaOk(string cuenta)
        {
            string patron = @"^\d{20}$";
            if (!Regex.Match(cuenta, patron).Success)
                return false;
            return true;
        }

        //Funcion que comprueba si un telefono es correcto
        public static bool TelfOk(string telf)
        {
            bool telfOk = true;
            string patron = @"^\d{9}$";
            if (!Regex.Match(telf, patron).Success)
                telfOk = false;
            return telfOk;
        }

        //Funcion que devuelve true si el string pasado no esta vacio
        public static bool EsVacioString(string st)
        {
            bool vacio = false;
            if (st == "")
                vacio = true;
            return vacio;
        }

        //Funcion que valida un Email utilizando expresiones regulares
        public static bool CorreoOk(string email)
        {
            bool correcto = true;
            string expReg = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" +
                           @"0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" +
                           @"[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
            System.Text.RegularExpressions.Match match = Regex.Match(email.Trim(), expReg, RegexOptions.IgnoreCase);
            if (!match.Success)
                correcto = false;
            return correcto;
        }

        public static bool PassOk(string s1, string s2)
        {
            bool iguales = false;
            if ((s1.Equals(s2)) && s1 != "" && s2 != "")
                if (s1.Length >= 6)
                    iguales = true;
            return iguales;
        }

        public static bool LongPassOk(string s1)
        {
            bool ok = false;
            if (s1.Length >= 6)
                ok = true;
            return ok;
        }

        //Funcion que devuelve true si el string pasado es un numero correcto
        public static bool esNumero(string cadena)
        {
            string patron = @"^[0-9 ]+$";
            if (!Regex.Match(cadena, patron).Success)
                return false;
            else
                return true;
        }

        //Funcion que devuelve true si  el codigo postal es un codigo correcto
        public static bool CPOk(string cadena)
        {
            string patron = @"^\d{5}$";
            if (!Regex.Match(cadena, patron).Success)
                return false;
            else
                return true;
        }
    }
}
