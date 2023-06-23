using System.Drawing.Text;
using TPFinal;
using System;
using System.IO;
using System.Runtime.InteropServices;
using iTextSharp.tool.xml.html.head;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Windows.Forms;

namespace TPFinal
{
    public partial class Form1 : Form, IArchivo
    {
        public List<Usuario> lUsuarios;
        public Form1()
        {
            InitializeComponent();
            this.lUsuarios = new List<Usuario>();
            timer1.Start();
        }
        //Fragmento de codigo para poder mantener click y mover la ventana del sistema
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //contador para terminar el timer cuando llegue a 100
        int contador = 0;

        private void botonLogin_Click(object sender, EventArgs e)
        {
            llenarLista();
            var login = new Login(lUsuarios, this);
            login.Show();
            this.Visible = false;
        }

        private void botonSingin_Click(object sender, EventArgs e)
        {
            llenarLista();
            var signin = new Signin(this);
            signin.Show();
            this.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?","Powerplay", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(resultado == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            contador += 1;
            if (contador == 100)
            {
                timer1.Stop();
            }
        }

        //funcion para crear el objeto Usuario
        public void convertirDatos(string user)
        {
            string[] usuario;
            usuario = user.Split(';');
            Usuario usuario1 = new Usuario(usuario[0], usuario[1], usuario[2], usuario[3], usuario[4], usuario[5]);
            if (existeUsuario(usuario1.getNombre())==false)
            {
                if (usuario1.getId() <= 10)
                {
                    Vip usuarioVip = new Vip(0.10, usuario[0], usuario[1], usuario[2], usuario[3], usuario[4], usuario[5]);
                    lUsuarios.Add(usuarioVip);
                }
                else
                {
                    lUsuarios.Add(usuario1);
                }
            }

        }

        //meter los Usuario en la lista de usuarios
        public void llenarLista()
        {
            foreach (string item in leerArchivo())
            {
                convertirDatos(item);
            }
        }

        //Carga del .txt con los usuarios registrados
        public string[] leerArchivo()
        {
            string x = "Usuarios.txt";
            TextReader leer = new StreamReader($"Users\\{x}");
            string[] usuariosCadenas = leer.ReadToEnd().Split('/');
            leer.Close();
            return usuariosCadenas;
        }

        //Confirma si el usuario existe en la lista
        public bool existeUsuario(string nombre)
        {
            return lUsuarios.Exists(x => x.getNombre() == nombre);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}