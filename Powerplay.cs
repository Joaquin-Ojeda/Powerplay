using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TPFinal
{
    public partial class Powerplay : Form, IArchivo
    {
        Usuario usuario;
        Form1 formInicio;
        //lista que no se modificara nunca, solo cuando se crea el formulario
        List<Juego> juegos;
        //lista de juegos que permite su modificacion para mostrar segun categoria o busqueda
        List<Juego> subJuegos;
        //lista para el carrito
        List<Juego> listaCarrito;
        public Powerplay(Usuario usuario, Form1 formInicio)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.formInicio = formInicio;
            juegos = new List<Juego>();
            subJuegos = new List<Juego>();
            listaCarrito = new List<Juego>();
        }
        //Fragmento de codigo para poder mantener click y mover la ventana del sistema
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Powerplay_Load(object sender, EventArgs e)
        {
            labelBienvenido.Text = "Bienvenido \n" + usuario.getNombre().ToUpper();
            llenarLista();
            subJuegos = juegos.ToList();
            mostrarJuegos(juegos);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Powerplay", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                formInicio.Close();
            }
            
        }

        //Leer archivos y devolver la cadena separada por / en un array
        public string[] leerArchivo()
        {
            TextReader leer = new StreamReader("Juegos\\Juegos.txt");
            string[] result = leer.ReadToEnd().Split('/');
            leer.Close();
            return result;
        }

        //Por cada elemento en el array creamos un nuevo objeto Juego
        public void convertirDatos(string item)
        {
            string[] aux = item.Split(';');
            string nombre = aux[0];
            double precio = double.Parse(aux[1]);
            string[] categoria = aux[2].Split(',');
            int cantidad = int.Parse(aux[3]);
            int pegi = int.Parse(aux[4]);
            Image portada = Image.FromFile($"Portadas\\{nombre}.jpg");
            List<string> listaCategoria = new List<string>();

            for (int i = 0; i < categoria.Length; i++)
            {
                listaCategoria.Add(categoria[i]);
            }

            Juego juego = new Juego(nombre, precio, listaCategoria, cantidad, pegi, portada);

            this.juegos.Add(juego);
        }
        public void llenarLista()
        {
            foreach (string item in leerArchivo())
            {
                convertirDatos(item);
            }
        }

        //funcion para mostrar los primeros juegos
        public void mostrarJuegos(List<Juego> listaJuegos)
        {
            int indice = int.Parse(labelIndice.Text);
            int inf = (indice - 1) * 6;
            Juego juego;
            if (inf < listaJuegos.Count())
            {
                juego = listaJuegos[inf];
                portada1.BackgroundImage = juego.getPortada();
                nombre1.Text = juego.getNombre();
                precio1.Text = "$" + juego.getPrecio().ToString();
                portada1.Visible = true;
                nombre1.Visible = true;
                precio1.Visible = true;
                comprar1.Visible = true;
                inf++;
            }
            else
            {
                portada1.Visible = false;
                nombre1.Visible = false;
                precio1.Visible = false;
                comprar1.Visible = false;
            }
            if (inf < listaJuegos.Count())
            {
                juego = listaJuegos[inf];
                portada2.BackgroundImage = juego.getPortada();
                nombre2.Text = juego.getNombre();
                precio2.Text = "$" + juego.getPrecio().ToString();
                portada2.Visible = true;
                nombre2.Visible = true;
                precio2.Visible = true;
                comprar2.Visible = true;
                inf++;
            }
            else
            {
                portada2.Visible = false;
                nombre2.Visible = false;
                precio2.Visible = false;
                comprar2.Visible = false;
            }
            if (inf < listaJuegos.Count())
            {
                juego = listaJuegos[inf];
                portada3.BackgroundImage = juego.getPortada();
                nombre3.Text = juego.getNombre();
                precio3.Text = "$" + juego.getPrecio().ToString();
                portada3.Visible = true;
                nombre3.Visible = true;
                precio3.Visible = true;
                comprar3.Visible = true;
                inf++;
            }
            else
            {
                portada3.Visible = false;
                nombre3.Visible = false;
                precio3.Visible = false;
                comprar3.Visible = false;
            }
            if (inf < listaJuegos.Count())
            {
                juego = listaJuegos[inf];
                portada4.BackgroundImage = juego.getPortada();
                nombre4.Text = juego.getNombre();
                precio4.Text = "$" + juego.getPrecio().ToString();
                portada4.Visible = true;
                nombre4.Visible = true;
                precio4.Visible = true;
                comprar4.Visible = true;
                inf++;
            }
            else
            {
                portada4.Visible = false;
                nombre4.Visible = false;
                precio4.Visible = false;
                comprar4.Visible = false;
            }

            if (inf < listaJuegos.Count())
            {
                juego = listaJuegos[inf];
                portada5.BackgroundImage = juego.getPortada();
                nombre5.Text = juego.getNombre();
                precio5.Text = "$" + juego.getPrecio().ToString();
                portada5.Visible = true;
                nombre5.Visible = true;
                precio5.Visible = true;
                comprar5.Visible = true;
                inf++;
            }
            else
            {
                portada5.Visible = false;
                nombre5.Visible = false;
                precio5.Visible = false;
                comprar5.Visible = false;
            }
            if (inf < listaJuegos.Count())
            {
                juego = listaJuegos[inf];
                portada6.BackgroundImage = juego.getPortada();
                nombre6.Text = juego.getNombre();
                precio6.Text = "$" + juego.getPrecio().ToString();
                portada6.Visible = true;
                nombre6.Visible = true;
                precio6.Visible = true;
                comprar6.Visible = true;
            }
            else
            {
                portada6.Visible = false;
                nombre6.Visible = false;
                precio6.Visible = false;
                comprar6.Visible = false;
            }
        }
        //Manejo de botones de pagina siguiente y anterior
        private void button13_Click(object sender, EventArgs e)
        {
            int indice = int.Parse(labelIndice.Text);
            if (indice * 6 < subJuegos.Count())
            {
                indice++;
                labelIndice.Text = indice.ToString();
            }
            mostrarJuegos(subJuegos);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int indice = int.Parse(labelIndice.Text);
            if (indice > 1)
            {
                indice--;
                labelIndice.Text = indice.ToString();
            }
            mostrarJuegos(subJuegos);
        }
        //Cambio de estilo de botones categoria
        private void botonATP_Click(object sender, EventArgs e)
        {
            if (checkBoxATP.Checked == false)
            {
                botonATP.BackColor = Color.FromArgb(15, 47, 73);
                botonATP.ForeColor = Color.White;
                botonATP.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 63, 83);
                checkBoxATP.Checked = !checkBoxATP.Checked;
                checkear();
            }
            else
            {
                botonATP.BackColor = Color.FromArgb(59, 145, 213);
                botonATP.ForeColor = Color.Black;
                botonATP.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 173, 224);
                checkBoxATP.Checked = !checkBoxATP.Checked;
                checkear();
            }

        }

        private void botonRetro_Click(object sender, EventArgs e)
        {
            if (checkBoxRetro.Checked == false)
            {
                botonRetro.BackColor = Color.FromArgb(15, 47, 73);
                botonRetro.ForeColor = Color.White;
                botonRetro.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 63, 83);
                checkBoxRetro.Checked = !checkBoxRetro.Checked;
                checkear();
            }
            else
            {
                botonRetro.BackColor = Color.FromArgb(59, 145, 213);
                botonRetro.ForeColor = Color.Black;
                botonRetro.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 173, 224);
                checkBoxRetro.Checked = !checkBoxRetro.Checked;
                checkear();
            }
        }

        private void botonAventura_Click(object sender, EventArgs e)
        {
            if (checkBoxAventura.Checked == false)
            {
                botonAventura.BackColor = Color.FromArgb(15, 47, 73);
                botonAventura.ForeColor = Color.White;
                botonAventura.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 63, 83);
                checkBoxAventura.Checked = !checkBoxAventura.Checked;
                checkear();
            }
            else
            {
                botonAventura.BackColor = Color.FromArgb(59, 145, 213);
                botonAventura.ForeColor = Color.Black;
                botonAventura.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 173, 224);
                checkBoxAventura.Checked = !checkBoxAventura.Checked;
                checkear();
            }
        }

        private void botonTerror_Click(object sender, EventArgs e)
        {
            if (checkBoxTerror.Checked == false)
            {
                botonTerror.BackColor = Color.FromArgb(15, 47, 73);
                botonTerror.ForeColor = Color.White;
                botonTerror.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 63, 83);
                checkBoxTerror.Checked = !checkBoxTerror.Checked;
                checkear();
            }
            else
            {
                botonTerror.BackColor = Color.FromArgb(59, 145, 213);
                botonTerror.ForeColor = Color.Black;
                botonTerror.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 173, 224);
                checkBoxTerror.Checked = !checkBoxTerror.Checked;
                checkear();
            }
        }

        private void botonAccion_Click(object sender, EventArgs e)
        {
            if (checkBoxAccion.Checked == false)
            {
                botonAccion.BackColor = Color.FromArgb(15, 47, 73);
                botonAccion.ForeColor = Color.White;
                botonAccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 63, 83);
                checkBoxAccion.Checked = !checkBoxAccion.Checked;
                checkear();
            }
            else
            {
                botonAccion.BackColor = Color.FromArgb(59, 145, 213);
                botonAccion.ForeColor = Color.Black;
                botonAccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 173, 224);
                checkBoxAccion.Checked = !checkBoxAccion.Checked;
                checkear();
            }
        }
        //Funcion para checkear que categorias estan seleccionadas
        public void checkear()
        {
            if (checkBoxAccion.Checked || checkBoxATP.Checked || checkBoxAventura.Checked || checkBoxRetro.Checked || checkBoxTerror.Checked)
            {
                var listaAux = new List<Juego>();
                var listaCategorias = new List<string>();
                if (checkBoxAccion.Checked)
                {
                    listaCategorias.Add("accion");
                }
                if (checkBoxAventura.Checked)
                {
                    listaCategorias.Add("aventura");
                }
                if (checkBoxRetro.Checked)
                {
                    listaCategorias.Add("retro");
                }
                if (checkBoxTerror.Checked)
                {
                    listaCategorias.Add("terror");
                }
                if (checkBoxATP.Checked)
                {
                    listaCategorias.Add("atp");
                }

                foreach (Juego item in juegos.ToList())
                {
                    bool coincide = true;
                    foreach (string categoria in listaCategorias)
                    {
                        if (item.getCategoria().Find(cat => cat == categoria) == null)
                        {
                            coincide = false;
                        }
                    }
                    if (coincide)
                    {
                        listaAux.Add(item);
                    }
                }

                subJuegos = listaAux;
                labelIndice.Text = "1";
                mostrarJuegos(subJuegos);
            }
            else
            {
                subJuegos = juegos;
                mostrarJuegos(subJuegos);
            }
        }
        //programando el carrito
        //Funcion para comprobar edad
        public bool comprobarEdad(int pegi)
        {
            return usuario.validarEdad(pegi);
        }
        //Botones de compra
        private void comprar1_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = nombre1.Text;
                if (listaCarrito.Find(juego => juego.getNombre() == titulo) == null)
                {
                    Juego x = juegos.Find(juego => juego.getNombre() == titulo);
                    if (x.disponible())
                    {
                        if (comprobarEdad(x.getPegi()))
                        {
                            listaCarrito.Add(x);
                            MessageBox.Show("Juego agregado al carrito!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                else
                {
                    MessageBox.Show("El juego ya esta en el carrito!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Juego sin stock", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Este juego no esta habilitado para su edad", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comprar2_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = nombre2.Text;
                if (listaCarrito.Find(juego => juego.getNombre() == titulo) == null)
                {
                    Juego x = juegos.Find(juego => juego.getNombre() == titulo);
                    if (x.disponible())
                    {
                        if (comprobarEdad(x.getPegi()))
                        {
                            listaCarrito.Add(x);
                            MessageBox.Show("Juego agregado al carrito!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                else
                {
                    MessageBox.Show("El juego ya esta en el carrito!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Juego sin stock", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Este juego no esta habilitado para su edad", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void comprar3_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = nombre3.Text;
                if (listaCarrito.Find(juego => juego.getNombre() == titulo) == null)
                {
                    Juego x = juegos.Find(juego => juego.getNombre() == titulo);
                    if (x.disponible())
                    {
                        if (comprobarEdad(x.getPegi()))
                        {
                            listaCarrito.Add(x);
                            MessageBox.Show("Juego agregado al carrito!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                else
                {
                    MessageBox.Show("El juego ya esta en el carrito!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Juego sin stock", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Este juego no esta habilitado para su edad", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void comprar4_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = nombre4.Text;
                if (listaCarrito.Find(juego => juego.getNombre() == titulo) == null)
                {
                    Juego x = juegos.Find(juego => juego.getNombre() == titulo);
                    if (x.disponible())
                    {
                        if (comprobarEdad(x.getPegi()))
                        {
                            listaCarrito.Add(x);
                            MessageBox.Show("Juego agregado al carrito!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                else
                {
                    MessageBox.Show("El juego ya esta en el carrito!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Juego sin stock", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Este juego no esta habilitado para su edad", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comprar5_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = nombre5.Text;
                if (listaCarrito.Find(juego => juego.getNombre() == titulo) == null)
                {
                    Juego x = juegos.Find(juego => juego.getNombre() == titulo);
                    if (x.disponible())
                    {
                        if (comprobarEdad(x.getPegi()))
                        {
                            listaCarrito.Add(x);
                            MessageBox.Show("Juego agregado al carrito!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                else
                {
                    MessageBox.Show("El juego ya esta en el carrito!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Juego sin stock", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Este juego no esta habilitado para su edad", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comprar6_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = nombre6.Text;
                if (listaCarrito.Find(juego => juego.getNombre() == titulo) == null)
                {
                    Juego x = juegos.Find(juego => juego.getNombre() == titulo);
                    if (x.disponible())
                    {
                        if (comprobarEdad(x.getPegi()))
                        {
                            listaCarrito.Add(x);
                            MessageBox.Show("Juego agregado al carrito!", "Carrito",    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }  
                }
                else
                {
                    MessageBox.Show("El juego ya esta en el carrito!", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Juego sin stock", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Este juego no esta habilitado para su edad", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Boton carrito
        private void botonCarrito_Click(object sender, EventArgs e)
        {
            var carrito = new Carrito(this, listaCarrito);
            this.Visible = false;
            carrito.Show();
        }
        //Boton buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = textBoxBuscador.Text;
                busqueda.ToLower();
                subJuegos = juegos.FindAll(juego => juego.getNombre().ToLower().Contains(busqueda));
                if (subJuegos.Count() == 0)
                {
                    throw new Exception();
                }
                else
                {
                    mostrarJuegos(subJuegos);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Juego no encontrado", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Get de usuario para el proximo formulario
        public Usuario getUsuario()
        {
            return this.usuario;
        }
    }
}
