using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    internal class Venta
    {
        internal static int contador;
        internal int id;
        internal List<Detalle> juegos;
        internal DateTime fecha;
        internal Usuario usuario;
        internal double total;
        internal string nombre;
        internal string apellido;
        internal string direccion;
        internal string postal;
        internal string localidad;
        internal string pais;
        internal string telefono;

        public Venta(List<Detalle> juegos,DateTime fecha,Usuario usuario,double total,string nombre,string apellido,string direccion,string postal,string localidad,string pais,string telefono)
        {
            contador++;
            this.juegos = juegos;
            this.fecha = fecha;
            this.usuario = usuario;
            this.total = total;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.postal = postal;
            this.localidad = localidad;
            this.pais = pais;
            this.telefono = telefono;
            this.id = contador;
        }

        public virtual string crearCadena()
        {
            string cadena;
            string lineaSeparadora = "--------------------------------------------------------\n";
            string inicio = "Factura \n";
            string comprador="Usuario: "+this.usuario.getNombre()+"\n";
            string titulo = "Datos de facturación: \n";
            string datosFacturacion= "Nombre: "+this.nombre+"\n"+"Apellido: "+this.apellido+ "\n" + "Pais: "+this.pais+"\n"+"Localidad: "+this.localidad+ "\n"+"Código postal: "+this.postal+ "\n"+"Direccion: "+this.direccion+ "\n"+"Telefono: "+this.telefono+ "\n"+lineaSeparadora;

            string productos = "Productos: \n";
            foreach (Detalle det in juegos.ToList())
            {
                productos += "Juego "+det.getNombre()+ "\n"+"Cantidad: "+det.getCantidad()+ "\n"+"Precio unitario: "+det.getPrecio()+ "\n"+"Precio total: "+ (det.getPrecio()*det.getCantidad())+ "\n"+ lineaSeparadora;
            }
            cadena = inicio + comprador + titulo + datosFacturacion + productos +"Total: "+this.total + "\n" + lineaSeparadora+ "\n Fin de venta \n"+lineaSeparadora;

            return cadena;
        }
        public void escribirTxt()
        {
            StreamWriter agregar = File.AppendText("Ventas\\Ventas.txt");
            string cadena = crearCadena();
            agregar.Write(cadena);
            agregar.Close();
        }

    }
}
