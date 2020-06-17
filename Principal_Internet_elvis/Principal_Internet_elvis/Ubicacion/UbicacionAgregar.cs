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
    public partial class UbicacionAgregar : Form
    {
        private int id2;

        public UbicacionAgregar()
        {
            InitializeComponent();
        }

        private void UbicacionAgregar_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            if (this.Text.Equals("AGREGAR-SECTOR"))
            {
                gb_codigo.Enabled = false;
                gb_codigo2.Enabled = false;
                gb_codigo2.Text = "";
                bt_agregar.Text = "AGREGAR";
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("''");
                campos.Add("1");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
            }
            else if (this.Text.Equals("AGREGAR-BARRIO"))
            {
                gb_codigo.Enabled = false;
                gb_codigo2.Enabled = true;
                gb_codigo2.Text = "Sector";
                bt_agregar.Text = "AGREGAR";
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("''");
                campos.Add("2");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
            }
            else if (this.Text.Equals("AGREGAR-LUGAR"))
            {
                gb_codigo.Enabled = false;
                gb_codigo2.Enabled = true;
                gb_codigo2.Text = "Barrio";
                bt_agregar.Text = "AGREGAR";
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("''");
                campos.Add("3");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
            }
        }

        public void agregarDatos(int id, string nombre)
        {
            id2 = id;
            txt_codigo2.Text = nombre;
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("AGREGAR-SECTOR"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("'"+txt_nombre.Text+"'");
                List<Capsula> m = conn.insertar("sp_insertar_sector", campos);
                conn.cerrar();
                foreach (Capsula r in m)
                {
                    MessageBox.Show(r.getCampos()[0]);
                }
            }
            else if (this.Text.Equals("AGREGAR-BARRIO"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("'" + txt_nombre.Text + "'");
                List<Capsula> m = conn.insertar("sp_insertar_sector", campos);
                conn.cerrar();
                foreach (Capsula r in m)
                {
                    MessageBox.Show(r.getCampos()[0]);
                }
            }
            else if (this.Text.Equals("AGREGAR-LUGAR"))
            {

            }
            limpiar();
        }

        private void bt_codigo2_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("AGREGAR-BARRIO"))
            {
                Program.ubicacionElegir = new UbicacionElegir();
                Program.ubicacionElegir.Text = "ELEGIR-SECTOR";
                Program.ubicacionElegir.Show();
                Program.ubicacionElegir.Focus();
            }
            else if (this.Text.Equals("AGREGAR-LUGAR"))
            {
                Program.ubicacionElegir = new UbicacionElegir();
                Program.ubicacionElegir.Text = "ELEGIR-BARRIO";
                Program.ubicacionElegir.Show();
                Program.ubicacionElegir.Focus();
            }
        }
    }
}
