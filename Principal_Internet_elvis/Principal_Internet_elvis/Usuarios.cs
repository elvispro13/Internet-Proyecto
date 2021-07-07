using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis
{
    public partial class Usuarios : Form
    {
        public Form retorno;
        public String ruta = "";

        private int row = -1, estado = -1, idl = -1;

        private void Usuarios_Load(object sender, EventArgs e)
        {
            bt_eliminar.Enabled = false;
            tm_inicio.Enabled = true;
        }

        private void tm_inicio_Tick(object sender, EventArgs e)
        {
            limpiar();
            tm_inicio.Enabled = false;
        }

        public Usuarios()
        {
            InitializeComponent();
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
            int codigo = int.Parse(dgv_tabla.Rows[row].Cells["idusuario"].Value.ToString());
            txt_codigo.Text = codigo.ToString("D10");
            txt_nombre.Text = dgv_tabla.Rows[row].Cells["nombre"].Value.ToString();
            txt_dni.Text = dgv_tabla.Rows[row].Cells["dni"].Value.ToString();
            txt_telefono.Text = dgv_tabla.Rows[row].Cells["telefono"].Value.ToString();
            txt_descp.Text = dgv_tabla.Rows[row].Cells["descripcion"].Value.ToString();
            txt_usuario.Text = dgv_tabla.Rows[row].Cells["usuario"].Value.ToString();
            txt_clave.Text = dgv_tabla.Rows[row].Cells["clave"].Value.ToString();
            estado = int.Parse(dgv_tabla.Rows[row].Cells["estado"].Value.ToString());

            bt_eliminar.Enabled = true;
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Program.menu.removeRuta(ruta);
            Program.menu.AbrirFormEnPanel(retorno);
            Close();
        }

        private void bt_crear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (row == -1)
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();

                campos.Add("'" + txt_usuario.Text + "'");
                campos.Add("'" + txt_clave.Text + "'");
                campos.Add("'" + txt_descp.Text + "'");
                campos.Add("'" + txt_nombre.Text + "'");
                campos.Add("" + Program.menu.ide);
                campos.Add("'" + txt_dni.Text + "'");
                campos.Add("'" + txt_telefono.Text + "'");
                List<Capsula> m = conn.insertar("sp_insetar_usuario", campos);
                conn.cerrar();
                foreach (Capsula r in m)
                {
                    MessageBox.Show(r.getCampos()[0]);
                }
            }
            else
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("" + int.Parse(txt_codigo.Text));
                campos.Add("'" + txt_usuario.Text + "'");
                campos.Add("'" + txt_clave.Text + "'");
                campos.Add("'" + txt_descp.Text + "'");
                campos.Add("'" + txt_nombre.Text + "'");
                campos.Add("" + Program.menu.ide);
                campos.Add("'" + txt_dni.Text + "'");
                campos.Add("'" + txt_telefono.Text + "'");
                List<Capsula> m = conn.insertar("sp_modificar_usuario", campos);
                conn.cerrar();
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

        private void buscar()
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("'" + txt_nombre.Text + "'");
            if (cb_inactivos.Checked == false)
            {
                campos.Add("1");
            }
            else
            {
                campos.Add("0");
            }
            conn.llenarTabla("sp_buscar_usuarios_admin", campos, dgv_tabla);
            conn.cerrar();

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
        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                buscar();
            }
        }

        private void cb_inactivos_CheckedChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (row == -1)
            {
                MessageBox.Show("Elija un registro");
                return;
            }
            ConexionDB conn2 = new ConexionDB();
            conn2.abrir();
            List<string> campos2 = new List<string>();
            campos2.Add("" + int.Parse(txt_codigo.Text));
            campos2.Add("1");
            if (estado == 1)
            {
                campos2.Add("0");
            }
            else
            {
                campos2.Add("1");
            }
            List<Capsula> m = conn2.insertar("sp_estado_usuario", campos2);
            conn2.cerrar();
            foreach (Capsula r in m)
            {
                MessageBox.Show(r.getCampos()[0]);
            }
            limpiar();
        }

        private void bt_elegir_roles_Click(object sender, EventArgs e)
        {
            if (row == -1)
            {
                MessageBox.Show("Elija un registro");
                return;
            }
            Program.permisos = new Permisos();
            Program.permisos.Text = "PERMISOS";
            Program.permisos.ruta = "Permisos";
            Program.permisos.retorno = this;
            Program.permisos.idu = int.Parse(txt_codigo.Text);
            Program.menu.AbrirFormEnPanel(Program.permisos);
        }

        private void limpiar()
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("' '");
            if (cb_inactivos.Checked == false)
            {
                campos.Add("1");
            }
            else
            {
                campos.Add("0");
            }
            conn.llenarTabla("sp_buscar_usuarios_admin", campos, dgv_tabla);
            conn.cerrar();

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
            row = -1;
            estado = -1;
            addFuente(Program.menu.fuente);
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
        }
    }
}
