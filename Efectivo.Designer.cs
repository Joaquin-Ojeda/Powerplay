namespace TPFinal
{
    partial class Efectivo
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
            label12 = new Label();
            button1 = new Button();
            textTelefono = new TextBox();
            textPostal = new TextBox();
            textLocalidad = new TextBox();
            textPais = new TextBox();
            textDireccion = new TextBox();
            textApellido = new TextBox();
            textNombre = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button16 = new Button();
            SuspendLayout();
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(173, 70);
            label12.Name = "label12";
            label12.Size = new Size(290, 46);
            label12.TabIndex = 92;
            label12.Text = "Información de facturación";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(175, 377);
            button1.Name = "button1";
            button1.Size = new Size(283, 47);
            button1.TabIndex = 91;
            button1.Text = "Generar factura";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textTelefono
            // 
            textTelefono.BackColor = SystemColors.ControlDarkDark;
            textTelefono.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textTelefono.ForeColor = SystemColors.Menu;
            textTelefono.Location = new Point(392, 315);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(226, 27);
            textTelefono.TabIndex = 90;
            textTelefono.KeyPress += textTelefono_KeyPress;
            // 
            // textPostal
            // 
            textPostal.BackColor = SystemColors.ControlDarkDark;
            textPostal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textPostal.ForeColor = SystemColors.Menu;
            textPostal.Location = new Point(392, 235);
            textPostal.Name = "textPostal";
            textPostal.Size = new Size(101, 27);
            textPostal.TabIndex = 89;
            textPostal.KeyPress += textPostal_KeyPress;
            // 
            // textLocalidad
            // 
            textLocalidad.BackColor = SystemColors.ControlDarkDark;
            textLocalidad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textLocalidad.ForeColor = SystemColors.Menu;
            textLocalidad.Location = new Point(392, 167);
            textLocalidad.Name = "textLocalidad";
            textLocalidad.Size = new Size(226, 27);
            textLocalidad.TabIndex = 88;
            // 
            // textPais
            // 
            textPais.BackColor = SystemColors.ControlDarkDark;
            textPais.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textPais.ForeColor = SystemColors.Menu;
            textPais.Location = new Point(50, 315);
            textPais.Name = "textPais";
            textPais.Size = new Size(101, 27);
            textPais.TabIndex = 87;
            // 
            // textDireccion
            // 
            textDireccion.BackColor = SystemColors.ControlDarkDark;
            textDireccion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textDireccion.ForeColor = SystemColors.Menu;
            textDireccion.Location = new Point(50, 235);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(226, 27);
            textDireccion.TabIndex = 86;
            // 
            // textApellido
            // 
            textApellido.BackColor = SystemColors.ControlDarkDark;
            textApellido.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textApellido.ForeColor = SystemColors.Menu;
            textApellido.Location = new Point(175, 167);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(101, 27);
            textApellido.TabIndex = 85;
            // 
            // textNombre
            // 
            textNombre.BackColor = SystemColors.ControlDarkDark;
            textNombre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textNombre.ForeColor = SystemColors.Menu;
            textNombre.Location = new Point(50, 167);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(101, 27);
            textNombre.TabIndex = 84;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(392, 279);
            label11.Name = "label11";
            label11.Size = new Size(74, 21);
            label11.TabIndex = 83;
            label11.Text = "Teléfono";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(50, 279);
            label10.Name = "label10";
            label10.Size = new Size(38, 21);
            label10.TabIndex = 82;
            label10.Text = "País";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(392, 202);
            label9.Name = "label9";
            label9.Size = new Size(113, 21);
            label9.TabIndex = 81;
            label9.Text = "Código postal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(50, 202);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 80;
            label8.Text = "Dirección";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(392, 132);
            label7.Name = "label7";
            label7.Size = new Size(80, 21);
            label7.TabIndex = 79;
            label7.Text = "Localidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(173, 132);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 78;
            label6.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(50, 132);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 77;
            label5.Text = "Nombre";
            // 
            // button16
            // 
            button16.BackColor = Color.Red;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button16.ForeColor = SystemColors.ControlLightLight;
            button16.Location = new Point(603, -1);
            button16.Margin = new Padding(0);
            button16.Name = "button16";
            button16.Size = new Size(47, 39);
            button16.TabIndex = 76;
            button16.Text = "X";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // Efectivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(650, 470);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(textTelefono);
            Controls.Add(textPostal);
            Controls.Add(textLocalidad);
            Controls.Add(textPais);
            Controls.Add(textDireccion);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button16);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Efectivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Efectivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Button button1;
        private TextBox textTelefono;
        private TextBox textPostal;
        private TextBox textLocalidad;
        private TextBox textPais;
        private TextBox textDireccion;
        private TextBox textApellido;
        private TextBox textNombre;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button16;
    }
}