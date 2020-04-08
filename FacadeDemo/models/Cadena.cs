using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDemo.models
{
    public class Cadena
    {
        private string _texto;

        public Cadena(string texto)
        {
            _texto = texto;
        }

        public string SoloVocalesAMayuscula()
        {
            var temp = _texto;
            var salida = string.Empty;
            if(string.IsNullOrEmpty(temp)) return string.Empty;

            for (var i = 0; i < temp.Length; i++)
            {
                if (temp[i] == 'a' || temp[i] == 'e' || temp[i] == 'i' || temp[i] == 'o' || temp[i] == 'u')
                {
                    salida += temp[i].ToString().ToUpper();
                }
                else
                {
                    salida += temp[i].ToString().ToLower();
                }
            }

            return salida;
        }

        public string SoloVocalesAMinuscula()
        {
            var temp = _texto;
            var salida = string.Empty;
            if (string.IsNullOrEmpty(temp)) return string.Empty;

            for (var i = 0; i < temp.Length; i++)
            {
                if (temp[i] == 'a' || temp[i] == 'e' || temp[i] == 'i' || temp[i] == 'o' || temp[i] == 'u')
                {
                    salida += temp[i].ToString().ToLower();
                }
                else
                {
                    salida += temp[i].ToString().ToUpper();
                }
            }

            return salida;
        }


        public string EliminarNumeros()
        {
            var temp = _texto;
            var salida = string.Empty;
            if (string.IsNullOrEmpty(temp)) return string.Empty;

            for (var i = 0; i < temp.Length; i++)
            {
                if (!char.IsDigit(temp[i]))
                {
                    salida += temp[i].ToString();
                }                
            }
            return salida;
        }

        public string InvertirCadena()
        {
            var temp = _texto;
            var salida = string.Empty;
            if (string.IsNullOrEmpty(temp)) return string.Empty;

            for(var i = temp.Length-1; i>=0; i--)
            {
                salida += temp[i];
            }
            return salida;
        }
    }
}
