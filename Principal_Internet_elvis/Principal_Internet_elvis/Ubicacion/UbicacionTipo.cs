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
            Program.ubicacionAgregar = new UbicacionAgregar();
            if (this.Text.Equals("UBICACION-AGREGAR"))
            {
                Program.ubicacionAgregar.Text = "AGREGAR-SECTOR";
            }
            else if (this.Text.Equals("UBICACION-BUSCAR"))
            {
                Program.ubicacionAgregar.Text = "BUSCAR-SECTOR";
            }
            else if (this.Text.Equals("UBICACION-MODIFICAR"))
            {
                Program.ubicacionAgregar.Text = "MODIFICAR-SECTOR";
            }
            else if (this.Text.Equals("UBICACION-ESTADO"))
            {
                Program.ubicacionAgregar.Text = "ESTADO-SECTOR";
            }
            Program.ubicacionAgregar.Show();
            Program.ubicacionAgregar.Focus();
            this.Close();
        }

        private void bt_barrio_Click(object sender, EventArgs e)
        {
            Program.ubicacionAgregar = new UbicacionAgregar();
            if (this.Text.Equals("UBICACION-AGREGAR"))
            {
                Program.ubicacionAgregar.Text = "AGREGAR-BARRIO";
            }
            else if (this.Text.Equals("UBICACION-BUSCAR"))
            {
                Program.ubicacionAgregar.Text = "BUSCAR-BARRIO";
            }
            else if (this.Text.Equals("UBICACION-MODIFICAR"))
            {
                Program.ubicacionAgregar.Text = "MODIFICAR-BARRIO";
            }
            else if (this.Text.Equals("UBICACION-ESTADO"))
            {
                Program.ubicacionAgregar.Text = "ESTADO-BARRIO";
            }
            Program.ubicacionAgregar.Show();
            Program.ubicacionAgregar.Focus();
            this.Close();
        }

        private void bt_lugar_Click(object sender, EventArgs e)
        {
            Program.ubicacionAgregar = new UbicacionAgregar();
            if (this.Text.Equals("UBICACION-AGREGAR"))
            {
                Program.ubicacionAgregar.Text = "AGREGAR-LUGAR";
            }
            else if (this.Text.Equals("UBICACION-BUSCAR"))
            {
                Program.ubicacionAgregar.Text = "BUSCAR-LUGAR";
            }
            else if (this.Text.Equals("UBICACION-MODIFICAR"))
            {
                Program.ubicacionAgregar.Text = "MODIFICAR-LUGAR";
            }
            else if (this.Text.Equals("UBICACION-ESTADO"))
            {
                Program.ubicacionAgregar.Text = "ESTADO-LUGAR";
            }
            Program.ubicacionAgregar.Show();
            Program.ubicacionAgregar.Focus();
            this.Close();
        }
    }
}
