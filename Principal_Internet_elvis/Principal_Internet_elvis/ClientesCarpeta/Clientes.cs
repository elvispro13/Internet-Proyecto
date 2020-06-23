using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.ClientesCarpeta
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            if (this.Text.Contains("CLIENTE"))
            {

            }
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {

        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
