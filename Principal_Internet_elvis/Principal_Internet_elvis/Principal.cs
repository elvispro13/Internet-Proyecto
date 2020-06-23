using Principal_Internet_elvis;
using Principal_Internet_elvis.Configuraciones;
using Principal_Internet_elvis.FormmGenerales;
using Principal_Internet_elvis.Pagos;
using Proyecto_Internet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_dawelin
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        public void activarConUser()
        {
            btnPago.Enabled = true;
            btnCliente.Enabled = true;
            btnPaquetes.Enabled = true;
            btnFactura.Enabled = true;
            btnUbicacion.Enabled = true;
            btnReportes.Enabled = true;
            btnConfiguracion.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.configuracionLogo = new ConfiguracionLogo();
            Program.configuracionLogo.Show();
            Program.configuracionLogo.TopMost = true;
            Program.configuracionLogo.Focus();
            Program.configuracionLogo.BringToFront();
            Program.configuracionLogo.Text = "EMPRESA";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.inicio = new Inicio();
            Program.inicio.Show();
            Program.inicio.TopMost = true; 
            Program.inicio.Focus(); 
            Program.inicio.BringToFront();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntPago_Click(object sender, EventArgs e)
        {
            Program.pago = new Pago();
            Program.pago.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Program.OpCliente = new Opciones();
            Program.OpCliente.Show();
            Program.OpCliente.TopMost = true;
            Program.OpCliente.Focus();
            Program.OpCliente.BringToFront();
            Program.OpCliente.Text = "CLIENTES";
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            panel_logo.Left = this.Width - (panel_logo.Width + 25);
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            Program.OpCliente = new Opciones();
            Program.OpCliente.Show();
            Program.OpCliente.TopMost = true;
            Program.OpCliente.Focus();
            Program.OpCliente.BringToFront();
            Program.OpCliente.Text = "UBICACION";
        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            Program.OpCliente = new Opciones();
            Program.OpCliente.Show();
            Program.OpCliente.TopMost = true;
            Program.OpCliente.Focus();
            Program.OpCliente.BringToFront();
            Program.OpCliente.Text = "PAQUETES";
        }
    }
}
