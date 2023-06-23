namespace TPFinal
{
    partial class Carrito
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            gridCarrito = new DataGridView();
            Juego = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            button16 = new Button();
            button1 = new Button();
            button2 = new Button();
            tarjeta = new RadioButton();
            efectivo = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            labelTotal = new Label();
            label3 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridCarrito).BeginInit();
            SuspendLayout();
            // 
            // gridCarrito
            // 
            gridCarrito.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            gridCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCarrito.Columns.AddRange(new DataGridViewColumn[] { Juego, Cantidad, Precio });
            gridCarrito.GridColor = SystemColors.InactiveCaption;
            gridCarrito.Location = new Point(62, 55);
            gridCarrito.Name = "gridCarrito";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new Padding(20);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            gridCarrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            gridCarrito.RowTemplate.Height = 25;
            gridCarrito.Size = new Size(527, 294);
            gridCarrito.TabIndex = 0;
            gridCarrito.CellClick += gridCarrito_CellClick;
            gridCarrito.CellValueChanged += gridCarrito_CellValueChanged;
            // 
            // Juego
            // 
            Juego.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Juego.HeaderText = "Juego";
            Juego.Name = "Juego";
            Juego.ReadOnly = true;
            Juego.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0";
            Precio.DefaultCellStyle = dataGridViewCellStyle5;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // button16
            // 
            button16.BackColor = Color.Red;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button16.ForeColor = SystemColors.ControlLightLight;
            button16.Location = new Point(603, 0);
            button16.Margin = new Padding(0);
            button16.Name = "button16";
            button16.Size = new Size(47, 39);
            button16.TabIndex = 50;
            button16.Text = "X";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(199, 567);
            button1.Name = "button1";
            button1.Size = new Size(252, 53);
            button1.TabIndex = 51;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(181, 414);
            button2.Name = "button2";
            button2.Size = new Size(130, 35);
            button2.TabIndex = 52;
            button2.Text = "Sacar del carrito";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tarjeta
            // 
            tarjeta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tarjeta.ForeColor = Color.DarkBlue;
            tarjeta.Location = new Point(222, 510);
            tarjeta.Name = "tarjeta";
            tarjeta.Size = new Size(105, 36);
            tarjeta.TabIndex = 53;
            tarjeta.TabStop = true;
            tarjeta.Text = "Tarjeta";
            tarjeta.UseVisualStyleBackColor = true;
            // 
            // efectivo
            // 
            efectivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            efectivo.ForeColor = Color.DarkBlue;
            efectivo.Location = new Point(346, 510);
            efectivo.Name = "efectivo";
            efectivo.Size = new Size(105, 36);
            efectivo.TabIndex = 54;
            efectivo.TabStop = true;
            efectivo.Text = "Efectivo";
            efectivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(222, 465);
            label1.Name = "label1";
            label1.Size = new Size(202, 33);
            label1.TabIndex = 55;
            label1.Text = "Metodo de pago";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 352);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 56;
            label2.Text = "Total";
            // 
            // labelTotal
            // 
            labelTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.Location = new Point(469, 352);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(120, 35);
            labelTotal.TabIndex = 57;
            labelTotal.Text = "precio";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(442, 352);
            label3.Name = "label3";
            label3.Size = new Size(21, 35);
            label3.TabIndex = 58;
            label3.Text = "$";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(333, 414);
            button3.Name = "button3";
            button3.Size = new Size(130, 35);
            button3.TabIndex = 59;
            button3.Text = "Limpiar carrito";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 650);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(labelTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(efectivo);
            Controls.Add(tarjeta);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button16);
            Controls.Add(gridCarrito);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Carrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carrito";
            Load += Carrito_Load;
            ((System.ComponentModel.ISupportInitialize)gridCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridCarrito;
        private Button button16;
        private Button button1;
        private Button button2;
        private RadioButton tarjeta;
        private RadioButton efectivo;
        private Label label1;
        private Label label2;
        private Label labelTotal;
        private DataGridViewTextBoxColumn Juego;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private Label label3;
        private Button button3;
    }
}