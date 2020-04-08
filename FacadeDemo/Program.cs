using FacadeDemo.models;
using System;

namespace FacadeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaGenerador generador = new FachadaGenerador();
            Console.WriteLine($"Contraseña sugerida: {generador.ObtenerContraseniaSugerida()}");            
        }
    }
}
