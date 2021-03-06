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

using Principal_Internet_elvis;
using Principal_Internet_elvis.ClientesCarpeta;
using Principal_Internet_elvis.Configuraciones;
using Principal_Internet_elvis.FormmGenerales;
using Principal_Internet_elvis.Pagos;
using Principal_Internet_elvis.Paquetes;
using Principal_Internet_elvis.Reportes;
using Principal_Internet_elvis.Ubicacion;
using Proyecto_Internet;

namespace Principal_Internet_elvis
{
    public partial class Menu : Form
    {
        public int idu;
        public string user, clave, desc, nombre;
        public Font fuente;
        public Image logo;

        //empresa
        public string nombre_e, eslogan_e, rtn_e, cai_e, correo_e, fechalimite_e;
        public int desde_e, hasta_e, ide;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Program.inicio = new Inicio();
            Program.inicio.TopMost = true;
            Program.inicio.BringToFront();
            Program.inicio.Show();
            Program.inicio.Focus();
        }

        public void activarConUser()
        {
            bt_pagos.Enabled = true;
            bt_clientes.Enabled = true;
            bt_contratos.Enabled = true;
            bt_paquetes.Enabled = true;
            bt_facturas.Enabled = true;
            bt_ubicacion.Enabled = true;
            bt_reportes.Enabled = true;
            bt_configuracion.Enabled = true;
            if (logo != null)
            {
                img_logo.Image = logo;
            }
        }

        public void addFuente(Font f)
        {
            foreach (Button boton in Program.GetAllChildren(this).OfType<Button>())
            {
                boton.Font = f;
            }

            foreach (Label boton in Program.GetAllChildren(this).OfType<Label>())
            {
                boton.Font = f;
            }
        }

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bt_maximizar.Visible = false;
            bt_restaurar.Visible = true;
        }

        private void bt_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            bt_maximizar.Visible = true;
            bt_restaurar.Visible = false;
        }

        private void bt_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();

        }

        private void bt_pagos_Click(object sender, EventArgs e)
        {
            Program.pago = new Pago();
            AbrirFormEnPanel(Program.pago);
        }
    }
}
