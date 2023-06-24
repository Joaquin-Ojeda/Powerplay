using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    internal class Validar
    {
        //Funcion para validar que se ingresen numeros
        public static void soloNumeros(KeyPressEventArgs x)
        {
            if (char.IsDigit(x.KeyChar))
            {
                x.Handled = false;
            }
            else if (char.IsSeparator(x.KeyChar))
            {
                x.Handled = false;
            }
            else if (char.IsControl(x.KeyChar))
            {
                x.Handled = false;
            }
            else
            {
                x.Handled = true;
               //MessageBox.Show("Este campo solo admite números!", "Powerplay", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
