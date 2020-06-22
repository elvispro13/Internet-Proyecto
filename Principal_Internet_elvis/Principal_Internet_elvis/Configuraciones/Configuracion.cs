using Proyecto_Internet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtServer.Text == "")
            {
                MessageBox.Show("Llene los campos.");
                return;
            }

            try
            {
                string ruta = Application.StartupPath + "\\config.txt";
                StreamWriter streamWriter = new StreamWriter(ruta);
                streamWriter.WriteLine(txtServer.Text);
                streamWriter.Close();
                Inicio f = new Inicio();
                f.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problema al guardar");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
