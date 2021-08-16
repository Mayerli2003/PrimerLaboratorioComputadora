using Computadora.Entidades;
using Computadora.Negocio;
using System;

namespace Computadora
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsComputadora clscomputadora = new ClsComputadora();
            NClsComputadora nclscomputadora = new NClsComputadora();

            clscomputadora.Tamañoram = 100;
            nclscomputadora.Nombremicroprocesador = "Intel core 2 DUO";

            Console.WriteLine(nclscomputadora.EncenderComputadora(clscomputadora));
            Console.ReadLine();
        }
    }
}
