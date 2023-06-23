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
    public partial class Banner : Form
    {
        private Usuario usuario;
        Form1 formInicio;
        public Banner(Usuario usuario, Form1 formInicio)
        {
            InitializeComponent();
            this.timer1.Start();
            this.usuario = usuario;
            this.formInicio = formInicio;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                var powerplay = new Powerplay(usuario, formInicio);
                powerplay.Show();
                this.Close();
            }
        }

        private void Banner_Load(object sender, EventArgs e)
        {
            label2.Text = this.usuario.getNombre().ToUpper();
        }
    }
}
