using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafos
{
    internal class Arista
    {
        public Nodo Nodo1 { get; set; }
        public Nodo Nodo2 { get; set; }
        public int Peso { get; set; }


        public Arista(Nodo nodo1, Nodo nodo2, int peso) 
        { 
           Nodo1 = nodo1;
           Nodo2 = nodo2;
           Peso = peso;    
        }

    }
}
