using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computadora.Negocio
{
    class NClsComputadora

    {
        public String Apagar(ClsComputadora computadora)
        {
            
            return "La computadora con tipo de " + computadora.Camara + "con un microprocesador  " + computadora.Nombremicroprocesador + " se esta apagando";


        }
        public String Almacenar(ClsComputadora computadora)
        {
            
            return "La computadora con un disco duro de" + computadora.Tamañodiscoduro + "GB" + " con un tipo de monitor " + computadora.Monitor + " almacena informacion ";
        }
        public String Volumen(ClsComputadora computadora)
        {
            
            return "La computadora con un microfono " + computadora.Microfono + "y bocinas" + computadora.Bocinas + " tiene un excelente volumen";
        }
        
    }
}

