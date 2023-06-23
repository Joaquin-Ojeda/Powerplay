using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public class Juego
    {
        private static int id=0;
        private string nombre;
        private double precio;
        private List<string> categoria;
        private int cantidad;
        private int pegi;
        private Image portada;

        public Juego(string nombre,double precio, List<string> categoria, int cantidad, int pegi, Image portada)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
            this.cantidad = cantidad;
            this.pegi = pegi;
            id++;
            this.portada = portada;
        }

        public bool disponible()
        {
            return cantidad > 0;
        }
        public bool ATP()
        {
            return pegi == 0;
        }

        public string getNombre()
        {
            return this.nombre;
        }
        public void setNombre(string nom)
        {
            this.nombre = nom;
        }
        public double getPrecio()
        {
            return this.precio;
        }
        public void setNombre(double pre)
        {
            this.precio = pre;
        }
        public List<string> getCategoria()
        {
            return this.categoria;
        }
        public void setCategoria(List<string> cat)
        {
            this.categoria = cat;
        }
        public int getCantidad()
        {
            return this.cantidad;
        }
        public void setCantidad(int cat)
        {
            this.cantidad = cat;
        }
        public int getPegi()
        {
            return this.pegi;
        }
        public void setPegi(int pe)
        {
            this.pegi = pe;
        }
        public Image getPortada()
        {
            return this.portada;
        }
    }
}
