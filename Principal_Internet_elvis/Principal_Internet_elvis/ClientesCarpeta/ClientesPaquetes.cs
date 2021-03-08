using Principal_Internet_elvis.Paquetes;
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
    public partial class ClientesPaquetes : Form
    {
        public int row = -1, id;
        public String cliente = "";

        public ClientesPaquetes()
        {
            InitializeComponent();
        }

        private void ClientesPaquetes_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("" + id);
            conn.llenarTabla("sp_buscar_clientepaquete", campos, dgv_tabla);
            conn.cerrar();

            dgv_tabla.Columns[0].Visible = false;
            dgv_tabla.Columns[1].Visible = false;

            for (int i = 0; i < dgv_tabla.Rows.Count; i++)
            {
                if (dgv_tabla.Rows[i].Cells["estado"].Value.ToString().Equals("PENDIENTE INSTALACION"))
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dgv_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (dgv_tabla.Rows[i].Cells["estado"].Value.ToString().Equals("SERVICIO ACTIVO"))
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgv_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dgv_tabla.Rows[i].Cells["estado"].Value.ToString().Equals("CORTE DE SERVICIO"))
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgv_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }

            for (int i = 0; i < dgv_tabla.Columns.Count; i++)
            {
                string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                dgv_tabla.Columns[i].HeaderText = t;
            }

            dgv_tabla.ClearSelection();
            dgv_tabla.TabIndex = 1;

            addFuente(Program.menu.fuente);
            Program.menu.addRuta("Paquetes contratados por: " + cliente + "/");
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            Program.paquetesElegir = new PaquetesElegir();
            Program.paquetesElegir.Text = "ELEGIR-PAQUETES";
            Program.paquetesElegir.ruta = "Elgir paquete/";
            Program.paquetesElegir.retorno = Program.clientesPaquetes;
            Program.paquetesElegir.id_cliente = id;
            Program.menu.AbrirFormEnPanel(Program.paquetesElegir);
        }

        private void bt_quitar_Click(object sender, EventArgs e)
        {
            if(row == -1)
            {
                MessageBox.Show("Elija un paquete.");
                return;
            }

            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("2");
            campos.Add("" + dgv_tabla.Rows[row].Cells["idclientepa"].Value.ToString());
            List<Capsula> m = conn.insertar("sp_insertar_clientepaquete", campos);
            conn.cerrar();
            foreach (Capsula r in m)
            {
                MessageBox.Show(r.getCampos()[0]);
            }
            limpiar();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Program.menu.removeRuta("Paquetes contratados por: " + cliente + "/");
            Program.menu.AbrirFormEnPanel(Program.clientes);
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

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgv_tabla.CurrentRow.Index;
        }
    }
}
