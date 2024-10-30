using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafos
{
    internal class Nodo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Point Posicion { get;set; }


        public Nodo(int id, string nombre, Point posicion)
        {
            Id = id;
            Nombre = nombre;
            Posicion = posicion;
        }
    }
}
