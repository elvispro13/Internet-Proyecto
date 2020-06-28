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

namespace Principal_Internet_elvis.Pagos
{
    public partial class Pago : Form
    {
        private int idclientepa = -1;
        private float total = -1, desc = -1, isv = -1, totalpagar = 0, subtotal = 0, descuento = 0, impuesto = 0;
        private string mensualidad = "";

        private int idfactura;

        DataTable dt = new DataTable();
        private int filadetalles = -1;

        public Pago()
        {
            InitializeComponent();
            gBusCliente.Visible = false;
            gBusConcep.Visible = false;
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            addFuente(Program.principal.fuente);
            if (Program.principal.logo != null)
            {
                img_logo.Image = Program.principal.logo;
                img_logo.Visible = true;
            }

            dt.Columns.Add("ID");
            dt.Columns.Add("FECHA");
            dt.Columns.Add("TOTAL");
            dt.Columns.Add("DESCUENTO");
            dt.Columns.Add("ISV");
            dt.Columns.Add("PAQUETE");
            dt.Columns.Add("CANTIDAD");
            dt.Columns.Add("MONTO");

            dgv_detalles.DataSource = dt;
            dgv_detalles.Columns[0].Visible = false;
            dgv_detalles.Columns[1].Visible = false;
            dgv_detalles.Columns[2].Visible = false;
            dgv_detalles.Columns[3].Visible = false;
            dgv_detalles.Columns[4].Visible = false;
        }

        private void btnbusCLI_Click(object sender, EventArgs e)
        {
            gBusCliente.Visible = true;
            gb_cliente.Visible = false;
            txt_buscar_c.Select();
        }

        private void btnBusCON_Click(object sender, EventArgs e)
        {
            gBusConcep.Visible = true;
            gb_paquete.Visible = false;

            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("" + int.Parse(txt_codigo_c.Text));
            conn.llenarTabla("sp_buscar_clientepaquete", campos, dgv_tabla_p);
            conn.cerrar();
            dgv_tabla_p.Columns[0].Visible = false;
            dgv_tabla_p.Columns[1].Visible = false;
            dgv_tabla_p.Columns["isv"].Visible = false;
            dgv_tabla_p.Columns["descuento"].Visible = false;
            dgv_tabla_p.Columns["subtotal"].Visible = false;
            dgv_tabla_p.Columns["total"].Visible = false;
            dgv_tabla_p.Columns["fechasolicitud"].Visible = false;

            for (int i = 0; i < dgv_tabla_p.Rows.Count; i++)
            {
                if (dgv_tabla_p.Rows[i].Cells["estado"].Value.ToString().Equals("PENDIENTE INSTALACION"))
                {
                    dgv_tabla_p.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dgv_tabla_p.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (dgv_tabla_p.Rows[i].Cells["estado"].Value.ToString().Equals("SERVICIO ACTIVO"))
                {
                    dgv_tabla_p.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgv_tabla_p.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dgv_tabla_p.Rows[i].Cells["estado"].Value.ToString().Equals("CORTE DE SERVICIO"))
                {
                    dgv_tabla_p.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgv_tabla_p.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }

            for (int i = 0; i < dgv_tabla_p.Columns.Count; i++)
            {
                string t = dgv_tabla_p.Columns[i].HeaderText.ToUpper();
                dgv_tabla_p.Columns[i].HeaderText = t;
            }

            dgv_tabla_p.ClearSelection();

            idclientepa = -1;
        }

        private void btnAtrasConcepto_Click(object sender, EventArgs e)
        {
            gBusConcep.Visible = false;
            gb_paquete.Visible = true;
        }

        private void btnAtrasCliente_Click(object sender, EventArgs e)
        {
            gBusCliente.Visible = false;
            gb_cliente.Visible = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(filadetalles == -1)
            {
                MessageBox.Show("Seleccione un detalle para poder borrarlo.");
                return;
            }
            dt.Rows[filadetalles].Delete();
            limpiarPaquete();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

            foreach (Label e in Program.GetAllChildren(this).OfType<Label>())
            {
                e.Font = f;
            }

            foreach (RadioButton e in Program.GetAllChildren(this).OfType<RadioButton>())
            {
                e.Font = f;
            }
        }

        private void txt_buscar_c_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("'" + txt_buscar_c.Text + "'");
                campos.Add("1");
                conn.llenarTabla("sp_buscar_clientes", campos, dgv_tabla_c);
                conn.cerrar();
                dgv_tabla_c.Columns["idcliente"].Visible = false;
                dgv_tabla_c.Columns["genero"].Visible = false;
                dgv_tabla_c.Columns["estado"].Visible = false;

                for (int i = 0; i < dgv_tabla_c.Columns.Count; i++)
                {
                    string t = dgv_tabla_c.Columns[i].HeaderText.ToUpper();
                    dgv_tabla_c.Columns[i].HeaderText = t;
                }
            }
        }

