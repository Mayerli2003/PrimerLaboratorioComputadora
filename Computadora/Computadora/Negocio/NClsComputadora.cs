using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computadora.Negocio
{
    class NClsComputadora

    {
        internal string Nombremicroprocesador;

        public String Apagar(ClsComputadora computadora)
        {
            
            
            return "La computadora con un tipo de tarjeta madre " + computadora.Nombreplacamadre + " y con un microprocesador  " + computadora.Nombremicroprocesador + " se esta apagando";


        }

        internal bool Encender(ClsComputadora clscomputadora)
        {
            throw new NotImplementedException();
        }

        public String Almacenar(ClsComputadora computadora)
        {
            
            return "La computadora con un disco duro de" + computadora.Tamañodiscoduro + "GB" + " con un tipo de monitor " + computadora.Monitor + " almacena informacion ";
        }
        public String Volumen(ClsComputadora computadora)
        {
            
            return "La computadora con un microfono " + computadora.Microfono + "y bocinas" + computadora.Bocinas + " tiene un excelente volumen";
        }
        public String EncenderComputadora(ClsComputadora computadora)
        {
            computadora.Tamañoram = 100;
            computadora.Nombremicroprocesador = "Intel core 2 DUO";
            
            return "La computadora con memoria RAM de "+computadora.Tamañoram+" GB  y microprocesador "+computadora.Nombremicroprocesador+" esta encendida";
        }
    }
}

