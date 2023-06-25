using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodosYÁrbolesBinarios
{
    internal class Nodo
    {
        public string Nombre { get; set; } // Propiedad.

        // Constructor que solamente nos pide el nombre.

        public Nodo(string nombre)
        {
            Nombre = nombre;
        }

        // Posicionaremos por las ramas izquierda y derecha.

        public Nodo Izquierda { get; set; } // Propiedad rama izquierda.
        public Nodo Derecha { get; set; } // Propiedad rama derecha.
    
    }
}
