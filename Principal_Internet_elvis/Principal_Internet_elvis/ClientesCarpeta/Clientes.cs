using Principal_Internet_elvis.Paquetes;
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

namespace Principal_Internet_elvis.ClientesCarpeta
{
    public partial class Clientes : Form
    {
        private int row = -1, estado = -1, idl=-1;

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            if (this.Text.Contains("CLIENTE"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("' '");
                conn.llenarTabla("sp_buscar_clientes", campos, dgv_tabla);
                conn.cerrar();
            }

            dgv_tabla.ClearSelection();

            for (int i = 0; i < dgv_tabla.Rows.Count; i++)
            {
                if (dgv_tabla.Rows[i].Cells["estado"].Value.ToString().Equals("1"))
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                dgv_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
            }
            for (int i = 0; i < dgv_tabla.Columns.Count; i++)
            {
                string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                dgv_tabla.Columns[i].HeaderText = t;
            }

            foreach (TextBox e in Program.GetAllChildren(this).OfType<TextBox>())
            {
                e.Text = "";
            }

            bt_eliminar.Enabled = false;

            txt_nombre.Select();
            rb_femenino.Checked = true;
            row = -1;
            estado = -1;
            addFuente(Program.menu.fuente);
        }

        public void agregarDatos(int id, string nombre)
        {
            txt_lugar.Text = nombre;
            idl = id;
        }

        private void bt_lugar_Click(object sender, EventArgs e)
        {
            Program.ubicacionElegir = new UbicacionElegir();
            Program.ubicacionElegir.Text = "ELEGIR-LUGAR";
            Program.ubicacionElegir.ruta = "Elegir lugar";
            Program.menu.AbrirFormEnPanel(Program.ubicacionElegir);
        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                row = dgv_tabla.CurrentRow.Index;
                seleccionar();
            }
        }

        private void seleccionar()
        {
            txt_codigo.Text = dgv_tabla.Rows[row].Cells["idcliente"].Value.ToString();
            txt_nombre.Text = dgv_tabla.Rows[row].Cells["nombre"].Value.ToString();
            txt_rtn.Text = dgv_tabla.Rows[row].Cells["rtn"].Value.ToString();
            txt_telefono.Text = dgv_tabla.Rows[row].Cells["telefono"].Value.ToString();
            txt_correo.Text = dgv_tabla.Rows[row].Cells["correo"].Value.ToString();
            txt_direccion.Text = dgv_tabla.Rows[row].Cells["direccion"].Value.ToString();
            txt_lugar.Text = dgv_tabla.Rows[row].Cells["lugar"].Value.ToString();
            estado = int.Parse(dgv_tabla.Rows[row].Cells["estado"].Value.ToString());
            idl = int.Parse(dgv_tabla.Rows[row].Cells["idlugar"].Value.ToString());
            dtp_fecha.Value = DateTime.Parse(dgv_tabla.Rows[row].Cells["fecha"].Value.ToString());
            if (int.Parse(dgv_tabla.Rows[row].Cells["genero"].Value.ToString()) == 0)
            {
                rb_femenino.Checked = true;
            }
            else
            {
                rb_masculino.Checked = true;
            }

            bt_eliminar.Enabled = true;
        }

        private void bt_paquetes_Click(object sender, EventArgs e)
        {
            if (row != -1)
            {
                Program.clientesPaquetes = new ClientesPaquetes();
                Program.clientesPaquetes.id = int.Parse(txt_codigo.Text);
                Program.clientesPaquetes.cliente = txt_nombre.Text + " - " + txt_rtn.Text;
                Program.menu.AbrirFormEnPanel(Program.clientesPaquetes);
            }
            else
            {
                MessageBox.Show("Debe elegir un cliente");
            }
        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                buscar();
            }
        }

        private void buscar()
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("'" + txt_nombre.Text + "'");
            //campos.Add("1");
            conn.llenarTabla("sp_buscar_clientes", campos, dgv_tabla);
            conn.cerrar();
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            if (row == -1)
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("'" + txt_nombre.Text + "'");
                campos.Add("'" + txt_rtn.Text + "'");
                campos.Add("'" + txt_telefono.Text + "'");
                if (rb_femenino.Checked)
                {
                    campos.Add("0");
                }
                else
                {
                    campos.Add("1");
                }
                campos.Add("'" + txt_correo.Text + "'");
                campos.Add("'" + dtp_fecha.Value.ToString("yyyy/MM/dd") + "'");
                campos.Add("'" + txt_direccion.Text + "'");
                campos.Add("" + idl);
                List<Capsula> m = conn.insertar("sp_insertar_cliente", campos);
                conn.cerrar();
                foreach (Capsula r in m)
                {
                    MessageBox.Show(r.getCampos()[0]);
                }
            }
            else
            {
                ConexionDB conn2 = new ConexionDB();
                conn2.abrir();
                List<string> campos2 = new List<string>();
                campos2.Add("" + txt_codigo.Text);
                campos2.Add("'" + txt_nombre.Text + "'");
                campos2.Add("'" + txt_rtn.Text + "'");
                campos2.Add("'" + txt_telefono.Text + "'");
                if (rb_femenino.Checked)
                {
                    campos2.Add("0");
                }
                else
                {
                    campos2.Add("1");
                }
                campos2.Add("'" + txt_correo.Text + "'");
                campos2.Add("'" + dtp_fecha.Value.ToString("yyyy/MM/dd") + "'");
                campos2.Add("'" + txt_direccion.Text + "'");
                campos2.Add("" + idl);
                List<Capsula> m = conn2.insertar("sp_modificar_cliente", campos2);
                conn2.cerrar();
                foreach (Capsula r in m)
                {
                    MessageBox.Show(r.getCampos()[0]);
                }
            }
            limpiar();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            ConexionDB conn2 = new ConexionDB();
            conn2.abrir();
            List<string> campos2 = new List<string>();
            campos2.Add("" + txt_codigo.Text);
            campos2.Add("1");
            if (estado == 1)
            {
                campos2.Add("0");
            }
            else
            {
                campos2.Add("1");
            }
            List<Capsula> m = conn2.insertar("sp_estado_cliente", campos2);
            conn2.cerrar();
            foreach (Capsula r in m)
            {
                MessageBox.Show(r.getCampos()[0]);
            }
            limpiar();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Program.menu.bt_inicio_Click(null, null);
            Close();
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
    }
}
