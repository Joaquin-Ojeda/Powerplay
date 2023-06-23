using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    internal class VentaTarjeta : Venta
    {
        string tarjeta;
        string mes;
        string anio;
        string codigo;

        public VentaTarjeta(List<Detalle> juegos, DateTime fecha, Usuario usuario, double total, string nombre, string apellido, string direccion, string postal, string localidad, string pais, string telefono, string tarjeta,string mes, string anio, string codigo) : base(juegos,fecha,usuario,total,nombre,apellido,direccion,postal,localidad,pais,telefono)
        {
            this.tarjeta = tarjeta;
            this.mes = mes;
            this.anio = anio;
            this.codigo = codigo;
        }
         private string agregarDatosTarjeta()
        {
            return "Nro tarjeta: " + tarjeta+"\nVencimiento: "+mes+"/"+anio+"\nCodigo: "+codigo+"\n";
        }
        public override string crearCadena()
        {
            string cadena;
            string lineaSeparadora = "--------------------------------------------------------\n";
            string inicio = "Factura \n";
            string comprador = "Usuario: " + this.usuario.getNombre() + "\n";
            string titulo = "Datos de facturación: \n";
            string datosFacturacion = "Nombre: " + this.nombre + "\n" + "Apellido: " + this.apellido + "\n" + "Pais: " + this.pais + "\n" + "Localidad: " + this.localidad + "\n" + "Código postal: " + this.postal + "\n" + "Direccion: " + this.direccion + "\n" + "Telefono: " + this.telefono + "\n";
            string datosTarjeta = lineaSeparadora + "Datos tarjeta: \n" + agregarDatosTarjeta()+lineaSeparadora;

            string productos = "Productos: \n";
            foreach (Detalle det in juegos.ToList())
            {
                productos += "Juego " + det.getNombre() + "\n" + "Cantidad: " + det.getCantidad() + "\n" + "Precio unitario: " + det.getPrecio() + "\n" + "Precio total: " + (det.getPrecio() * det.getCantidad()) + "\n" + lineaSeparadora;
            }
            cadena = inicio + comprador + titulo + datosFacturacion +datosTarjeta+ productos + "Total: " + this.total+"\n" + lineaSeparadora + "\n Fin de venta \n" + lineaSeparadora;

            return cadena;
        }
    }
}
