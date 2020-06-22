using Principal_Internet_elvis.ClientesCarpeta;
using Principal_Internet_elvis.Paquetes;
using Principal_Internet_elvis.Ubicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.FormmGenerales
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("UBICACION"))
            {
                Program.ubicacionTipo = new UbicacionTipo();
                Program.ubicacionTipo.Show();
                Program.ubicacionTipo.TopMost = true;
                Program.ubicacionTipo.Focus();
                Program.ubicacionTipo.BringToFront();
                Program.ubicacionTipo.Text = "UBICACION-AGREGAR";
                this.Close();
            }
            else if (this.Text.Equals("PAQUETES"))
            {
                Program.paquetesTipo = new PaquetesTipo();
                Program.paquetesTipo.Show();
                Program.paquetesTipo.TopMost = true;
                Program.paquetesTipo.Focus();
                Program.paquetesTipo.BringToFront();
                Program.paquetesTipo.Text = "PAQUETES-AGREGAR";
                this.Close();
            }
            else if (this.Text.Equals("CLIENTES"))
            {
                Program.clientes = new Clientes();
                Program.clientes.Show();
                Program.clientes.TopMost = true;
                Program.clientes.Focus();
                Program.clientes.BringToFront();
                Program.clientes.Text = "CLIENTE-AGREGAR";
                this.Close();
            }
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("UBICACION"))
            {
                Program.ubicacionTipo = new UbicacionTipo();
                Program.ubicacionTipo.Show();
                Program.ubicacionTipo.TopMost = true;
                Program.ubicacionTipo.Focus();
                Program.ubicacionTipo.BringToFront();
                Program.ubicacionTipo.Text = "UBICACION-BUSCAR";
                this.Close();
            }
            else if (this.Text.Equals("PAQUETES"))
            {
                Program.paquetesTipo = new PaquetesTipo();
                Program.paquetesTipo.Show();
                Program.paquetesTipo.TopMost = true;
                Program.paquetesTipo.Focus();
                Program.paquetesTipo.BringToFront();
                Program.paquetesTipo.Text = "PAQUETES-BUSCAR";
                this.Close();
            }
            else if (this.Text.Equals("CLIENTES"))
            {
                Program.clientes = new Clientes();
                Program.clientes.Show();
                Program.clientes.TopMost = true;
                Program.clientes.Focus();
                Program.clientes.BringToFront();
                Program.clientes.Text = "CLIENTE-BUSCAR";
                this.Close();
            }
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("UBICACION"))
            {
                Program.ubicacionTipo = new UbicacionTipo();
                Program.ubicacionTipo.Show();
                Program.ubicacionTipo.TopMost = true;
                Program.ubicacionTipo.Focus();
                Program.ubicacionTipo.BringToFront();
                Program.ubicacionTipo.Text = "UBICACION-MODIFICAR";
                this.Close();
            }
            else if (this.Text.Equals("PAQUETES"))
            {
                Program.paquetesTipo = new PaquetesTipo();
                Program.paquetesTipo.Show();
                Program.paquetesTipo.TopMost = true;
                Program.paquetesTipo.Focus();
                Program.paquetesTipo.BringToFront();
                Program.paquetesTipo.Text = "PAQUETES-MODIFICAR";
                this.Close();
            }
            else if (this.Text.Equals("CLIENTES"))
            {
                Program.clientes = new Clientes();
                Program.clientes.Show();
                Program.clientes.TopMost = true;
                Program.clientes.Focus();
                Program.clientes.BringToFront();
                Program.clientes.Text = "CLIENTE-MODIFICAR";
                this.Close();
            }
        }

        private void bt_estado_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("UBICACION"))
            {
                Program.ubicacionTipo = new UbicacionTipo();
                Program.ubicacionTipo.Show();
                Program.ubicacionTipo.TopMost = true;
                Program.ubicacionTipo.Focus();
                Program.ubicacionTipo.BringToFront();
                Program.ubicacionTipo.Text = "UBICACION-ESTADO";
                this.Close();
            }
            else if (this.Text.Equals("PAQUETES"))
            {
                Program.paquetesTipo = new PaquetesTipo();
                Program.paquetesTipo.Show();
                Program.paquetesTipo.TopMost = true;
                Program.paquetesTipo.Focus();
                Program.paquetesTipo.BringToFront();
                Program.paquetesTipo.Text = "PAQUETES-ESTADO";
                this.Close();
            }
            else if (this.Text.Equals("CLIENTES"))
            {
                Program.clientes = new Clientes();
                Program.clientes.Show();
                Program.clientes.TopMost = true;
                Program.clientes.Focus();
                Program.clientes.BringToFront();
                Program.clientes.Text = "CLIENTE-ESTADO";
                this.Close();
            }
        }
    }
}
