using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.Paquetes
{
    public partial class PaquetesElegir : Form
    {
        public int id = -1;

        public PaquetesElegir()
        {
            InitializeComponent();
        }

        private void PaquetesElegir_Load(object sender, EventArgs e)
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("' '");
            campos.Add("1");
            conn.llenarTabla("sp_buscar_paquetes", campos, dgv_tabla);
            conn.cerrar();

            ConexionDB conn2 = new ConexionDB();
            conn2.abrir();
            List<string> campos2 = new List<string>();
            campos2.Add("'" + id + "'");
            campos2.Add("4");
            List<Capsula> lista = conn2.consultar("sp_buscar_paquetes", campos2);
            conn2.cerrar();

            for (int i = 0; i < dgv_tabla.Rows.Count; i++)
            {
                dgv_tabla.Rows[i].Selected = false;
                foreach (Capsula r in lista)
                {
                    if (dgv_tabla.Rows[i].Cells[0].Value.ToString().Equals(r.getCampos()[0]))
                    {
                        dgv_tabla.Rows[i].Selected = true;
                    }
                }
            }
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("2");
            campos.Add(""+id);
            conn.insertar("sp_insertar_serviciopaquete", campos);
            conn.cerrar();
            Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRowCount > 0)
            {
                for (int i = 0; i < dgv_tabla.SelectedRows.Count; i++)
                {
                    ConexionDB conn2 = new ConexionDB();
                    conn2.abrir();
                    List<string> campos2 = new List<string>();
                    campos2.Add("1");
                    campos2.Add("" + id);
                    campos2.Add("" + dgv_tabla.SelectedRows[i].Cells[0].Value.ToString());
                    conn2.insertar("sp_insertar_serviciopaquete", campos2);
                    conn2.cerrar();
                }
                MessageBox.Show("Todo listo.");
            }
            Close();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tabla.Rows[e.RowIndex].Selected)
            {
                dgv_tabla.Rows[e.RowIndex].Selected = false;
            }
            else
            {
                dgv_tabla.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
