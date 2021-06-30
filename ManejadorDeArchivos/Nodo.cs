using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorDeArchivos
{
    class Nodo
    {
        string ruta;
        string descripcion;

        public Nodo(string name, string descripcion)
        {
            this.ruta = name;
            this.descripcion = descripcion;
        }

        public string Ruta { get => ruta; set => ruta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
