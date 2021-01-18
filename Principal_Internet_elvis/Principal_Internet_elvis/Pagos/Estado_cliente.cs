using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.Configuraciones
{
    public partial class Estado_cliente : Form
    {
        private int row = -1, idcleintepa = -1;

        public Estado_cliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Estado_cliente_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        public void accesoRapido(string n)
        {
            txt_buscar.Text = n;
        }

        private void limpiar()
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("0");
            campos.Add("1");
            campos.Add("'" + txt_buscar.Text + "'");
            conn.llenarTabla("sp_buscar_clientepaquete", campos, dgv_tabla);
            conn.cerrar();

            dgv_tabla.ClearSelection();
            dgv_tabla.TabIndex = 1;

            for (int i = 0; i < dgv_tabla.Rows.Count; i++)
            {
                if (dgv_tabla.Rows[i].Cells["estadoservicio"].Value.ToString().Equals("PENDIENTE INSTALACION"))
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dgv_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (dgv_tabla.Rows[i].Cells["estadoservicio"].Value.ToString().Equals("SERVICIO ACTIVO"))
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgv_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dgv_tabla.Rows[i].Cells["estadoservicio"].Value.ToString().Equals("CORTE DE SERVICIO"))
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgv_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }

            dgv_tabla.Columns["idcliente"].Visible = false;
            dgv_tabla.Columns["idlugar"].Visible = false;
            dgv_tabla.Columns["idclientepa"].Visible = false;
            dgv_tabla.Columns["estado"].Visible = false;

            for (int i = 0; i < dgv_tabla.Columns.Count; i++)
            {
                string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                dgv_tabla.Columns[i].HeaderText = t;
            }


            row = -1;
            txt_descripcion.Text = "";
            cb_estado.Text = "";
            txt_buscar.Select();

            addFuente(Program.principal.fuente);
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
                limpiar();
            }       
        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                row = dgv_tabla.CurrentRow.Index;

                cb_estado.Text = dgv_tabla.Rows[row].Cells["estadoservicio"].Value.ToString();
                idcleintepa = int.Parse(dgv_tabla.Rows[row].Cells["idclientepa"].Value.ToString());
                txt_descripcion.Select();
            }
        }

        private void bt_estado_Click(object sender, EventArgs e)
        {
            if(txt_descripcion.Text == "")
            {
                MessageBox.Show("Escriba una nota");
                return;
            }
            ConexionDB conn2 = new ConexionDB();
            conn2.abrir();
            List<string> campos2 = new List<string>();
            campos2.Add("" + idcleintepa);
            campos2.Add("2");
            campos2.Add("0");
            campos2.Add("'" + cb_estado.Text + "'");
            campos2.Add("'" + txt_descripcion.Text + "'");
            List<Capsula> m = conn2.insertar("sp_estado_cliente", campos2);
            conn2.cerrar();
            foreach (Capsula r in m)
            {
                MessageBox.Show(r.getCampos()[0]);
            }
            limpiar();
        }
    }
}
