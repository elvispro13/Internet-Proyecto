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
    public partial class UbicacionElegir : Form
    {
        public UbicacionElegir()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            Program.ubicacionAgregar.agregarDatos(1,"Listo");
            this.Close();
        }

        private void UbicacionElegir_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("ELEGIR-SECTOR"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("''");
                campos.Add("1");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
            }
            else if (this.Text.Equals("ELEGIR-BARRIO"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("''");
                campos.Add("2");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
            }
        }
    }
}
