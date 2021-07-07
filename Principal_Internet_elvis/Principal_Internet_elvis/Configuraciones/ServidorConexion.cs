using Proyecto_Internet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.Configuraciones
{
    public partial class ServidorConexion : Form
    {
        public Form retorno;
        public String ruta = "";

        public ServidorConexion()
        {
            InitializeComponent();
        }

        private void ServidorConexion_Load(object sender, EventArgs e)
        {
            ConexionDB conn = new ConexionDB();
            txt_server.Text = conn.server;
            txt_user.Text = conn.user;
            txt_pass.Text = conn.pass;
            txt_db.Text = conn.db;
            addFuente(Program.menu.fuente);
            Program.menu.addRuta(ruta);
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txt_server.Text == "" || txt_user.Text == "" || txt_pass.Text == "" || txt_db.Text == "")
            {
                MessageBox.Show("Llene los campos.");
                return;
            }

            try
            {
                string ruta = Application.StartupPath + "\\config.txt";
                DatosConexionSql d = new DatosConexionSql(txt_server.Text,txt_user.Text,txt_pass.Text,txt_db.Text);
                int i = d.guardar();

                if(i != 0)
                {
                    MessageBox.Show("Fallo al guardar");
                    return;
                }

                Program.inicio.Visible = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al guardar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.menu.removeRuta(ruta);
            Program.menu.AbrirFormEnPanel(retorno);
            Close();
        }

        public void ocultarCerrar()
        {
            this.button1.Visible = false;
            this.button1.Enabled = false;
        }
    }
}
