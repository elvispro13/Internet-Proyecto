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
    public partial class UbicacionTipo : Form
    {
        public UbicacionTipo()
        {
            InitializeComponent();
        }

        private void bt_sector_Click(object sender, EventArgs e)
        {
            Program.ubicacionAgregar = new UbicacionAgregar();
            Program.ubicacionAgregar.Text = "SECTORES";
            Program.ubicacionAgregar.Show();
            Program.ubicacionAgregar.Focus();
        }

        private void bt_barrio_Click(object sender, EventArgs e)
        {
            Program.ubicacionAgregar = new UbicacionAgregar();
            Program.ubicacionAgregar.Text = "BARRIOS";
            Program.ubicacionAgregar.Show();
            Program.ubicacionAgregar.Focus();
        }

        private void bt_lugar_Click(object sender, EventArgs e)
        {
            Program.ubicacionAgregar = new UbicacionAgregar();
            Program.ubicacionAgregar.Text = "LUGARES";
            Program.ubicacionAgregar.Show();
            Program.ubicacionAgregar.Focus();
        }

        private void UbicacionTipo_Load(object sender, EventArgs e)
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("' '");
            campos.Add("4");
            conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
            conn.cerrar();
            dgv_tabla.Columns[0].Visible = false;
            dgv_tabla.Columns[1].Visible = false;
            dgv_tabla.Columns[2].Visible = false;
            dgv_tabla.Columns[6].Visible = false;
            dgv_tabla.Columns[7].Visible = false;
            dgv_tabla.Columns[8].Visible = false;
            dgv_tabla.Columns[9].Visible = false;
            dgv_tabla.Columns[10].Visible = false;

            for (int i = 0; i < dgv_tabla.Columns.Count; i++)
            {
                string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                dgv_tabla.Columns[i].HeaderText = t;
            }

            dgv_tabla.ClearSelection();

            addFuente(Program.principal.fuente);
        }

        private void txt_buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
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
                dgv_tabla.Columns[0].Visible = false;
                dgv_tabla.Columns[1].Visible = false;
                dgv_tabla.Columns[2].Visible = false;
                dgv_tabla.Columns[6].Visible = false;
                dgv_tabla.Columns[7].Visible = false;
                dgv_tabla.Columns[8].Visible = false;

                for (int i = 0; i < dgv_tabla.Columns.Count; i++)
                {
                    string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                    dgv_tabla.Columns[i].HeaderText = t;
                }
            }
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

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
