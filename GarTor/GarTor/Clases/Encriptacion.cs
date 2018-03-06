﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarTor.Clases
{
    /// Esta clase contiene funciones para encriptar/desencriptar
    /// El ser estática no es necesario instanciar un objeto para 
    /// usar las funciones Encriptar y DesEncriptar
    public static class Encriptacion
    {

        /// Encripta una cadena
        public static string Encriptar(this string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(this string _cadenaAdesencriptar)
        {
            Console.WriteLine("AQUIIIIIIIIIIIIIIIIIIII:"+_cadenaAdesencriptar);
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result =Convert.ToString(System.Text.Encoding.Unicode.GetString(decryted));
            return result;
        }
    }
}
