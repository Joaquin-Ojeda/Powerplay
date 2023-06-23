using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    internal class Detalle
    {
        string nombre;
        double precio;
        int cantidad;
        
        public Detalle(string nombre, double precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public string getNombre()
        {
            return nombre;
        }
        public double getPrecio()
        {
            return precio;
        }
        public int getCantidad()
        {
            return cantidad;
        }
    }
}
