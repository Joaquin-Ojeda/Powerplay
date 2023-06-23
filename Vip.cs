using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace TPFinal
{
    internal class Vip : Usuario
    {
        private double descuento;
        public Vip(double descuento, string nombre, string anio, string mes, string dia, string password, string mail) : base (nombre, anio, mes, dia, password, mail)
        {
            this.descuento = descuento;
        }

        public double calcularDescuento(double total)
        {
            double desc = total * this.descuento;
            return total - desc;
        }
    }
}
