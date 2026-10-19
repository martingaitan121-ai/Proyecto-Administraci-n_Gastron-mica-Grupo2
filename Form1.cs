using app_Escritorio_GastroAdmin_2026.Data;
using app_Escritorio_GastroAdmin_2026.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices;

using app_Escritorio_GastroAdmin_2026.Models;
using app_Escritorio_GastroAdmin_2026.Controller;
using app_Escritorio_GastroAdmin_2026.Views;

// Cargar las 2 librerias (controlador y json)
using app_Escritorio_GastroAdmin_2026.Models;
using Microsoft.EntityFrameworkCore.Storage.Json;
using app_Escritorio_GastroAdmin_2026.Services;

namespace app_Escritorio_GastroAdmin_2026

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MostrarDashboard();

            //CargarDatos();
            TextoNegocio();

            Tema.Aplicar(this);
            lblFrase.Font = new Font(
        "Segoe UI Semibold",24F,
        FontStyle.Regular);

            Tema.EstilizarLateral(
                PnlLateral,
                btnClientes,
                btnPedidos,
                btnHistorialPedidos,
                btnMenu,
                btnPlatillos,
                btnInventario,
                btnProveedores,
                btnTrabajador,
                //btnHistorialVentas,
                btnReporteVentas);
        }

        // ==================================================================
        // Lista de frases del negocio
        private string[] frases =
        {


            "Bienvenidos a nuestra casa",
            "Sabores que te transportan al corazón",
            "Sabores que se quedan en tu memoria",
            "Cada platillo cuenta una historia",
            "El sabor de los buenos momentos",
            "Donde cada bocado es una experiencia",
        };

        private int indiceFrase = 0;

        // Timer para cambiar las frases
        private System.Windows.Forms.Timer timerFrases =
            new System.Windows.Forms.Timer();

        private void TextoNegocio()
        {
            lblFrase.Text = $"“{frases[indiceFrase]}”";
            timerFrases.Interval = 4000; // 4 segundos
            timerFrases.Tick += TimerFrases_Tick;
            timerFrases.Start();
        }

        // Cambiar la frase automáticamente
        private void TimerFrases_Tick(object sender, EventArgs e)
        {
            indiceFrase++;

            if (indiceFrase >= frases.Length)
            {
                indiceFrase = 0;
            }

            lblFrase.Text = $"“{frases[indiceFrase]}”";
        }

        // ==================================================================



        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDashboard();
        }

        // ==================================================================
        // Muestra el dashboard de ejemplo al iniciar la aplicación

        /*  private void MostrarDashboard()
         * {
         * var dashboard = new UcDashboard(new DemoDashboardService());
         * dashboard.Dock = DockStyle.Fill;
         * PanelInicio.Controls.Clear();
         * PanelInicio.Controls.Add(dashboard);
         * dashboard.BringToFront();
         * }
        */

        private void MostrarDashboard()
        {
            PanelInicio.Controls.Clear();

            var dashboard = new UcDashboard(
                new SqlDashboardService()
            )
            {
                Dock = DockStyle.Fill
            };

            PanelInicio.Controls.Add(dashboard);
        }







        // ==================================================================
        // CODIGO PARA MOVER EL FORMULARIO

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // =================================================

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // ==================================================================

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // =================================================

        private void Maximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        // =================================================
        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        // =================================================
        private void Restaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }


        // ===================================================

        // ABTRIR FORMULARIOS EN PANEL
        private Form formularioActivo = null;
        public void AbrirFormulario(Form formularioHijo)
        {
            // Cerrar el formulario anterior
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }

            // Ocultar pantalla de inicio
            PanelInicio.Visible = false;

            // Configurar formulario hijo
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            // Limpiar el panel

            //panelContenido.Controls.Clear();

            // Agregar formulario

            panelContenido.Controls.Add(formularioHijo);

            formularioActivo = formularioHijo;

            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        // =================================================
        // funcion del metodo inicio para mostrar la pantalla de bienvenida
        public void MostrarInicio()
        {
            // Cerrar el formulario hijo activo
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }

            // Mostrar nuevamente la pantalla de bienvenida
            PanelInicio.Visible = true;
            PanelInicio.BringToFront();
        }

        // ===================================================
        // abrir formulario cliente
        private void btnClientes_Click(object sender, EventArgs e)
        {

            SelecModulobtnPanel(btnClientes);
            AbrirFormulario(new FrmClientes(this));
        }

        // ===================================================
        // poner color a los botones laterales
        private void SelecModulobtnPanel(Button seleccionado)
        {
            Tema.EstilizarLateral(
                PnlLateral,
                btnClientes,
                btnPedidos,
                btnHistorialPedidos,
                btnMenu,
                btnPlatillos,
                btnInventario,
                btnProveedores,
                btnTrabajador,
                //btnHistorialVentas,
                btnReporteVentas);
        }

        // ==========================================
        // abrir formulario inicio

        private void btnInicio_Click(object sender, EventArgs e)
        { // Cerrar el formulario hijo que esté abierto
            MostrarInicio();
        }

        // abrir formulario Menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            SelecModulobtnPanel(btnMenu);
            AbrirFormulario(new FrmMenu(this));
        }


        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FrmReporteVentas(this));
        }

        private void btnPlatillos_Click(object sender, EventArgs e)
        {
            SelecModulobtnPanel(btnPlatillos);
            AbrirFormulario(new FrmPlatillos(this));
        }

        private void btnHistorialPedidos_Click_1(object sender, EventArgs e)
        {
            SelecModulobtnPanel(btnHistorialPedidos);
            AbrirFormulario(new FrmHistorialPedidos(this));
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            SelecModulobtnPanel(btnInventario);

            AbrirFormulario(new FrmInventario(this));
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            SelecModulobtnPanel(btnPedidos);
            AbrirFormulario(new FrmPedidos(this));
        }
    }
}