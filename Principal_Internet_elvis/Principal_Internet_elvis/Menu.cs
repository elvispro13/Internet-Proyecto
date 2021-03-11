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

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using RestSharp;

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

            //insertarFB();
            //obtenerUnRegustro();
        }

        private async void insertarFB()
        {
            FirebaseConexion conexion = new FirebaseConexion();
            var data = new Data
            {
                id = "hola",
                nombre = "nnnn"
            };

            SetResponse response = await conexion.client.SetTaskAsync("prueba", data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Resultado "+result.id);
        }

        private async void obtenerUnRegustro()
        {
            FirebaseConexion conexion = new FirebaseConexion();
            FirebaseResponse response = await conexion.client.GetTaskAsync("prueba/");
            Dictionary<String, Data> res = response.ResultAs<Dictionary<String, Data>>();

            foreach(var get in res)
            {
                MessageBox.Show(get.Value.nombre);
            }
        }

        private async void borrar()
        {
            FirebaseConexion conexion = new FirebaseConexion();
            FirebaseResponse response = await conexion.client.DeleteTaskAsync("prueba");
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
            bt_inicio_Click(null,null);
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

        public void setRuta(String ruta)
        {
            this.lb_ruta.Text = ruta;
        }

        public void addRuta(String ruta)
        {
            this.lb_ruta.Text += ruta;
        }

        public void removeRuta(String ruta)
        {
            this.lb_ruta.Text = this.lb_ruta.Text.Replace(ruta,"");
        }

        public void AbrirFormEnPanel(object formhija)
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

        public String getIP(String ip)
        {
            String[] c = ip.Split('.');
            int[] n = {Convert.ToInt32(c[0]),
                Convert.ToInt32(c[1]) ,
                Convert.ToInt32(c[2]) ,
                Convert.ToInt32(c[3]) };

            n[3] += 1;
            if (n[3] > 254)
            {
                n[3] = 2;
                n[2] += 1;
                if (n[2] > 254)
                {
                    n[2] = 1;
                    n[1] += 1;
                    if (n[1] > 254)
                    {
                        n[1] = 1;
                        n[0] += 1;
                        if (n[0] > 254)
                        {
                            n[0] = 0;
                            n[1] = 0;
                            n[2] = 0;
                            n[3] = 0;
                        }
                    }
                }
            }

            return n[0] + "." + n[1] + "." + n[2] + "." + n[3];
        }

        public void bt_inicio_Click(object sender, EventArgs e)
        {
            Program.dashboard = new Dashboard();
            AbrirFormEnPanel(Program.dashboard);
            lb_ruta.Text = "INICIO/";
        }

        private void bt_pagos_Click(object sender, EventArgs e)
        {
            Program.pago = new Pago();
            AbrirFormEnPanel(Program.pago);
            lb_ruta.Text = "PAGOS/";
        }

        private void bt_clientes_Click(object sender, EventArgs e)
        {
            Program.clientes = new Clientes();
            AbrirFormEnPanel(Program.clientes);
            lb_ruta.Text = "CLIENTES/";
        }

        private void bt_contratos_Click(object sender, EventArgs e)
        {
            Program.estado_Cliente = new Estado_cliente();
            AbrirFormEnPanel(Program.estado_Cliente);
            lb_ruta.Text = "CONTRATOS/";
        }

        private void bt_paquetes_Click(object sender, EventArgs e)
        {
            Program.paquetesTipo = new PaquetesTipo();
            AbrirFormEnPanel(Program.paquetesTipo);
            lb_ruta.Text = "PAQUETES/";
        }

        private void bt_facturas_Click(object sender, EventArgs e)
        {
            Program.bus_Factura = new Bus_factura();
            Program.bus_Factura.Text = "BUSQUEDA-FACTURAS";
            AbrirFormEnPanel(Program.bus_Factura);
            lb_ruta.Text = "FACTURAS/";
        }

        private void bt_ubicacion_Click(object sender, EventArgs e)
        {
            Program.ubicacionTipo = new UbicacionTipo();
            Program.ubicacionTipo.Text = "UBICACION-BUSCAR";
            AbrirFormEnPanel(Program.ubicacionTipo);
            lb_ruta.Text = "UBICACION/";
        }

        private void bt_reportes_Click(object sender, EventArgs e)
        {
            Program.reportesTipo = new ReportesTipo();
            Program.reportesTipo.Text = "REPORTES";
            AbrirFormEnPanel(Program.reportesTipo);
            lb_ruta.Text = "REPORTES/";
        }

        private void bt_configuracion_Click(object sender, EventArgs e)
        {
            Program.configuracion = new Configuracion();
            Program.configuracion.Text = "CONFIGURACION";
            AbrirFormEnPanel(Program.configuracion);
            lb_ruta.Text = "AJUSTES/";
        }
    }
}
