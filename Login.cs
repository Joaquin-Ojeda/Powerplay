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
using System.Runtime.ExceptionServices;

namespace TPFinal
{
    public partial class Login : Form
    {
        public List<Usuario> lUsuarios;
        public Form1 formAnterior;
        public Login(List<Usuario> usuarios, Form1 formAnterior)
        {
            InitializeComponent();
            this.lUsuarios = usuarios;
            timer1.Start();
            this.formAnterior = formAnterior;
            textBoxUsuario.PlaceholderText = "Ingrese usuario...";
            textBoxPassword.PlaceholderText = "Ingrese constraseña...";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        int contador = 0;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsuario.Text!="" || textBoxPassword.Text!="")
                {
                    if (formAnterior.existeUsuario(textBoxUsuario.Text))
                    {
                        Usuario usuario = lUsuarios.Find(x => x.getNombre() == textBoxUsuario.Text);
                        if (usuario.getPassword() == textBoxPassword.Text)
                        {
                            var banner = new Banner(usuario, formAnterior);
                            banner.Show();
                            this.Close();
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Usuario/Contraseña incorretos!", "Powerplay", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            formAnterior.Opacity = 0;
            formAnterior.Visible = true;
            formAnterior.timer1.Start();
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
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
