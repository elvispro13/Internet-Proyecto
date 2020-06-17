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

namespace Principal_Internet_elvis.Cliente
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
        }
    }
}
