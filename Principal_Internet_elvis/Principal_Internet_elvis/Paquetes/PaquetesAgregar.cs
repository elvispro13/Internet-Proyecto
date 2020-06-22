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
    public partial class PaquetesAgregar : Form
    {

        private int row = -1, estado = -1;

        public PaquetesAgregar()
        {
            InitializeComponent();
        }

        private void PaquetesAgregar_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            if (this.Text.Contains("SERVICIO"))
            {
                gb_codigo.Enabled = false;
                gb_c1.Enabled = true;
                gb_c2.Enabled = true;
                gb_c1.Text = "PRECIO";
                gb_c2.Text = "ISV";
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("' '");
                campos.Add("1");
                conn.llenarTabla("sp_buscar_paquetes", campos, dgv_tabla);
                conn.cerrar();
            }
            else if (this.Text.Contains("PAQUETE"))
            {
                gb_codigo.Enabled = false;
                gb_c1.Enabled = true;
                gb_c2.Enabled = false;
                gb_c1.Text = "DESCUENTO";
                gb_c2.Text = "";
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("' '");
                campos.Add("2");
                conn.llenarTabla("sp_buscar_paquetes", campos, dgv_tabla);
                conn.cerrar();
            }
            txt_descripcion.Select();
            txt_descripcion.Text = "";
            txt_codigo.Text = "";
            txt_c1.Text = "";
            txt_c2.Text = "";
            row = -1;
            estado = -1;
        }

        private void aceptar()
        {
            if (this.Text.Contains("SERVICIO"))
            {
                if (this.Text.Contains("AGREGAR"))
                {
                    ConexionDB conn = new ConexionDB();
                    conn.abrir();
                    List<string> campos = new List<string>();
                    campos.Add("'" + txt_descripcion.Text + "'");
                    campos.Add("" + txt_c1.Text);
                    campos.Add("" + txt_c2.Text);
                    List<Capsula> m = conn.insertar("sp_insertar_servicio", campos);
                    conn.cerrar();
                    foreach (Capsula r in m)
                    {
                        MessageBox.Show(r.getCampos()[0]);
                    }
                    limpiar();
                }
                else if (this.Text.Contains("BUSCAR") || this.Text.Contains("MODIFICAR"))
                {
                    ConexionDB conn = new ConexionDB();
                    conn.abrir();
                    List<string> campos = new List<string>();
                    campos.Add("'" + txt_descripcion.Text + "'");
                    campos.Add("1");
                    conn.llenarTabla("sp_buscar_paquetes", campos, dgv_tabla);
                    conn.cerrar();
                    if (row != -1)
                    {
                        ConexionDB conn2 = new ConexionDB();
                        conn2.abrir();
                        List<string> campos2 = new List<string>();
                        campos2.Add("" + txt_codigo.Text);
                        campos2.Add("'" + txt_descripcion.Text + "'");
                        if (txt_c1.Text.Equals(""))
                        {
                            campos2.Add("-1");
                        }
                        else
                        {
                            campos2.Add("" + txt_c1.Text);
                        }
                        if (txt_c2.Text.Equals(""))
                        {
                            campos2.Add("-1");
                        }
                        else
                        {
                            campos2.Add("" + txt_c2.Text);
                        }
                        List<Capsula> m = conn2.insertar("sp_modificar_servicio", campos2);
                        conn2.cerrar();
                        foreach (Capsula r in m)
                        {
                            MessageBox.Show(r.getCampos()[0]);
                        }
                        limpiar();
                    }
                }
            }
            else if (this.Text.Contains("PAQUETE"))
            {
                if (this.Text.Contains("AGREGAR"))
                {
                    ConexionDB conn = new ConexionDB();
                    conn.abrir();
                    List<string> campos = new List<string>();
                    campos.Add("'" + txt_descripcion.Text + "'");
                    campos.Add("" + txt_c1.Text);
                    List<Capsula> m = conn.insertar("sp_insertar_paquete", campos);
                    conn.cerrar();
                    foreach (Capsula r in m)
                    {
                        MessageBox.Show(r.getCampos()[0]);
                    }
                    limpiar();
                }
                else if (this.Text.Contains("BUSCAR") || this.Text.Contains("MODIFICAR"))
                {
                    ConexionDB conn = new ConexionDB();
                    conn.abrir();
                    List<string> campos = new List<string>();
                    campos.Add("'" + txt_descripcion.Text + "'");
                    campos.Add("2");
                    conn.llenarTabla("sp_buscar_paquetes", campos, dgv_tabla);
                    conn.cerrar();
                    if (row != -1)
                    {
                        ConexionDB conn2 = new ConexionDB();
                        conn2.abrir();
                        List<string> campos2 = new List<string>();
                        campos2.Add("" + txt_codigo.Text);
                        campos2.Add("'" + txt_descripcion.Text + "'");
                        if (txt_c1.Text.Equals(""))
                        {
                            campos2.Add("-1");
                        }
                        else
                        {
                            campos2.Add("" + txt_c1.Text);
                        }
                        List<Capsula> m = conn2.insertar("sp_modificar_paquete", campos2);
                        conn2.cerrar();
                        foreach (Capsula r in m)
                        {
                            MessageBox.Show(r.getCampos()[0]);
                        }
                        limpiar();
                    }
                }
            }
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            aceptar();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_c1_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (e.KeyChar.ToString().Equals(".") && !txt_c1.Text.Contains("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_c2_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (e.KeyChar.ToString().Equals(".") && !txt_c2.Text.Contains("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dgv_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && Text.Contains("MODIFICAR") ||
                selectedRowCount > 0 && Text.Contains("ESTADO"))
            {
                row = dgv_tabla.CurrentRow.Index;
                seleccionar();
            }
        }

        private void seleccionar()
        {
            if (this.Text.Contains("PAQUETE"))
            {
                txt_codigo.Text = dgv_tabla.Rows[row].Cells[0].Value.ToString();
                txt_descripcion.Text = dgv_tabla.Rows[row].Cells[1].Value.ToString();
                txt_c1.Text = dgv_tabla.Rows[row].Cells[2].Value.ToString();
                estado = int.Parse(dgv_tabla.Rows[row].Cells[3].Value.ToString());
            }
            else if (this.Text.Contains("SERVICIO"))
            {
                txt_codigo.Text = dgv_tabla.Rows[row].Cells[0].Value.ToString();
                txt_descripcion.Text = dgv_tabla.Rows[row].Cells[1].Value.ToString();
                txt_c1.Text = dgv_tabla.Rows[row].Cells[2].Value.ToString();
                txt_c2.Text = dgv_tabla.Rows[row].Cells[3].Value.ToString();
                estado = int.Parse(dgv_tabla.Rows[row].Cells[4].Value.ToString());
            }
        }

        private void txt_descripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                aceptar();
            }
        }
    }
}
