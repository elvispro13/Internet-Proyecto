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
    public partial class Estado_cliente : Form
    {
        public Estado_cliente()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                Buscara();
            }
        }

        public void Buscara()
        {
            MessageBox.Show("No hay codigo de buscar por el momento," +
                " busque el metodo llamado 'Buscara' e insertelo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buscara();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
