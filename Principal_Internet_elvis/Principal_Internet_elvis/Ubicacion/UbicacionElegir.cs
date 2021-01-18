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
            int row = dgv_tabla.CurrentRow.Index;
            int id = 0;
            string nombre = "";

            if (this.Text.Equals("ELEGIR-SECTOR"))
            {
                id = Int32.Parse(dgv_tabla.Rows[row].Cells[0].Value.ToString());
                nombre = dgv_tabla.Rows[row].Cells[1].Value.ToString();
                Program.ubicacionAgregar.agregarDatos(id, nombre);
            }
            else if (this.Text.Equals("ELEGIR-BARRIO"))
            {
                id = Int32.Parse(dgv_tabla.Rows[row].Cells[0].Value.ToString());
                nombre = dgv_tabla.Rows[row].Cells[2].Value.ToString();
                Program.ubicacionAgregar.agregarDatos(id, nombre);
            }
            else if (this.Text.Equals("ELEGIR-LUGAR"))
            {
                id = Int32.Parse(dgv_tabla.Rows[row].Cells["idlugar"].Value.ToString());
                nombre = dgv_tabla.Rows[row].Cells["lugar"].Value.ToString();
                Program.clientes.agregarDatos(id, nombre);
            }
            this.Close();
        }

        private void UbicacionElegir_Load(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            if (this.Text.Equals("ELEGIR-SECTOR"))
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
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
                dgv_tabla.Columns[0].Visible = false;
            }
            else if (this.Text.Equals("ELEGIR-BARRIO"))
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
                campos.Add("1");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
                dgv_tabla.Columns[0].Visible = false;
                dgv_tabla.Columns[1].Visible = false;
            }
            else if (this.Text.Equals("ELEGIR-LUGAR"))
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
                campos.Add("4");
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
                dgv_tabla.Columns["idlugar"].Visible = false;
                dgv_tabla.Columns["idbarrio"].Visible = false;
                dgv_tabla.Columns["idsector"].Visible = false;
                dgv_tabla.Columns["estado1"].Visible = false;
                dgv_tabla.Columns["estado2"].Visible = false;
                dgv_tabla.Columns["estado3"].Visible = false;
            }

            for (int i = 0; i < dgv_tabla.Columns.Count; i++)
            {
                string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                dgv_tabla.Columns[i].HeaderText = t;
            }

            dgv_tabla.ClearSelection();

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
                buscar();
            }
        }
    }
}
