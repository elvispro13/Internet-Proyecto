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
        public int id = -1, id_cliente = -1;
        List<int> In = new List<int>();

        public PaquetesElegir()
        {
            InitializeComponent();
        }

        private void PaquetesElegir_Load(object sender, EventArgs e)
        {
            if (this.Text.Contains("SERVICIOS"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("' '");
                campos.Add("1");
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

                dgv_tabla.ClearSelection();
                In.Clear();
                for (int i = 0; i < dgv_tabla.Rows.Count; i++)
                {
                    foreach (Capsula r in lista)
                    {
                        if (dgv_tabla.Rows[i].Cells[0].Value.ToString().Equals(r.getCampos()[0]))
                        {
                            dgv_tabla.Rows[i].Selected = true;
                            In.Add(i);
                        }
                    }
                }
            }
            else if (this.Text.Contains("PAQUETES"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("' '");
                campos.Add("2");
                conn.llenarTabla("sp_buscar_paquetes", campos, dgv_tabla);
                conn.cerrar();
                dgv_tabla.ClearSelection();

                dgv_tabla.Columns["idpaquete"].Visible = false;
            }
            

            for (int i = 0; i < dgv_tabla.Columns.Count; i++)
            {
                string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                dgv_tabla.Columns[i].HeaderText = t;
            }

            addFuente(Program.principal.fuente);
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            if (this.Text.Contains("SERVICIOS"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("2");
                campos.Add("" + id);
                conn.insertar("sp_insertar_serviciopaquete", campos);
                conn.cerrar();
                Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
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
            }
            else if (this.Text.Contains("PAQUETES"))
            {
                Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < dgv_tabla.SelectedRows.Count; i++)
                    {
                        ConexionDB conn2 = new ConexionDB();
                        conn2.abrir();
                        List<string> campos2 = new List<string>();
                        campos2.Add("1");
                        campos2.Add("" + dgv_tabla.SelectedRows[i].Cells["idpaquete"].Value.ToString());
                        campos2.Add("" + id_cliente);
                        campos2.Add("'" + dgv_tabla.SelectedRows[i].Cells["descripcion"].Value.ToString() + "'");
                        campos2.Add("" + dgv_tabla.SelectedRows[i].Cells["descuento"].Value.ToString());
                        conn2.insertar("sp_insertar_clientepaquete", campos2);
                        conn2.cerrar();
                    }
                    MessageBox.Show("Todo listo.");
                }
                Program.clientesPaquetes.limpiar();
            }
            Close();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void addFuente(Font f)
        {
            foreach (Button e in Program.GetAllChildren(this).OfType<Button>())
            {
                e.Font = f;
            }

            foreach (GroupBox e in Program.GetAllChildren(this).OfType<GroupBox>())
            {
                e.Font = f;
            }

            foreach (TextBox e in Program.GetAllChildren(this).OfType<TextBox>())
            {
                e.Font = f;
            }

            foreach (DateTimePicker e in Program.GetAllChildren(this).OfType<DateTimePicker>())
            {
                e.Font = f;
            }

            foreach (DataGridView e in Program.GetAllChildren(this).OfType<DataGridView>())
            {
                e.Font = f;
            }
        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dgv_tabla.CurrentRow.Index;

            dgv_tabla.Rows[n].Selected = false;

            dgv_tabla.ClearSelection();

            if (In.Contains(n))
            {
                In.Remove(n);
            }
            else
            {
                In.Add(n);
            }

            foreach (int i in In)
            {
                dgv_tabla.Rows[i].Selected = true;
            }
        }
    }
}
