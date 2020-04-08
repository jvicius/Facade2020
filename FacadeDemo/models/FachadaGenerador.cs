using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDemo.models
{
    public class FachadaGenerador
    {
        private Cadena _cadena;
        private Encriptacion encriptacion;

        public string ObtenerContraseniaSugerida()
        {
            var salida = string.Empty;

            Diccionario randomDic = (Diccionario) GenerarNumero(1, 8);

            string texto = randomDic.ToString();

            var ramdomCadena = GenerarNumero(1, 4);
            _cadena = new Cadena(texto);
            switch(ramdomCadena)
            {
                case 1: salida =_cadena.EliminarNumeros(); break;
                case 2: salida = _cadena.InvertirCadena(); break;
                case 3: salida = _cadena.SoloVocalesAMayuscula(); break;
                case 4: salida = _cadena.SoloVocalesAMinuscula(); break;
            }

            var ramdomencriptacion = GenerarNumero(1, 3);
            encriptacion = new Encriptacion(salida);
            switch (ramdomencriptacion)
            {
                case 1: salida = encriptacion.ConvertirMD5(); break;
                case 2: salida = encriptacion.SHA1(); break;
                case 3: salida = encriptacion.SHA256(); break;                
            }

            return salida;
        }

        private int GenerarNumero(int minimo, int maximo)
        {
            return new Random(DateTime.Now.Millisecond).Next(minimo, maximo);
        }
    }
}
