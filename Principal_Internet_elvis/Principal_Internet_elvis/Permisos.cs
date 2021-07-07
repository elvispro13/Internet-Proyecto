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
    public partial class Permisos : Form
    {
        public Form retorno;
        public String ruta = "";
        public int idu = -1;

        public Permisos()
        {
            InitializeComponent();
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            tm_inicio.Enabled = true;
        }

        private void cargar()
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add(""+idu);
            conn.llenarTabla("sp_obtener_permisos", campos, dgv_tabla);
            conn.cerrar();

            for (int i = 0; i < dgv_tabla.Columns.Count; i++)
            {
                string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                dgv_tabla.Columns[i].HeaderText = t;
            }

            dgv_tabla.Columns[0].ReadOnly = true;
            dgv_tabla.Columns[2].ReadOnly = true;
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Program.menu.removeRuta(ruta);
            Program.menu.AbrirFormEnPanel(retorno);
            Close();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            string permisos = "";
            for (int i = 0; i < dgv_tabla.Rows.Count; i++)
            {
                if (dgv_tabla.Rows[i].Cells["estado"].Value.ToString().Equals("True"))
                {
                    permisos += dgv_tabla.Rows[i].Cells["idp"].Value.ToString()+",";
                }
            }
            if(permisos.Length > 0)
            {
                permisos = permisos.Remove(permisos.Length - 1);
            }

            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("'" + permisos + "'");
            campos.Add("" + idu);
            List<Capsula> m = conn.insertar("sp_asignar_permisos", campos);
            conn.cerrar();
            foreach (Capsula r in m)
            {
                MessageBox.Show(r.getCampos()[0]);
            }
        }

        private void tm_inicio_Tick(object sender, EventArgs e)
        {
            tm_inicio.Enabled = false;
            cargar();
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
