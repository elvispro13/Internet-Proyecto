using Principal_Internet_elvis.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis
{
    public partial class Bus_factura : Form
    {
        private int row = -1;

        public Bus_factura()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Bus_factura_Load(object sender, EventArgs e)
        {
            addFuente(Program.menu.fuente);
        }

        private void buscar()
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("'" + txt_buscar.Text + "'");
            campos.Add("'" + dtpDesde.Value.ToString("yyyy/MM/dd") + "'");
            campos.Add("'" + dtpHasta.Value.ToString("yyyy/MM/dd") + "'");
            campos.Add("1");
            conn.llenarTabla("sp_buscar_factura", campos, dgv_tabla);
            conn.cerrar();

            dgv_tabla.Columns["idfactura"].Visible = false;

            for (int i = 0; i < dgv_tabla.Columns.Count; i++)
            {
                string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                dgv_tabla.Columns[i].HeaderText = t;
            }

            dgv_tabla.ClearSelection();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            if(row == -1)
            {
                MessageBox.Show("Seleccione un factura.");
                return;
            }
            mostrarFactura(int.Parse(dgv_tabla.Rows[row].Cells["idfactura"].Value.ToString()));
        }

        private void mostrarFactura(int id)
        {
            ModuloConexion mm = new ModuloConexion();
            mm.conectar();

            OdbcDataAdapter myAdapter = new OdbcDataAdapter();
            DataSet myData = new DataSet();
            string xsql = "select * from v_facturas where idfactura=" + id;

            ReportesViwer formulario = new ReportesViwer();

            factura rpt = new factura();

            DataSet ds = new DataSet();
            ds.Clear();

            OdbcCommand myCommand = new OdbcCommand(xsql, mm.conec);

            myAdapter.SelectCommand = myCommand;

            myAdapter.Fill(ds, "v_facturas");

            rpt.SetDataSource(ds);

            formulario.crystalReportViewer1.ReportSource = rpt;

            formulario.crystalReportViewer1.Dock = DockStyle.Fill;

            Form frmReporte = new Form();
            frmReporte.Controls.Add(formulario.crystalReportViewer1);
            frmReporte.Text = "FACTURA";
            frmReporte.WindowState = FormWindowState.Maximized;
            frmReporte.ShowDialog();
        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                row = dgv_tabla.CurrentRow.Index;
            }
        }
    }
}
