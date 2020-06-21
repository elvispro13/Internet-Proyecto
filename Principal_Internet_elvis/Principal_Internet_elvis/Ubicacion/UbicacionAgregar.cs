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
            if (this.Text.Equals("AGREGAR-SECTOR") || this.Text.Equals("BUSCAR-SECTOR") || this.Text.Equals("MODIFICAR-SECTOR"))
            {
                gb_codigo.Enabled = false;
                gb_codigo2.Enabled = false;
                gb_codigo2.Text = "";
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("''");
                campos.Add("1");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
                dgv_tabla.Columns[0].Visible = false;
            }
            else if (this.Text.Equals("AGREGAR-BARRIO") || this.Text.Equals("BUSCAR-BARRIO") || this.Text.Equals("MODIFICAR-BARRIO"))
            {
                gb_codigo.Enabled = false;
                gb_codigo2.Enabled = true;
                gb_codigo2.Text = "Sector";
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("''");
                campos.Add("2");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
                dgv_tabla.Columns[0].Visible = false;
                dgv_tabla.Columns[1].Visible = false;
            }
            else if (this.Text.Equals("AGREGAR-LUGAR") || this.Text.Equals("BUSCAR-LUGAR") || this.Text.Equals("MODIFICAR-LUGAR"))
            {
                gb_codigo.Enabled = false;
                gb_codigo2.Enabled = true;
                gb_codigo2.Text = "Barrio";
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("''");
                campos.Add("3");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
                dgv_tabla.Columns[0].Visible = false;
                dgv_tabla.Columns[1].Visible = false;
            }
            id2 = 0;
            txt_codigo2.Text = "";
            txt_nombre.Text = "";
            txt_codigo.Text = "";
        }

        public void agregarDatos(int id, string nombre)
        {
            id2 = id;
            txt_codigo2.Text = nombre;
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            botonAceptar();
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

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                botonAceptar();
            }
        }

        private void botonAceptar()
        {
            if (this.Text.Equals("AGREGAR-SECTOR"))
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
                limpiar();
            }
            else if (this.Text.Equals("AGREGAR-BARRIO"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("" + id2 + "");
                campos.Add("'" + txt_nombre.Text + "'");
                List<Capsula> m = conn.insertar("sp_insertar_barrio", campos);
                conn.cerrar();
                foreach (Capsula r in m)
                {
                    MessageBox.Show(r.getCampos()[0]);
                }
                limpiar();
            }
            else if (this.Text.Equals("AGREGAR-LUGAR"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("" + id2 + "");
                campos.Add("'" + txt_nombre.Text + "'");
                List<Capsula> m = conn.insertar("sp_insertar_lugar", campos);
                conn.cerrar();
                foreach (Capsula r in m)
                {
                    MessageBox.Show(r.getCampos()[0]);
                }
                limpiar();
            }
            else if (this.Text.Equals("BUSCAR-SECTOR"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("'"+txt_nombre.Text+"'");
                campos.Add("1");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
            }
            else if (this.Text.Equals("BUSCAR-BARRIO"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("'" + txt_nombre.Text + "'");
                campos.Add("2");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
            }
            else if (this.Text.Equals("BUSCAR-LUGAR"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("'" + txt_nombre.Text + "'");
                campos.Add("3");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
            }
        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && Text.Contains("MODIFICAR"))
            {
                int row = dgv_tabla.CurrentRow.Index;
                seleccionar(row);
            }
        }

        private void seleccionar(int row)
        {
            txt_nombre.Text = dgv_tabla.Rows[row].Cells[0].Value.ToString();
        }
    }
}
