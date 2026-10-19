namespace app_Escritorio_GastroAdmin_2026
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BarraTitulo = new Panel();
            label2 = new Label();
            Restaurar = new PictureBox();
            Minimizar = new PictureBox();
            Maximizar = new PictureBox();
            Cerrar = new PictureBox();
            label1 = new Label();
            PnlLateral = new Panel();
            btnHistorialPedidos = new Button();
            btnInicio = new PictureBox();
            btnReporteVentas = new Button();
            btnInventario = new Button();
            panel8 = new Panel();
            btnReporte = new Button();
            panel7 = new Panel();
            btnTrabajador = new Button();
            panel6 = new Panel();
            panel5 = new Panel();
            btnPlatillos = new Button();
            panel4 = new Panel();
            btnProveedores = new Button();
            panel3 = new Panel();
            btnPedidos = new Button();
            panel2 = new Panel();
            btnMenu = new Button();
            panel1 = new Panel();
            btnClientes = new Button();
            panelContenido = new Panel();
            PanelInicio = new Panel();
            lblFrase = new Label();
            pictureBox1 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Restaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cerrar).BeginInit();
            PnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            panelContenido.SuspendLayout();
            PanelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.Blue;
            BarraTitulo.BorderStyle = BorderStyle.FixedSingle;
            BarraTitulo.Controls.Add(label2);
            BarraTitulo.Controls.Add(Restaurar);
            BarraTitulo.Controls.Add(Minimizar);
            BarraTitulo.Controls.Add(Maximizar);
            BarraTitulo.Controls.Add(Cerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1492, 46);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(7, 3);
            label2.Name = "label2";
            label2.Size = new Size(370, 39);
            label2.TabIndex = 4;
            label2.Text = "Proyecto AdminGastro";
            // 
            // Restaurar
            // 
            Restaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Restaurar.Image = (Image)resources.GetObject("Restaurar.Image");
            Restaurar.Location = new Point(1411, 4);
            Restaurar.Name = "Restaurar";
            Restaurar.Size = new Size(25, 25);
            Restaurar.SizeMode = PictureBoxSizeMode.Zoom;
            Restaurar.TabIndex = 3;
            Restaurar.TabStop = false;
            Restaurar.Visible = false;
            Restaurar.Click += Restaurar_Click_1;
            // 
            // Minimizar
            // 
            Minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimizar.Image = (Image)resources.GetObject("Minimizar.Image");
            Minimizar.Location = new Point(1370, 4);
            Minimizar.Name = "Minimizar";
            Minimizar.Size = new Size(25, 25);
            Minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Minimizar.TabIndex = 2;
            Minimizar.TabStop = false;
            Minimizar.Click += Minimizar_Click_1;
            // 
            // Maximizar
            // 
            Maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Maximizar.Image = (Image)resources.GetObject("Maximizar.Image");
            Maximizar.Location = new Point(1411, 4);
            Maximizar.Name = "Maximizar";
            Maximizar.Size = new Size(25, 25);
            Maximizar.SizeMode = PictureBoxSizeMode.Zoom;
            Maximizar.TabIndex = 1;
            Maximizar.TabStop = false;
            Maximizar.Click += Maximizar_Click_1;
            // 
            // Cerrar
            // 
            Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cerrar.Image = (Image)resources.GetObject("Cerrar.Image");
            Cerrar.Location = new Point(1453, 4);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(25, 25);
            Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Cerrar.TabIndex = 0;
            Cerrar.TabStop = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(232, 29);
            label1.TabIndex = 4;
            label1.Text = "Proyecto AdminGastro";
            // 
            // PnlLateral
            // 
            PnlLateral.BackColor = Color.FromArgb(22, 77, 116);
            PnlLateral.Controls.Add(btnHistorialPedidos);
            PnlLateral.Controls.Add(btnInicio);
            PnlLateral.Controls.Add(btnReporteVentas);
            PnlLateral.Controls.Add(btnInventario);
            PnlLateral.Controls.Add(panel8);
            PnlLateral.Controls.Add(btnReporte);
            PnlLateral.Controls.Add(panel7);
            PnlLateral.Controls.Add(btnTrabajador);
            PnlLateral.Controls.Add(panel6);
            PnlLateral.Controls.Add(panel5);
            PnlLateral.Controls.Add(btnPlatillos);
            PnlLateral.Controls.Add(panel4);
            PnlLateral.Controls.Add(btnProveedores);
            PnlLateral.Controls.Add(panel3);
            PnlLateral.Controls.Add(btnPedidos);
            PnlLateral.Controls.Add(panel2);
            PnlLateral.Controls.Add(btnMenu);
            PnlLateral.Controls.Add(panel1);
            PnlLateral.Controls.Add(btnClientes);
            PnlLateral.Dock = DockStyle.Left;
            PnlLateral.Location = new Point(0, 46);
            PnlLateral.Name = "PnlLateral";
            PnlLateral.Size = new Size(266, 873);
            PnlLateral.TabIndex = 2;
            // 
            // btnHistorialPedidos
            // 
            btnHistorialPedidos.BackColor = Color.Lavender;
            btnHistorialPedidos.Cursor = Cursors.Hand;
            btnHistorialPedidos.FlatAppearance.BorderSize = 0;
            btnHistorialPedidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnHistorialPedidos.FlatStyle = FlatStyle.Flat;
            btnHistorialPedidos.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            btnHistorialPedidos.ForeColor = SystemColors.ActiveCaptionText;
            btnHistorialPedidos.Image = (Image)resources.GetObject("btnHistorialPedidos.Image");
            btnHistorialPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorialPedidos.Location = new Point(30, 640);
            btnHistorialPedidos.Name = "btnHistorialPedidos";
            btnHistorialPedidos.Size = new Size(236, 50);
            btnHistorialPedidos.TabIndex = 21;
            btnHistorialPedidos.Text = "Historial Pedidos";
            btnHistorialPedidos.TextAlign = ContentAlignment.MiddleRight;
            btnHistorialPedidos.UseVisualStyleBackColor = false;
            btnHistorialPedidos.Click += btnHistorialPedidos_Click_1;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.AliceBlue;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(48, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(196, 125);
            btnInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnReporteVentas
            // 
            btnReporteVentas.BackColor = Color.Lavender;
            btnReporteVentas.Cursor = Cursors.Hand;
            btnReporteVentas.FlatAppearance.BorderSize = 0;
            btnReporteVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnReporteVentas.FlatStyle = FlatStyle.Flat;
            btnReporteVentas.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            btnReporteVentas.ForeColor = SystemColors.ActiveCaptionText;
            btnReporteVentas.Image = (Image)resources.GetObject("btnReporteVentas.Image");
            btnReporteVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteVentas.Location = new Point(30, 706);
            btnReporteVentas.Name = "btnReporteVentas";
            btnReporteVentas.Size = new Size(236, 50);
            btnReporteVentas.TabIndex = 17;
            btnReporteVentas.Text = "  Reporte Ventas";
            btnReporteVentas.TextAlign = ContentAlignment.MiddleRight;
            btnReporteVentas.UseVisualStyleBackColor = false;
            btnReporteVentas.Click += btnReporteVentas_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.Lavender;
            btnInventario.Cursor = Cursors.Hand;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            btnInventario.ForeColor = SystemColors.ActiveCaptionText;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(33, 382);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(240, 50);
            btnInventario.TabIndex = 3;
            btnInventario.Text = "     Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 0, 192);
            panel8.Location = new Point(8, 562);
            panel8.Name = "panel8";
            panel8.Size = new Size(25, 50);
            panel8.TabIndex = 14;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.Lavender;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            btnReporte.ForeColor = SystemColors.ActiveCaptionText;
            btnReporte.Location = new Point(30, 562);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(236, 50);
            btnReporte.TabIndex = 13;
            btnReporte.Text = "Reporte";
            btnReporte.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 0, 192);
            panel7.Location = new Point(8, 500);
            panel7.Name = "panel7";
            panel7.Size = new Size(25, 50);
            panel7.TabIndex = 12;
            // 
            // btnTrabajador
            // 
            btnTrabajador.BackColor = Color.Lavender;
            btnTrabajador.Cursor = Cursors.Hand;
            btnTrabajador.FlatAppearance.BorderSize = 0;
            btnTrabajador.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnTrabajador.FlatStyle = FlatStyle.Flat;
            btnTrabajador.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            btnTrabajador.ForeColor = SystemColors.ActiveCaptionText;
            btnTrabajador.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrabajador.Location = new Point(30, 500);
            btnTrabajador.Name = "btnTrabajador";
            btnTrabajador.Size = new Size(240, 50);
            btnTrabajador.TabIndex = 11;
            btnTrabajador.Text = "     Trabajadores";
            btnTrabajador.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 0, 192);
            panel6.Location = new Point(8, 441);
            panel6.Name = "panel6";
            panel6.Size = new Size(25, 50);
            panel6.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 0, 192);
            panel5.Location = new Point(8, 382);
            panel5.Name = "panel5";
            panel5.Size = new Size(25, 50);
            panel5.TabIndex = 10;
            // 
            // btnPlatillos
            // 
            btnPlatillos.BackColor = Color.Lavender;
            btnPlatillos.Cursor = Cursors.Hand;
            btnPlatillos.FlatAppearance.BorderSize = 0;
            btnPlatillos.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnPlatillos.FlatStyle = FlatStyle.Flat;
            btnPlatillos.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            btnPlatillos.ForeColor = SystemColors.ActiveCaptionText;
            btnPlatillos.Image = (Image)resources.GetObject("btnPlatillos.Image");
            btnPlatillos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlatillos.Location = new Point(33, 321);
            btnPlatillos.Name = "btnPlatillos";
            btnPlatillos.Size = new Size(240, 50);
            btnPlatillos.TabIndex = 9;
            btnPlatillos.Text = "   Platillos";
            btnPlatillos.UseVisualStyleBackColor = false;
            btnPlatillos.Click += btnPlatillos_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 192);
            panel4.Location = new Point(8, 321);
            panel4.Name = "panel4";
            panel4.Size = new Size(25, 50);
            panel4.TabIndex = 8;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.Lavender;
            btnProveedores.Cursor = Cursors.Hand;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            btnProveedores.ForeColor = SystemColors.ActiveCaptionText;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(33, 441);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(240, 50);
            btnProveedores.TabIndex = 7;
            btnProveedores.Text = "      Proveedores";
            btnProveedores.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 192);
            panel3.Location = new Point(8, 257);
            panel3.Name = "panel3";
            panel3.Size = new Size(25, 50);
            panel3.TabIndex = 6;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.Lavender;
            btnPedidos.Cursor = Cursors.Hand;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            btnPedidos.ForeColor = SystemColors.ActiveCaptionText;
            btnPedidos.Image = (Image)resources.GetObject("btnPedidos.Image");
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(30, 257);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(240, 50);
            btnPedidos.TabIndex = 5;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 192);
            panel2.Location = new Point(8, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(25, 50);
            panel2.TabIndex = 4;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Lavender;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            btnMenu.ForeColor = SystemColors.ActiveCaptionText;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(30, 194);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(240, 50);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "       Menú Platillos";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Location = new Point(8, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(25, 50);
            panel1.TabIndex = 2;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Lavender;
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Script MT Bold", 12F, FontStyle.Bold);
            btnClientes.ForeColor = SystemColors.ActiveCaptionText;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(30, 131);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(240, 50);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(181, 219, 232);
            panelContenido.Controls.Add(PanelInicio);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(266, 46);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1226, 873);
            panelContenido.TabIndex = 3;
            // 
            // PanelInicio
            // 
            PanelInicio.BackColor = Color.White;
            PanelInicio.BorderStyle = BorderStyle.Fixed3D;
            PanelInicio.Controls.Add(lblFrase);
            PanelInicio.Controls.Add(pictureBox1);
            PanelInicio.Dock = DockStyle.Fill;
            PanelInicio.Location = new Point(0, 0);
            PanelInicio.Name = "PanelInicio";
            PanelInicio.Size = new Size(1226, 873);
            PanelInicio.TabIndex = 4;
            // 
            // lblFrase
            // 
            lblFrase.AutoSize = true;
            lblFrase.Font = new Font("Modern No. 20", 21.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFrase.Location = new Point(228, 678);
            lblFrase.Name = "lblFrase";
            lblFrase.Size = new Size(117, 45);
            lblFrase.TabIndex = 5;
            lblFrase.Text = "Frase";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(206, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(783, 570);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 919);
            Controls.Add(panelContenido);
            Controls.Add(PnlLateral);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Restaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cerrar).EndInit();
            PnlLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            panelContenido.ResumeLayout(false);
            PanelInicio.ResumeLayout(false);
            PanelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel BarraTitulo;
        private Panel PnlLateral;
        private Panel panelContenido;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox btnInicio;
        private Button btnClientes;
        private Panel panel1;
        private Panel panel8;
        private Button btnReporte;
        private Panel panel7;
        private Button btnTrabajador;
        private Panel panel6;
        private Panel panel5;
        private Button btnInventario;
        private Button btnPlatillos;
        private Panel panel4;
        private Button btnProveedores;
        private Panel panel3;
        private Button btnPedidos;
        private Panel panel2;
        private Button btnMenu;
        private Label label1;
        private Button btnReporteVentas;
        private PictureBox Restaurar;
        private PictureBox Minimizar;
        private PictureBox Maximizar;
        private PictureBox Cerrar;
        private Panel PanelInicio;
        private Label lblFrase;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnHistorialPedidos;
    }
}
