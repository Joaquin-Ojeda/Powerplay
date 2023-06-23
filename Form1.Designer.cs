namespace TPFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            botonSingin = new Button();
            botonLogin = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // botonSingin
            // 
            botonSingin.BackColor = Color.FromArgb(51, 92, 129);
            botonSingin.Cursor = Cursors.Hand;
            botonSingin.FlatAppearance.BorderColor = Color.Black;
            botonSingin.FlatAppearance.BorderSize = 2;
            botonSingin.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            botonSingin.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            botonSingin.FlatStyle = FlatStyle.Flat;
            botonSingin.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            botonSingin.ForeColor = SystemColors.Control;
            botonSingin.Location = new Point(371, 239);
            botonSingin.Name = "botonSingin";
            botonSingin.Size = new Size(100, 35);
            botonSingin.TabIndex = 12;
            botonSingin.Text = "SignIn";
            botonSingin.UseVisualStyleBackColor = false;
            botonSingin.Click += botonSingin_Click;
            // 
            // botonLogin
            // 
            botonLogin.BackColor = Color.FromArgb(51, 92, 129);
            botonLogin.Cursor = Cursors.Hand;
            botonLogin.FlatAppearance.BorderColor = Color.Black;
            botonLogin.FlatAppearance.BorderSize = 2;
            botonLogin.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            botonLogin.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            botonLogin.FlatStyle = FlatStyle.Flat;
            botonLogin.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            botonLogin.ForeColor = SystemColors.Control;
            botonLogin.Location = new Point(228, 239);
            botonLogin.Name = "botonLogin";
            botonLogin.Size = new Size(100, 35);
            botonLogin.TabIndex = 11;
            botonLogin.Text = "LogIn";
            botonLogin.UseVisualStyleBackColor = false;
            botonLogin.Click += botonLogin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(655, -5);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(47, 38);
            button1.TabIndex = 13;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 400);
            Controls.Add(button1);
            Controls.Add(botonSingin);
            Controls.Add(botonLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PowerPlay";
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button botonSingin;
        private Button botonLogin;
        private Button button1;
        public System.Windows.Forms.Timer timer1;
    }
}