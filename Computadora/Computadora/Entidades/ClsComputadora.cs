using System;
using System.Collections.Generic;
using System.Text;

namespace Computadora.Entidades
{
    class ClsComputadora
    {
        private int tamañomemoria;
        private int tamañoram;
        private String nombremicroprocesador;
        private int tamañodiscoduro;
        private String teclado;
        private String nombreplacamadre;
        private String monitor;
        private String bocinas;
        private String camara;
        private String microfono;
        private String mouse;

        public int Tamañomemoria { get => tamañomemoria; set => tamañomemoria = value; }
        public int Tamañoram { get => tamañoram; set => tamañoram = value; }
        public string Nombremicroprocesador { get => nombremicroprocesador; set => nombremicroprocesador = value; }
        public int Tamañodiscoduro { get => tamañodiscoduro; set => tamañodiscoduro = value; }
        public string Teclado { get => teclado; set => teclado = value; }
        public string Nombreplacamadre { get => nombreplacamadre; set => nombreplacamadre = value; }
        public string Monitor { get => monitor; set => monitor = value; }
        public string Bocinas { get => bocinas; set => bocinas = value; }
        public string Camara { get => camara; set => camara = value; }
        public string Microfono { get => microfono; set => microfono = value; }
        public string Mouse { get => mouse; set => mouse = value; }
    }
}
