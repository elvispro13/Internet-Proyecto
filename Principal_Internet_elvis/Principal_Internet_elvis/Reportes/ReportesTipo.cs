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
            addFuente(Program.principal.fuente);
        }
    }
}
