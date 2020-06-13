using Principal_Internet_elvis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

                MessageBox.Show("Decripcion del usuario: "+rows[0].getCampos()[3]);
                Program.principal.Focus();
                Program.principal.BringToFront();
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
            txtUsuario.Select();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            Configuracion f = new Configuracion();
            f.Show();
            Visible = false;
        }

    }
}
