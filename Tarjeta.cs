using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Reflection.Metadata;

namespace TPFinal
{
    public partial class Tarjeta : Form
    {
        Carrito carrito;
        List<Detalle> detalles;
        Usuario usuario;
        double total;
        public Tarjeta(Carrito carrito, Usuario usuario)
        {
            InitializeComponent();
            this.carrito = carrito;
            this.detalles = new List<Detalle>();
            this.usuario = usuario;
            this.total = 0;
        }
        //Funcion para boton generar factura
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                validarDatos();
                crearPDF();
                VentaTarjeta venta = new VentaTarjeta(detalles, DateTime.Now, usuario, total, textNombre.Text, textApellido.Text, textDireccion.Text, textPostal.Text, textLocalidad.Text, textPais.Text, textTelefono.Text, textTarjeta.Text, textMes.Text, textAnio.Text, textCodigo.Text);
                venta.escribirTxt();
                MessageBox.Show("Factura lista ¡Gracias por su compra!", "Powerplay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carrito.limpiarCarrito();
                carrito.getCatalogo().Visible = true;
                this.Close();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Por favor complete todos los campos requeridos", "Powerplay", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no son validos!", "Powerplay", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Funcion para validar que los input no esten vacios
        public void validarDatos()
        {
            if (textNombre.Text == "" || textApellido.Text == "" || textPais.Text == "" || textLocalidad.Text == "" || textPostal.Text == "" || textLocalidad.Text == "" || textDireccion.Text == "" || textTelefono.Text == "")
            {
                throw new ArgumentException();
            }
            if (int.Parse(textPostal.Text) <= 0 || int.Parse(textMes.Text) <= 0 || int.Parse(textMes.Text) > 12 || int.Parse(textAnio.Text) < 23 || int.Parse(textAnio.Text) <= 0 || int.Parse(textCodigo.Text) <= 0 || int.Parse(textCodigo.Text) > 999 || long.Parse(textTarjeta.Text) <= 0 || long.Parse(textTelefono.Text) <= 0)
            {
                throw new Exception();
            }
        }
        //Funcion para crear el pdf
        public void crearPDF()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            DateTime hoy = DateTime.Now;
            guardar.FileName = "Factura_" + hoy.Day.ToString() + "_" + hoy.Month.ToString() + "_" + hoy.Year.ToString() + "_" + hoy.Hour + "_" + hoy.Minute + "_" + hoy.Second;
            guardar.Filter = "Pdf Files|*.pdf";

            //Estilos de fuente
            BaseFont fuente = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, true);
            iTextSharp.text.Font titulo = new iTextSharp.text.Font(fuente, 16f, iTextSharp.text.Font.BOLD, BaseColor.BLUE);
            iTextSharp.text.Font subTitulo = new iTextSharp.text.Font(fuente, 14f, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            //Termina estilos

            //Creacion del PDF
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase("Powerplay \n", titulo));
                    pdfDoc.Add(new Phrase("\n"));
                    pdfDoc.Add(new Phrase("Factura \n", subTitulo));
                    pdfDoc.Add(new Phrase("\n"));
                    pdfDoc.Add(new Phrase("Información de facturación \n \n", subTitulo));
                    pdfDoc.Add(new Phrase("Nombre y apellido: " + textNombre.Text + "   " + textApellido.Text + "\n"));
                    pdfDoc.Add(new Phrase("País: " + textPais.Text + "\n"));
                    pdfDoc.Add(new Phrase("Localidad: " + textLocalidad.Text + "\n"));
                    pdfDoc.Add(new Phrase("Dirección: " + textDireccion.Text + "\n"));
                    pdfDoc.Add(new Phrase("Código postal: " + textPostal.Text + "\n"));
                    pdfDoc.Add(new Phrase("Teléfono: " + textTelefono.Text + "\n \n"));
                    pdfDoc.Add(new Phrase("Productos:  \n", subTitulo));

                    cargarDatos(pdfDoc, subTitulo);

                    pdfDoc.Add(new Phrase("\n"));
                    pdfDoc.Add(new Phrase("\n"));

                    total = double.Parse(carrito.getTotal().Text);

                    pdfDoc.Add(new Phrase("Total : $ " + total.ToString() + " \n", subTitulo));
                    //Calcula el descuento si el usuario es Vip
                    if (usuario.getId() < 10)
                    {
                        Vip vip = new Vip(0.10, usuario.getNombre(), usuario.getAnio(), usuario.getMes(), usuario.getDia(), usuario.getPassword(), usuario.getMail());
                        total = vip.calcularDescuento(total);
                        pdfDoc.Add(new Phrase("Total con descuento : $ " + total.ToString(), subTitulo));
                    }
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
        //Funcion para cargar el grid en el pdf
        public void cargarDatos(iTextSharp.text.Document pdfDoc, iTextSharp.text.Font subTitulo)
        {
            //Obtengo el grid y lo recorro para crear las lineas del PDF
            DataGridView listaCarrito = carrito.getCarrito();
            for (int i = 0; i < listaCarrito.Rows.Count; i++)
            {
                DataGridViewRow fila = listaCarrito.Rows[i];
                string nombre = fila.Cells["Juego"].Value.ToString();
                string cantidad = fila.Cells["Cantidad"].Value.ToString();
                string precio = fila.Cells["Precio"].Value.ToString();
                pdfDoc.Add(new Phrase(nombre + "          x" + cantidad + "\n", subTitulo));
                pdfDoc.Add(new Phrase("$ " + precio + " c/u" + "\n"));

                //Creo el detalle por cada producto del carrito y lo agrego a la lista
                Detalle det = new Detalle(nombre, double.Parse(precio), int.Parse(cantidad));
                detalles.Add(det);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea volver al carrito?", "Powerplay", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                carrito.Visible = true;
                this.Close();
            }
        }
        //Cada vez que se aprete una tecla que no sea un numero dentro de estos campos se enviara una advertencia
        private void textPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
    }
}