        private void dgv_tabla_c_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla_c.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int row = dgv_tabla_c.CurrentRow.Index;
                int c = int.Parse(dgv_tabla_c.Rows[row].Cells["idcliente"].Value.ToString());
                txt_codigo_c.Text = c.ToString("D10");
                txt_nombre_c.Text = dgv_tabla_c.Rows[row].Cells["nombre"].Value.ToString();
                txt_rtn_c.Text = dgv_tabla_c.Rows[row].Cells["rtn"].Value.ToString();
                txt_direccion_c.Text = dgv_tabla_c.Rows[row].Cells["direccion"].Value.ToString();

                dgv_tabla_c.DataSource = null;
                gBusCliente.Visible = false;
                gb_cliente.Visible = true;
                txt_buscar_c.Text = "";

                gb_acciones.Enabled = true;
                gb_paquete.Enabled = true;
                btnImprimir.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }

        private void dgv_tabla_p_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla_p.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int row = dgv_tabla_p.CurrentRow.Index;
                if(idclientepa == -1)
                {
                    idclientepa = int.Parse(dgv_tabla_p.Rows[row].Cells["idclientepa"].Value.ToString());
                    txt_codigo_p.Text = idclientepa.ToString("D10");
                    txt_descripcion_p.Text = dgv_tabla_p.Rows[row].Cells["descripcion"].Value.ToString();
                    dtp_mes_p.Value = DateTime.Parse(dgv_tabla_p.Rows[row].Cells["fechapago"].Value.ToString());
                    total = float.Parse(dgv_tabla_p.Rows[row].Cells["total"].Value.ToString());
                    desc = float.Parse(dgv_tabla_p.Rows[row].Cells["descuento"].Value.ToString());
                    isv = float.Parse(dgv_tabla_p.Rows[row].Cells["isv"].Value.ToString());

                    ConexionDB conn = new ConexionDB();
                    conn.abrir();
                    List<string> campos = new List<string>();
                    campos.Add("1");
                    campos.Add("" + idclientepa);
                    campos.Add("" + int.Parse(txt_codigo_c.Text));
                    campos.Add("'" + dtp_mes_p.Value.ToString("yyyy/MM/dd") + "'");
                    conn.llenarTabla("sp_buscar_meses", campos, dgv_tabla_p);
                    conn.cerrar();
                    dgv_tabla_p.Columns["fecha"].Visible = false;

                    for (int i = 0; i < dgv_tabla_p.Columns.Count; i++)
                    {
                        string t = dgv_tabla_p.Columns[i].HeaderText.ToUpper();
                        dgv_tabla_p.Columns[i].HeaderText = t;
                    }

                    dgv_tabla_p.ClearSelection();
                }
                else
                {
                    dtp_mes_p.Value = DateTime.Parse(dgv_tabla_p.Rows[row].Cells["fecha"].Value.ToString());
                    mensualidad = dgv_tabla_p.Rows[row].Cells["mensualidad"].Value.ToString();
                    txt_monto_p.Text = total.ToString("L0.00");
                    dgv_tabla_p.DataSource = null;
                    gBusConcep.Visible = false;
                    gb_paquete.Visible = true;
                }
            }
        }

        private void txt_efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cb_tipopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_tipopago.SelectedIndex == 0)
            {
                txt_efectivo.Text = "";
                txt_cambio.Text = "";
                txt_efectivo.Enabled = true;
            }
            else
            {
                txt_efectivo.Text = "" + totalpagar;
                txt_efectivo.Enabled = false;
                txt_cambio.Text = "0";
            }
        }

        private void txt_efectivo_KeyUp(object sender, KeyEventArgs e)
        {
            if (float.Parse(txt_efectivo.Text) >= totalpagar)
            {
                txt_cambio.Text = "" + (float.Parse(txt_efectivo.Text) - totalpagar);
            }
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if(total == -1 || idclientepa == -1 || mensualidad == "")
            {
                MessageBox.Show("Seleccione un mes a pagar.");
                return;
            }

            btnbusCLI.Enabled = false;

            DataRow dr = dt.NewRow();
            dr["ID"] = "" + int.Parse(txt_codigo_p.Text);
            dr["FECHA"] = dtp_mes_p.Value.ToString("yyyy/MM/dd");
            dr["TOTAL"] = "" + total;
            dr["DESCUENTO"] = desc;
            dr["ISV"] = "" + isv;
            dr["PAQUETE"] = txt_descripcion_p.Text+" - Mes: "+ mensualidad.ToUpper();
            dr["CANTIDAD"] = 1;
            dr["MONTO"] = txt_monto_p.Text;

            dt.Rows.Add(dr);

            limpiarPaquete();
        }


        private void limpiarPaquete()
        {
            foreach (TextBox e in Program.GetAllChildren(gb_paquete).OfType<TextBox>())
            {
                e.Text = "";
            }

            idclientepa = -1;
            total = -1;
            mensualidad = "";
            filadetalles = -1;

            totalpagar = 0;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                subtotal = float.Parse(dt.Rows[i]["TOTAL"].ToString()) + subtotal;
                descuento = float.Parse(dt.Rows[i]["DESCUENTO"].ToString()) + descuento;
                impuesto = float.Parse(dt.Rows[i]["ISV"].ToString()) + impuesto;
            }
            totalpagar = subtotal - descuento;

            txt_totalpagar.Text = totalpagar.ToString("L0.00");

            dgv_detalles.ClearSelection();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(idfactura == null)
            {
                MessageBox.Show("No hay niguna factura hecha actualmente.");
                return;
            }
            mostrarFactura(idfactura);
        }

        private void limpiarTodo()
        {
            btnbusCLI.Enabled = true;

            gBusConcep.Visible = false;
            gb_paquete.Visible = true;

            gBusCliente.Visible = false;
            gb_cliente.Visible = true;

            cb_tipopago.Text = "";

            dt.Rows.Clear();

            limpiarPaquete();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar por lo menos un detalle.");
                return;
            }
            DialogResult r = MessageBox.Show("¿Esta seguro de generar la factura?", "Confirmacion",MessageBoxButtons.YesNo);
            if (r.ToString().Equals("No"))
            {
                return;
            }
            if(cb_tipopago.Text == "")
            {
                MessageBox.Show("Seleccione el tipo de pago.");
                return;
            }
            if (float.Parse(txt_efectivo.Text) < totalpagar)
            {
                MessageBox.Show("El efectivo debe ser mayor al total a pagar.");
                return;
            }

            //factura
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("" + int.Parse(txt_codigo_c.Text));
            campos.Add("" + Program.principal.ide);
            campos.Add("'" + txt_nombre_c.Text + "'");
            campos.Add("'" + txt_rtn_c.Text + "'");
            campos.Add("'" + dtp_fechaemision.Value.ToString("yyyy/MM/dd hh:mm:ss") + "'");
            campos.Add("" + Program.principal.idu);
            campos.Add("'" + Program.principal.nombre + "'");
            campos.Add("'CONTADO'");
            campos.Add("'" + cb_tipopago.Text + "'");
            campos.Add("" + subtotal);
            campos.Add("" + impuesto);
            campos.Add("" + 0);
            campos.Add("" + descuento);
            campos.Add("" + 0);
            campos.Add("" + 0);
            campos.Add("" + txt_efectivo.Text); // efectivo
            campos.Add("" + txt_cambio.Text); // cambio
            Conv c = new Conv();
            campos.Add("'" + c.enletras(""+totalpagar) + "'"); // letras
            campos.Add("" + totalpagar);
            campos.Add("" + 1);
            campos.Add("" + Program.principal.desde_e);
            campos.Add("" + Program.principal.hasta_e);
            List<Capsula> m = conn.insertar("sp_insertar_factura", campos);
            conn.cerrar();
            foreach (Capsula i in m)
            {
                idfactura = int.Parse(i.getCampos()[0]);
            }
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow mm = dt.Rows[i];

                insertarCuota(int.Parse(mm["ID"].ToString()),
                                mm["PAQUETE"].ToString(),
                                dtp_fechaemision.Value.ToString("yyyy/MM/dd"),
                                mm["FECHA"].ToString(),
                                float.Parse(mm["MONTO"].ToString().Replace("L","")),
                                float.Parse(mm["DESCUENTO"].ToString().Replace("L","")),
                                float.Parse(mm["ISV"].ToString().Replace("L","")),
                                1);
            }

            MessageBox.Show("Su factura ya ha sido generada.");

            limpiarTodo();
        }

        private void insertarCuota(int idclientepa, string descrip, string fecha, string mes, float monto, float descuent, float isv, int estado)
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            campos.Add("" + Program.principal.idu);
            campos.Add("" + int.Parse(txt_codigo_c.Text));
            campos.Add("" + idclientepa);
            campos.Add("" + idfactura);
            campos.Add("'" + Program.principal.nombre + "'");
            campos.Add("'" + descrip + "'");
            campos.Add("'" + fecha + "'");
            campos.Add("'" + mes + "'");
            campos.Add("" + monto);
            campos.Add("" + descuent);
            campos.Add("" + isv);
            campos.Add("" + estado);

            conn.insertar("sp_insertar_detallefactura", campos);
            conn.cerrar();
        }

        private void dgv_detalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_detalles.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                filadetalles = dgv_detalles.CurrentRow.Index;
            }
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
    }
}
