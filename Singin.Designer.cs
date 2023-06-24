namespace TPFinal
{
    partial class Signin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            labelSingin = new Label();
            textBoxAnio = new TextBox();
            textBoxMes = new TextBox();
            textBoxDia = new TextBox();
            labelFecha = new Label();
            textBoxCorreo = new TextBox();
            labelCorreo = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxUsuario = new TextBox();
            labelUsuario = new Label();
            botonSingin = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelSingin
            // 
            labelSingin.AutoSize = true;
            labelSingin.BackColor = Color.Transparent;
            labelSingin.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelSingin.ForeColor = SystemColors.ButtonFace;
            labelSingin.Location = new Point(342, 9);
            labelSingin.Name = "labelSingin";
            labelSingin.Size = new Size(114, 45);
            labelSingin.TabIndex = 35;
            labelSingin.Text = "Signin";
            // 
            // textBoxAnio
            // 
            textBoxAnio.BackColor = Color.White;
            textBoxAnio.Cursor = Cursors.IBeam;
            textBoxAnio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxAnio.Location = new Point(461, 221);
            textBoxAnio.Name = "textBoxAnio";
            textBoxAnio.Size = new Size(103, 27);
            textBoxAnio.TabIndex = 31;
            textBoxAnio.KeyPress += textBoxAnio_KeyPress;
            // 
            // textBoxMes
            // 
            textBoxMes.BackColor = Color.White;
            textBoxMes.Cursor = Cursors.IBeam;
            textBoxMes.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMes.Location = new Point(378, 221);
            textBoxMes.Name = "textBoxMes";
            textBoxMes.Size = new Size(54, 27);
            textBoxMes.TabIndex = 30;
            textBoxMes.KeyPress += textBoxMes_KeyPress;
            // 
            // textBoxDia
            // 
            textBoxDia.BackColor = Color.White;
            textBoxDia.Cursor = Cursors.IBeam;
            textBoxDia.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDia.Location = new Point(294, 221);
            textBoxDia.Name = "textBoxDia";
            textBoxDia.Size = new Size(54, 27);
            textBoxDia.TabIndex = 29;
            textBoxDia.KeyPress += textBoxDia_KeyPress;
            // 
            // labelFecha
            // 
            labelFecha.BackColor = Color.Transparent;
            labelFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFecha.ForeColor = Color.FromArgb(200, 54, 42);
            labelFecha.Location = new Point(171, 204);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(100, 51);
            labelFecha.TabIndex = 28;
            labelFecha.Text = "Fecha Nacimiento";
            labelFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BackColor = Color.White;
            textBoxCorreo.Cursor = Cursors.IBeam;
            textBoxCorreo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCorreo.Location = new Point(294, 158);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(270, 27);
            textBoxCorreo.TabIndex = 27;
            // 
            // labelCorreo
            // 
            labelCorreo.BackColor = Color.Transparent;
            labelCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCorreo.ForeColor = Color.FromArgb(200, 54, 42);
            labelCorreo.Location = new Point(171, 158);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(100, 22);
            labelCorreo.TabIndex = 26;
            labelCorreo.Text = "Correo";
            labelCorreo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(294, 279);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(270, 27);
            textBoxPassword.TabIndex = 25;
            // 
            // labelPassword
            // 
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.FromArgb(200, 54, 42);
            labelPassword.Location = new Point(171, 277);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(100, 22);
            labelPassword.TabIndex = 24;
            labelPassword.Text = "Contraseña";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.White;
            textBoxUsuario.Cursor = Cursors.IBeam;
            textBoxUsuario.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxUsuario.Location = new Point(294, 107);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(270, 27);
            textBoxUsuario.TabIndex = 23;
            // 
            // labelUsuario
            // 
            labelUsuario.BackColor = Color.Transparent;
            labelUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.FromArgb(200, 54, 42);
            labelUsuario.Location = new Point(171, 107);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(100, 22);
            labelUsuario.TabIndex = 22;
            labelUsuario.Text = "Usuario";
            labelUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // botonSingin
            // 
            botonSingin.BackColor = Color.FromArgb(200, 54, 42);
            botonSingin.Cursor = Cursors.Hand;
            botonSingin.FlatStyle = FlatStyle.Flat;
            botonSingin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            botonSingin.ForeColor = SystemColors.ButtonHighlight;
            botonSingin.Location = new Point(347, 345);
            botonSingin.Name = "botonSingin";
            botonSingin.Size = new Size(100, 34);
            botonSingin.TabIndex = 21;
            botonSingin.Text = "Singin";
            botonSingin.UseVisualStyleBackColor = false;
            botonSingin.Click += botonSingin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(9, 9);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(50, 45);
            button1.TabIndex = 36;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(780, 450);
            Controls.Add(button1);
            Controls.Add(labelSingin);
            Controls.Add(textBoxAnio);
            Controls.Add(textBoxMes);
            Controls.Add(textBoxDia);
            Controls.Add(labelFecha);
            Controls.Add(textBoxCorreo);
            Controls.Add(labelCorreo);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelUsuario);
            Controls.Add(botonSingin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signin";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Singin";
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSingin;
        private TextBox textBoxAnio;
        private TextBox textBoxMes;
        private TextBox textBoxDia;
        private Label labelFecha;
        private TextBox textBoxCorreo;
        private Label labelCorreo;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxUsuario;
        private Label labelUsuario;
        private Button botonSingin;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}