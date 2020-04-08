using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FacadeDemo.models
{
    public class Encriptacion
    {
        private string _texto;

        public Encriptacion(string texto)
        {
            _texto = texto;
        }

        public string ConvertirMD5()
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(_texto);
            byte[] outputBytes = md5.ComputeHash(inputBytes);
            string salida = string.Empty;
            for (var i = 0; i < outputBytes.Length; i++)
            {
                salida+=outputBytes[i].ToString("X2");
            }
            return salida;
        }

        public string SHA1()
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(_texto);
            byte[] outputBytes = HashAlgorithm.Create("SHA1").ComputeHash(inputBytes);
            string salida = string.Empty;
            for (var i = 0; i < outputBytes.Length; i++)
            {
                salida += outputBytes[i].ToString("X2");
            }
            return salida;
        }

        public string SHA256()
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(_texto);
            byte[] outputBytes = new SHA256Managed().ComputeHash(inputBytes);
            string salida = string.Empty;
            for (var i = 0; i < outputBytes.Length; i++)
            {
                salida += outputBytes[i].ToString("X2");
            }
            return salida;
        }


    }
}
