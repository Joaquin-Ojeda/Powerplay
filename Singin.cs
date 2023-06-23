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
    public partial class Signin : Form
    {
        public Form1 formAnterior;
        public Signin(Form1 formAnterior)
        {
            InitializeComponent();
            this.formAnterior = formAnterior;
            timer1.Start();
            textBoxUsuario.PlaceholderText = "Ingrese usuario...";
            textBoxPassword.PlaceholderText = "Ingrese constraseña...";
            textBoxCorreo.PlaceholderText = "Ingrese correo...";
            textBoxDia.PlaceholderText = "dd";
            textBoxMes.PlaceholderText = "mm";
            textBoxAnio.PlaceholderText = "aaaa";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        int contador = 0;
        //Funcion para validar los datos ingresados
        public void validarCampos()
        {
            if (textBoxCorreo.Text.Contains("@") == false || textBoxCorreo.Text.Contains(".com") == false)
            {
                throw new ApplicationException();
            }
            if (int.Parse(textBoxDia.Text) > 31 || int.Parse(textBoxDia.Text) <= 0 || int.Parse(textBoxMes.Text) > 12 || int.Parse(textBoxMes.Text) <= 0 || int.Parse(textBoxAnio.Text) >= DateTime.Now.Year)
            {
                throw new Exception();
            }
            if (textBoxUsuario.Text == "" || textBoxPassword.Text == "" || textBoxDia.Text == "" || textBoxMes.Text == "" || textBoxAnio.Text == "" || textBoxCorreo.Text == "")
            {
                throw new Exception();
            }
        }
        //Boton registrar
        private void botonSingin_Click(object sender, EventArgs e)
        {
            try
            {
                if (formAnterior.existeUsuario(textBoxUsuario.Text))
                {
                    throw new ArgumentException();
                }
                else
                {
                    validarCampos();
                    StreamWriter agregar = File.AppendText("Users\\Usuarios.txt");
                    string cadena = "/" + textBoxUsuario.Text + ";" + textBoxAnio.Text + ";" + textBoxMes.Text + ";" + textBoxDia.Text + ";" + textBoxPassword.Text + ";" + textBoxCorreo.Text;
                    agregar.Write(cadena);
                    agregar.Close();
                    MessageBox.Show("Usuario creado", "Powerplay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formAnterior.Opacity = 0;
                    formAnterior.Visible = true;
                    formAnterior.timer1.Start();
                    this.Close();
                }
            }
            catch (ApplicationException)
            {
                MessageBox.Show("El correo debe ser valido (debe tener @ y .com)", "Powerplay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Nombre de usuario no disponible", "Powerplay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor ingrese datos válidos", "Powerplay", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAnterior.Opacity = 0;
            formAnterior.Visible = true;
            formAnterior.timer1.Start();
            this.Close();
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
