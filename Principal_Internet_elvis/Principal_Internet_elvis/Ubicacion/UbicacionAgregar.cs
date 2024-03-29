﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Principal_Internet_elvis.Ubicacion
{
    public partial class UbicacionAgregar : Form
    {

        public Form retorno;
        public String ruta = "";

        private int id2;
        private int row = -1, estado = -1;

        public UbicacionAgregar()
        {
            InitializeComponent();
        }

        private void UbicacionAgregar_Load(object sender, EventArgs e)
        {
            if (this.Text.Contains("SECTOR"))
            {
                gb_codigo.Enabled = false;
                gb_codigo2.Enabled = false;
                gb_codigo2.Text = "";
            }
            else if (this.Text.Contains("BARRIO"))
            {
                gb_codigo.Enabled = false;
                gb_codigo2.Enabled = true;
                gb_codigo2.Text = "Sector";
            }
            else if (this.Text.Contains("LUGAR"))
            {
                gb_codigo.Enabled = false;
                gb_codigo2.Enabled = true;
                gb_codigo2.Text = "Barrio";
            }

            bt_eliminar.Enabled = false;

            addFuente(Program.menu.fuente);

            Program.menu.addRuta(ruta);
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            if (this.Text.Contains("SECTOR"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("' '");
                campos.Add("1");
                if (cb_inactivos.Checked == false)
                {
                    campos.Add("1");
                }
                else
                {
                    campos.Add("0");
                }
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
                dgv_tabla.Columns[0].Visible = false;
            }
            else if (this.Text.Contains("BARRIO"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("' '");
                campos.Add("2");
                if (cb_inactivos.Checked == false)
                {
                    campos.Add("1");
                }
                else
                {
                    campos.Add("0");
                }
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
                dgv_tabla.Columns[0].Visible = false;
                dgv_tabla.Columns[1].Visible = false;
            }
            else if (this.Text.Contains("LUGAR"))
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("' '");
                campos.Add("3");
                if (cb_inactivos.Checked == false)
                {
                    campos.Add("1");
                }
                else
                {
                    campos.Add("0");
                }
                conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
                conn.cerrar();
                dgv_tabla.Columns[0].Visible = false;
                dgv_tabla.Columns[1].Visible = false;
            }

            dgv_tabla.ClearSelection();

            for (int i = 0; i < dgv_tabla.Rows.Count; i++)
            {
                if (dgv_tabla.Rows[i].Cells["estado"].Value.ToString().Equals("1"))
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                dgv_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
            }

            for (int i = 0; i < dgv_tabla.Columns.Count; i++)
            {
                string t = dgv_tabla.Columns[i].HeaderText.ToUpper();
                dgv_tabla.Columns[i].HeaderText = t;
            }

            bt_eliminar.Enabled = false;

            txt_nombre.Select();

            id2 = 0;
            row = -1;
            estado = -1;
            txt_codigo2.Text = "";
            txt_nombre.Text = "";
            txt_codigo.Text = "";
        }

        public void agregarDatos(int id, string nombre)
        {
            id2 = id;
            txt_codigo2.Text = nombre;
        }

        private void bt_codigo2_Click(object sender, EventArgs e)
        {
            if(row == -1)
            {
                MessageBox.Show("Elija una fila");
                return;
            }
            if (this.Text.Contains("BARRIO"))
            {
                Program.ubicacionElegir = new UbicacionElegir();
                Program.ubicacionElegir.Text = "ELEGIR-SECTOR";
                Program.ubicacionElegir.retorno = this;
                Program.ubicacionElegir.ruta = "Elegir sector/";
                Program.menu.AbrirFormEnPanel(Program.ubicacionElegir);
            }
            else if (this.Text.Contains("LUGAR"))
            {
                Program.ubicacionElegir = new UbicacionElegir();
                Program.ubicacionElegir.Text = "ELEGIR-BARRIO";
                Program.ubicacionElegir.retorno = this;
                Program.ubicacionElegir.ruta = "Elegir barrio/";
                Program.menu.AbrirFormEnPanel(Program.ubicacionElegir);
            }
        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                buscar();
            }
        }


        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                row = dgv_tabla.CurrentRow.Index;
                seleccionar();
            }
        }

        private void seleccionar()
        {
            if (this.Text.Contains("SECTOR"))
            {
                txt_codigo.Text = dgv_tabla.Rows[row].Cells[0].Value.ToString();
                txt_nombre.Text = dgv_tabla.Rows[row].Cells[1].Value.ToString();
                estado = int.Parse(dgv_tabla.Rows[row].Cells[2].Value.ToString());
            }
            else if (this.Text.Contains("BARRIO"))
            {
                txt_codigo.Text = dgv_tabla.Rows[row].Cells[0].Value.ToString();
                txt_codigo2.Text = dgv_tabla.Rows[row].Cells[1].Value.ToString();
                txt_nombre.Text = dgv_tabla.Rows[row].Cells[2].Value.ToString();
                id2 = int.Parse(dgv_tabla.Rows[row].Cells[1].Value.ToString());
                estado = int.Parse(dgv_tabla.Rows[row].Cells[3].Value.ToString());
            }
            else if (this.Text.Contains("LUGAR"))
            {
                txt_codigo.Text = dgv_tabla.Rows[row].Cells[0].Value.ToString();
                txt_codigo2.Text = dgv_tabla.Rows[row].Cells[1].Value.ToString();
                txt_nombre.Text = dgv_tabla.Rows[row].Cells[2].Value.ToString();
                id2 = int.Parse(dgv_tabla.Rows[row].Cells[1].Value.ToString());
                estado = int.Parse(dgv_tabla.Rows[row].Cells[5].Value.ToString());
            }

            bt_eliminar.Enabled = true;
        }

        private void buscar()
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<string> campos = new List<string>();
            if (txt_nombre.Text.Equals(""))
            {
                campos.Add("' '");
            }
            else
            {
                campos.Add("'" + txt_nombre.Text + "'");
            }
            if (this.Text.Contains("SECTOR"))
            {
                campos.Add("1");
            }
            else if (this.Text.Contains("BARRIO"))
            {
                campos.Add("2");
            }
            else if (this.Text.Contains("LUGAR"))
            {
                campos.Add("3");
            }
            if (cb_inactivos.Checked == false)
            {
                campos.Add("1");
            }
            else
            {
                campos.Add("0");
            }
            conn.llenarTabla("sp_buscar_ubicacion", campos, dgv_tabla);
            conn.cerrar();

            dgv_tabla.ClearSelection();

            for (int i = 0; i < dgv_tabla.Rows.Count; i++)
            {
                if (dgv_tabla.Rows[i].Cells["estado"].Value.ToString().Equals("1"))
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                dgv_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (row == -1)
            {
                if(txt_codigo.Text == "" || txt_nombre.Text == "")
                {
                    MessageBox.Show("Llene los campos");
                    return;
                }
                if (this.Text.Contains("SECTOR"))
                {
                    ConexionDB conn = new ConexionDB();
                    conn.abrir();
                    List<string> campos = new List<string>();
                    campos.Add("'" + txt_nombre.Text + "'");
                    List<Capsula> m = conn.insertar("sp_insertar_sector", campos);
                    conn.cerrar();
                    foreach (Capsula r in m)
                    {
                        MessageBox.Show(r.getCampos()[0]);
                    }
                }
                else if (this.Text.Contains("BARRIO"))
                {
                    ConexionDB conn = new ConexionDB();
                    conn.abrir();
                    List<string> campos = new List<string>();
                    campos.Add("" + id2 + "");
                    campos.Add("'" + txt_nombre.Text + "'");
                    List<Capsula> m = conn.insertar("sp_insertar_barrio", campos);
                    conn.cerrar();
                    foreach (Capsula r in m)
                    {
                        MessageBox.Show(r.getCampos()[0]);
                    }
                }
                else if (this.Text.Contains("LUGAR"))
                {
                    ConexionDB conn = new ConexionDB();
                    conn.abrir();
                    List<string> campos = new List<string>();
                    campos.Add("" + id2 + "");
                    campos.Add("'" + txt_nombre.Text + "'");
                    campos.Add("'-1'");
                    campos.Add("'-1'");
                    List<Capsula> m = conn.insertar("sp_insertar_lugar", campos);
                    conn.cerrar();
                    foreach (Capsula r in m)
                    {
                        MessageBox.Show(r.getCampos()[0]);
                    }
                }
            }
            else
            {
                if (this.Text.Contains("SECTOR"))
                {
                    ConexionDB conn2 = new ConexionDB();
                    conn2.abrir();
                    List<string> campos2 = new List<string>();
                    campos2.Add("" + txt_codigo.Text);
                    campos2.Add("'" + txt_nombre.Text + "'");
                    List<Capsula> m = conn2.insertar("sp_modificar_sector", campos2);
                    conn2.cerrar();
                    foreach (Capsula r in m)
                    {
                        MessageBox.Show(r.getCampos()[0]);
                    }
                }
                else if (this.Text.Contains("BARRIO"))
                {
                    ConexionDB conn2 = new ConexionDB();
                    conn2.abrir();
                    List<string> campos2 = new List<string>();
                    campos2.Add("" + txt_codigo.Text);
                    campos2.Add("" + id2 + "");
                    campos2.Add("'" + txt_nombre.Text + "'");
                    List<Capsula> m = conn2.insertar("sp_modificar_barrio", campos2);
                    conn2.cerrar();
                    foreach (Capsula r in m)
                    {
                        MessageBox.Show(r.getCampos()[0]);
                    }
                }
                else if (this.Text.Contains("LUGAR"))
                {
                    ConexionDB conn2 = new ConexionDB();
                    conn2.abrir();
                    List<string> campos2 = new List<string>();
                    campos2.Add("" + txt_codigo.Text);
                    campos2.Add("" + id2 + "");
                    campos2.Add("'" + txt_nombre.Text + "'");
                    campos2.Add("'-1'");
                    campos2.Add("'-1'");
                    List<Capsula> m = conn2.insertar("sp_modificar_lugar", campos2);
                    conn2.cerrar();
                    foreach (Capsula r in m)
                    {
                        MessageBox.Show(r.getCampos()[0]);
                    }
                }
            }
            limpiar();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if(row == -1)
            {
                MessageBox.Show("Elija una fila");
                return;
            }
            ConexionDB conn2 = new ConexionDB();
            conn2.abrir();
            List<string> campos2 = new List<string>();
            campos2.Add("" + txt_codigo.Text);
            if (this.Text.Contains("SECTOR"))
            {
                campos2.Add("1");
            }
            else if (this.Text.Contains("BARRIO"))
            {
                campos2.Add("2");
            }
            else if (this.Text.Contains("LUGAR"))
            {
                campos2.Add("3");
            }

            if (estado == 1)
            {
                estado = 0;
            }
            else if (estado == 0)
            {
                estado = 1;
            }
            campos2.Add("" + estado);
            List<Capsula> m = conn2.insertar("sp_estado_ubicacion", campos2);
            conn2.cerrar();
            foreach (Capsula r in m)
            {
                MessageBox.Show(r.getCampos()[0]);
            }
            limpiar();
        }

        private void bt_salir_Click_1(object sender, EventArgs e)
        {
            Program.menu.removeRuta(ruta);
            Program.menu.AbrirFormEnPanel(retorno);
            this.Close();
        }

        private void cb_inactivos_CheckedChanged(object sender, EventArgs e)
        {
            buscar();
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
    }
}
