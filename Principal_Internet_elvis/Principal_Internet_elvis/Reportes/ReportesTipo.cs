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

namespace Principal_Internet_elvis.Reportes
{
    public partial class ReportesTipo : Form
    {
        public ReportesTipo()
        {
            InitializeComponent();
        }

        private void bt_mora_buscar_Click(object sender, EventArgs e)
        {
            mostrarMora();
        }

        private void mostrarMora()
        {
            ModuloConexion mm = new ModuloConexion();
            mm.conectar();

            OdbcDataAdapter myAdapter = new OdbcDataAdapter();
            DataSet myData = new DataSet();

            int rango = 0;
            if (cb_rango.Checked)
                rango = 1;

            string xsql = "exec sp_buscar_mora 1,'" + dtp_mora_desde.Value.ToString("yyyy/MM/dd") + "','" +
                            dtp_mora_hasta.Value.ToString("yyyy/MM/dd") + "'," + Program.principal.ide + "," + rango + ";";

            ReportesViwer formulario = new ReportesViwer();

            mora rpt = new mora();

            DataSet ds = new DataSet();
            ds.Clear();

            OdbcCommand myCommand = new OdbcCommand(xsql, mm.conec);

            myAdapter.SelectCommand = myCommand;

            myAdapter.Fill(ds, "v_mora");

            rpt.SetDataSource(ds);

            formulario.crystalReportViewer1.ReportSource = rpt;

            formulario.crystalReportViewer1.Dock = DockStyle.Fill;

            Form frmReporte = new Form();
            frmReporte.Controls.Add(formulario.crystalReportViewer1);
            frmReporte.Text = "CLIENTES EN DEUDA";
            frmReporte.WindowState = FormWindowState.Maximized;
            frmReporte.ShowDialog();
        }

        private void mostrarEstado()
        {
            ModuloConexion mm = new ModuloConexion();
            mm.conectar();

            OdbcDataAdapter myAdapter = new OdbcDataAdapter();
            DataSet myData = new DataSet();

            int rango = 0;
            if (cb_estado_rango.Checked)
                rango = 1;

            string xsql = "exec sp_estadocuenta 1,'" + dtp_mora_desde.Value.ToString("yyyy/MM/dd") + "','" +
                            dtp_mora_hasta.Value.ToString("yyyy/MM/dd") + "'," + int.Parse(txt_estado_codigo.Text) + "," + rango + ";";

            ReportesViwer formulario = new ReportesViwer();

            estadocuenta rpt = new estadocuenta();

            DataSet ds = new DataSet();
            ds.Clear();

            OdbcCommand myCommand = new OdbcCommand(xsql, mm.conec);

            myAdapter.SelectCommand = myCommand;

            myAdapter.Fill(ds, "v_cuotas");

            rpt.SetDataSource(ds);

            formulario.crystalReportViewer1.ReportSource = rpt;

            formulario.crystalReportViewer1.Dock = DockStyle.Fill;

            Form frmReporte = new Form();
            frmReporte.Controls.Add(formulario.crystalReportViewer1);
            frmReporte.Text = "ESTADO DE CUENTA DE CLIENTE";
            frmReporte.WindowState = FormWindowState.Maximized;
            frmReporte.ShowDialog();
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

        private void ReportesTipo_Load(object sender, EventArgs e)
        {
            gb_estado_buscar.Visible = false;
            gb_estado.Visible = true;
            addFuente(Program.menu.fuente);
        }

        private void bt_estado_atras_Click(object sender, EventArgs e)
        {
            gb_estado_buscar.Visible = false;
            gb_estado.Visible = true;
        }

        private void bt_estado_buscar_Click(object sender, EventArgs e)
        {
            gb_estado_buscar.Visible = true;
            gb_estado.Visible = false;
            txt_estado_buscar.Select();
        }

        private void bt_estado_imprimir_Click(object sender, EventArgs e)
        {
            if (txt_estado_codigo.Text.Equals(""))
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }
            mostrarEstado();
        }

        private void dgv_estado_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_estado_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int row = dgv_estado_tabla.CurrentRow.Index;
                int c = int.Parse(dgv_estado_tabla.Rows[row].Cells["idcliente"].Value.ToString());
                txt_estado_codigo.Text = c.ToString("D10");
                txt_estado_nombre.Text = dgv_estado_tabla.Rows[row].Cells["nombre"].Value.ToString();

                gb_estado_buscar.Visible = false;
                gb_estado.Visible = true;
                dgv_estado_tabla.DataSource = null;
                txt_estado_buscar.Text = "";
            }
        }

        private void txt_estado_buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("'" + txt_estado_buscar.Text + "'");
                campos.Add("1");
                conn.llenarTabla("sp_buscar_clientes", campos, dgv_estado_tabla);
                conn.cerrar();
                dgv_estado_tabla.Columns["idcliente"].Visible = false;
                dgv_estado_tabla.Columns["genero"].Visible = false;
                dgv_estado_tabla.Columns["estado"].Visible = false;

                for (int i = 0; i < dgv_estado_tabla.Columns.Count; i++)
                {
                    string t = dgv_estado_tabla.Columns[i].HeaderText.ToUpper();
                    dgv_estado_tabla.Columns[i].HeaderText = t;
                }
            }
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Program.menu.bt_inicio_Click(null,null);
            this.Close();
        }
    }
}
