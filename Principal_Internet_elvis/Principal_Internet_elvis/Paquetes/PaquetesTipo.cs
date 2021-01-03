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
    public partial class PaquetesTipo : Form
    {
        public PaquetesTipo()
        {
            InitializeComponent();
        }

        private void bt_paquete_Click(object sender, EventArgs e)
        {
            Program.paquetesAgregar = new PaquetesAgregar();
            Program.paquetesAgregar.Text = "PAQUETE";
            Program.paquetesAgregar.Show();
            Program.paquetesAgregar.Focus();
        }

        private void bt_servicio_Click(object sender, EventArgs e)
        {
            Program.paquetesAgregar = new PaquetesAgregar();
            Program.paquetesAgregar.Text = "SERVICIO";
            Program.paquetesAgregar.Show();
            Program.paquetesAgregar.Focus();
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
                campos.Add("3");
                conn.llenarTabla("sp_buscar_paquetes", campos, dgv_tabla);
                conn.cerrar();

                for (int i = 0; i < dgv_tabla.Columns.Count; i++)
                {
                    string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                    dgv_tabla.Columns[i].HeaderText = t;
                }
            }
        }

        private void PaquetesTipo_Load(object sender, EventArgs e)
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("' '");
            campos.Add("3");
            conn.llenarTabla("sp_buscar_paquetes", campos, dgv_tabla);
            conn.cerrar();

            dgv_tabla.ClearSelection();

            for (int i = 0; i < dgv_tabla.Columns.Count; i++)
            {
                string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                dgv_tabla.Columns[i].HeaderText = t;
            }

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

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
