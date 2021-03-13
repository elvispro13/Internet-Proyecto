using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Principal_Internet_elvis;
using Principal_Internet_elvis.ClientesCarpeta;
using Principal_Internet_elvis.Configuraciones;
using Principal_Internet_elvis.FormmGenerales;
using Principal_Internet_elvis.Pagos;
using Principal_Internet_elvis.Paquetes;
using Principal_Internet_elvis.Reportes;
using Principal_Internet_elvis.Ubicacion;
using Proyecto_Internet;

namespace Principal_Internet_elvis
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void actualizar()
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("0");
            campos.Add("2");
            campos.Add("''");
            conn.llenarTabla("sp_buscar_clientepaquete", campos, dgv_pendientes);
            conn.cerrar();

            for (int i = 0; i < dgv_pendientes.Rows.Count; i++)
            {
                if (dgv_pendientes.Rows[i].Cells["estadoservicio"].Value.ToString().Equals("PENDIENTE INSTALACION"))
                {
                    dgv_pendientes.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dgv_pendientes.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < dgv_pendientes.Columns.Count; i++)
            {
                string t = dgv_pendientes.Columns[i].HeaderText.ToUpper();
                dgv_pendientes.Columns[i].HeaderText = t;
            }

            dgv_pendientes.ClearSelection();
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void dgv_pendientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_pendientes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int row = dgv_pendientes.CurrentRow.Index;

                Program.estado_Cliente = new Estado_cliente();
                Program.estado_Cliente.accesoRapido(dgv_pendientes.Rows[row].Cells["rtn"].Value.ToString());
                Program.estado_Cliente.Text = "ESTADO-CLIENTES";
                Program.menu.setRuta("CONTRATOS/");
                Program.menu.AbrirFormEnPanel(Program.estado_Cliente);
            }
        }

        private void tm_inicio_Tick(object sender, EventArgs e)
        {
            actualizar();
            tm_inicio.Enabled = false;
        }
    }
}
