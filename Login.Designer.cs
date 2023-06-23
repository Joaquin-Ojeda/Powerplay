namespace TPFinal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            labelLogin = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxUsuario = new TextBox();
            labelUsuario = new Label();
            buttonLogin = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelLogin.ForeColor = SystemColors.InactiveCaption;
            labelLogin.Location = new Point(343, 53);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(114, 50);
            labelLogin.TabIndex = 12;
            labelLogin.Text = "Login";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.ScrollBar;
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(304, 228);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(270, 29);
            textBoxPassword.TabIndex = 11;
            // 
            // labelPassword
            // 
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = SystemColors.GradientInactiveCaption;
            labelPassword.Location = new Point(174, 216);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(124, 46);
            labelPassword.TabIndex = 10;
            labelPassword.Text = "Contraseña";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = SystemColors.ScrollBar;
            textBoxUsuario.Cursor = Cursors.IBeam;
            textBoxUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxUsuario.Location = new Point(304, 159);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(270, 29);
            textBoxUsuario.TabIndex = 9;
            // 
            // labelUsuario
            // 
            labelUsuario.BackColor = Color.Transparent;
            labelUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.ForeColor = SystemColors.GradientInactiveCaption;
            labelUsuario.Location = new Point(174, 149);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(124, 46);
            labelUsuario.TabIndex = 8;
            labelUsuario.Text = "Usuario";
            labelUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.SlateBlue;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderColor = Color.White;
            buttonLogin.FlatAppearance.BorderSize = 2;
            buttonLogin.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            buttonLogin.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.FromArgb(229, 212, 237);
            buttonLogin.Location = new Point(343, 352);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(100, 34);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "LogIn";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
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
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelUsuario);
            Controls.Add(buttonLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Enter += buttonLogin_Click;
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxUsuario;
        private Label labelUsuario;
        private Button buttonLogin;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}