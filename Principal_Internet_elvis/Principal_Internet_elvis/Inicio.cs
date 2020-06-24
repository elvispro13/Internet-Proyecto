using Principal_Internet_elvis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Internet
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();  
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saber_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender.Equals(txtUsuario))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtContra.Select();

                }
            }else if (sender.Equals(txtContra))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnEntrar_Click(null,null);
                }
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if ( txtContra.Text == "" && txtUsuario.Text == ""
                ||  txtContra.Text == "" && txtUsuario.Text != ""
                ||  txtContra.Text != "" && txtUsuario.Text == "")
            {

                txtContra.Clear();
                txtUsuario.Clear();
                MessageBox.Show("Llene todos los campos");

            }
            else if (txtContra.Text != "" && txtUsuario.Text != "")
            {
                ConexionDB conn = new ConexionDB();
                conn.abrir();
                List<string> campos = new List<string>();
                campos.Add("'"+txtUsuario.Text+"'");
                campos.Add("'" + txtContra.Text + "'");
                List<Capsula> rows = conn.consultar("sp_verificar_usuarios", campos);
                conn.cerrar();
                if(rows.Count == 0 || !rows[0].getCampos()[1].Equals(txtUsuario.Text) ||
                    !rows[0].getCampos()[2].Equals(txtContra.Text))
                {
                    MessageBox.Show("Usuario o clave incorrectos.");
                    return;
                }

                Program.principal.idu = int.Parse(rows[0].getCampos()[0]);
                Program.principal.user = rows[0].getCampos()[1];
                Program.principal.clave = rows[0].getCampos()[2];
                Program.principal.desc = rows[0].getCampos()[3];
                Program.principal.nombre = rows[0].getCampos()[8];

                ConexionDB conn2 = new ConexionDB();
                conn2.abrir();
                DataTable r = conn2.fuente(Program.principal.idu, null, 2);
                conn2.cerrar();
                for (int i = 0; i < r.Rows.Count; i++)
                {
                    byte[] fuente = (byte[])r.Rows[i]["fuente"];
                    MemoryStream memorystreamd = new MemoryStream(fuente);
                    BinaryFormatter bfd = new BinaryFormatter();
                    Capsula f = bfd.Deserialize(memorystreamd) as Capsula;
                    Program.principal.fuente = f.getFuente();
                    Program.actualizarFuente();
                }

                ConexionDB conn3 = new ConexionDB();
                conn3.abrir();
                DataTable m = conn3.empresa(null, null, null, null, null, null, null, null, null, null, 2);
                conn3.cerrar();
                for (int i = 0; i < m.Rows.Count; i++)
                {
                    byte[] logo = (byte[])m.Rows[i]["logo"];
                    MemoryStream ms = new MemoryStream(logo);
                    Program.principal.logo = Image.FromStream(ms);
                }

                MessageBox.Show("Bienvenido");
                Program.principal.Focus();
                Program.principal.BringToFront();
                Program.principal.activarConUser();
                this.Close();
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            List<Capsula> rows = conn.consultar("sp_ver_usuarios", null);
            conn.cerrar();
            if(rows == null)
            {
                btnAjustes.Visible = true;
                btnAjustes.Enabled = true;
                MessageBox.Show("Problema con servidor");
                return;
            }
            if(rows.Count == 0)
            {
                MessageBox.Show("Debe agregar un usuario principal");
            }
            this.Focus();
            txtUsuario.Select();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            Configuracion f = new Configuracion();
            f.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
