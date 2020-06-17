using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.Ubicacion
{
    public partial class UbicacionTipo : Form
    {
        public UbicacionTipo()
        {
            InitializeComponent();
        }

        private void bt_sector_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("UBICACION-AGREGAR"))
            {
                Program.ubicacionAgregar = new UbicacionAgregar();
                Program.ubicacionAgregar.Text = "AGREGAR-SECTOR";
                Program.ubicacionAgregar.Show();
                Program.ubicacionAgregar.Focus();
                this.Close();
            }
        }

        private void bt_barrio_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("UBICACION-AGREGAR"))
            {
                Program.ubicacionAgregar = new UbicacionAgregar();
                Program.ubicacionAgregar.Text = "AGREGAR-BARRIO";
                Program.ubicacionAgregar.Show();
                Program.ubicacionAgregar.Focus();
                this.Close();
            }
        }

        private void bt_lugar_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("UBICACION-AGREGAR"))
            {
                Program.ubicacionAgregar = new UbicacionAgregar();
                Program.ubicacionAgregar.Text = "AGREGAR-LUGAR";
                Program.ubicacionAgregar.Show();
                Program.ubicacionAgregar.Focus();
                this.Close();
            }
        }
    }
}
