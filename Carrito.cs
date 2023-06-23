using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal
{
    public partial class Carrito : Form
    {
        List<Juego> compra;
        Powerplay catalogo;
        int posicion;
        double total;
        public Carrito(Powerplay catalogo, List<Juego> compra)
        {
            InitializeComponent();
            this.compra = compra;
            this.catalogo = catalogo;
            this.posicion = 0;
            total = 0;
        }
        //on load se carga el carrito al Grid
        private void Carrito_Load(object sender, EventArgs e)
        {
            total = 0;
            foreach (Juego j in compra)
            {
                int indiceFila = gridCarrito.Rows.Add();
                DataGridViewRow fila = gridCarrito.Rows[indiceFila];
                fila.Cells["Juego"].Value = j.getNombre();
                fila.Cells["Cantidad"].Value = "1";
                fila.Cells["Precio"].Value = j.getPrecio();
            }
            calcularTotal();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea volver al catalogo?", "Powerplay", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                catalogo.Visible = true;
                this.Close();
            }
        }

        //click al boton de sacar del carrito
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = gridCarrito.Rows[posicion].Cells["Juego"].Value.ToString();
                gridCarrito.Rows.RemoveAt(posicion);
                Juego game = compra.Find(juego => juego.getNombre() == nombre);
                compra.Remove(game);
                int x = gridCarrito.Rows.Count;
                if (posicion >= x)
                {
                    posicion--;
                }
                calcularTotal();
            }
            catch (Exception)
            {
                MessageBox.Show("Carrito vacio!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //click al boton limpiar carrito
        private void button3_Click(object sender, EventArgs e)
        {
            limpiarCarrito();
        }
        //Funcion para marcar la posicion de la celda que se clickea en el grid
        private void gridCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = e.RowIndex;
        }
        //Boton de Confirmar
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (compra.Count==0)
                {
                    throw new ArgumentException();
                }
                if (tarjeta.Checked)
                {
                    Tarjeta tar = new Tarjeta(this, catalogo.getUsuario());
                    this.Visible = false;
                    tar.Show();
                }
                else
                {
                    if (efectivo.Checked)
                    {
                        Efectivo ef = new Efectivo(this, catalogo.getUsuario());
                        this.Visible = false;
                        ef.Show();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Carrito vacio!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un metodo de pago", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Funcion cuando cambia alguna celda del grid (en este caso la categoria)
        private void gridCarrito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calcularTotal();
        }
        //Calcula el total del grid
        private void calcularTotal()
        {
            total = 0;
            for (int i = 0; i < gridCarrito.Rows.Count; i++)
            {
                DataGridViewRow fila = gridCarrito.Rows[i];
                if (fila.Cells["Cantidad"].Value != null && fila.Cells["Precio"].Value != null)
                {
                    try
                    {
                        string nombre = fila.Cells["Juego"].Value.ToString();
                        Juego game = compra.Find(game => game.getNombre() == nombre);
                        int stock = game.getCantidad();
                        int cantidad = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                        double precio = double.Parse(fila.Cells["Precio"].Value.ToString());
                        if(comprobarCantidad(cantidad, stock)==false)
                        {
                            fila.Cells["Cantidad"].Value = "1";
                            throw new Exception(stock.ToString());
                        }
                        total += cantidad * precio;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("El juego se encuentra sin stock suficiente para esta solicitud. Stock disponible: "+e.Message, "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            labelTotal.Text = total.ToString();
        }
        //Funcion para comprobar si la cantidad elegida no supera el stock
        public bool comprobarCantidad(int cant, int stock)
        {
            return stock-cant >= 0;
        }
        public DataGridView getCarrito()
        {
            return gridCarrito;
        }
        public Label getTotal()
        {
            return labelTotal;
        }
        //Funcion para limpiar el carrito
        public void limpiarCarrito()
        {
            for (int i = gridCarrito.Rows.Count - 1; i >= 0; i--)
            {
                gridCarrito.Rows.RemoveAt(i);
            }
            calcularTotal();
            compra.Clear();
        }

        public Powerplay getCatalogo()
        {
            return this.catalogo;
        }
    }
}
