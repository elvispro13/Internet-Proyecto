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
        public Form retorno;
        private int row = -1;
        public int id = -1, id_cliente = -1;
        public String ruta;
        List<bool> In = new List<bool>();

        public PaquetesElegir()
        {
            InitializeComponent();
        }

        private void PaquetesElegir_Load(object sender, EventArgs e)
        {
            if (this.Text.Contains("SERVICIOS"))
            {
                gb_instalacion.Enabled = false;
                gb_instalacion.Visible = false;
                gb_ip.Enabled = false;
                gb_ip.Visible = false;
            }
            Program.menu.addRuta(ruta);
        }

        private void buscar()
        {
            if (this.Text.Contains("SERVICIOS"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                if (txt_buscar.Text.Equals(""))
                {
                    campos.Add("' '");
                }
                else
                {
                    campos.Add("'" + txt_buscar.Text + "'");
                }
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

                dgv_tabla.MultiSelect = true;

                dgv_tabla.ClearSelection();
                dgv_tabla.TabIndex = 1;
                In.Clear();
                for (int i = 0; i < dgv_tabla.Rows.Count; i++)
                {
                    bool re = false;
                    foreach (Capsula r in lista)
                    {
                        if (dgv_tabla.Rows[i].Cells[0].Value.ToString().Equals(r.getCampos()[0]))
                        {
                            dgv_tabla.Rows[i].Selected = true;
                            re = true;
                            break;
                        }
                    }
                    In.Add(re);
                }
            }
            else if (this.Text.Contains("PAQUETES"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                if (txt_buscar.Text.Equals(""))
                {
                    campos.Add("' '");
                }
                else
                {
                    campos.Add("'" + txt_buscar.Text + "'");
                }
                campos.Add("2");
                conn.llenarTabla("sp_buscar_paquetes", campos, dgv_tabla);
                conn.cerrar();

                dgv_tabla.Columns["idpaquete"].Visible = false;

                dgv_tabla.ClearSelection();
                dgv_tabla.TabIndex = 1;
                dgv_tabla.MultiSelect = false;

                ConexionDB conn2 = new ConexionDB();
                conn2.abrir();
                List<string> campos2 = new List<string>();
                campos2.Add("1");
                List<Capsula> rows2 = conn2.consultar("sp_obtener_ip", campos2);
                conn2.cerrar();
                if (rows2.Count == 0 || rows2[0].getCampos()[0].Equals(""))
                {
                    return;
                }
                txt_ip.Text = Program.menu.getIP(rows2[0].getCampos()[0]);
            }


            for (int i = 0; i < dgv_tabla.Columns.Count; i++)
            {
                string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                dgv_tabla.Columns[i].HeaderText = t;
            }

            addFuente(Program.menu.fuente);
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
                if(txt_ip.Text.Equals("") || txt_intalacion.Text.Equals(""))
                {
                    MessageBox.Show("Llene los campos.");
                    return;
                }
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
                        campos2.Add("'" + txt_ip.Text + "'");
                        campos2.Add("" + txt_intalacion.Text);
                        conn2.insertar("sp_insertar_clientepaquete", campos2);
                        conn2.cerrar();
                    }
                    MessageBox.Show("Todo listo.");
                }
                else
                {
                    MessageBox.Show("Elija un paquete");
                }
                Program.clientesPaquetes.limpiar();
            }
            Close();
            Program.menu.removeRuta(ruta);
            Program.menu.AbrirFormEnPanel(retorno);
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Program.menu.removeRuta(ruta);
            Program.menu.AbrirFormEnPanel(retorno);
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

        private void txt_buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                buscar();
            }
        }

        private void txt_intalacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_intalacion_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                row = dgv_tabla.CurrentRow.Index;
                if(dgv_tabla.MultiSelect == true)
                {
                    dgv_tabla.ClearSelection();
                    if (In[row] == true)
                    {
                        In[row] = false;
                    }
                    else
                    {
                        In[row] = true;
                    }
                    int con = 0;
                    foreach(bool i in In)
                    {
                        dgv_tabla.Rows[con].Selected = i;
                        con++;
                    }
                }
            }
        }
    }
}
