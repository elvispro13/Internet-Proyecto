using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis
{
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
            gBusCliente.Visible = false;
            gBusConcep.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Pago_Load(object sender, EventArgs e)
        {

        }

        private void btnbusCLI_Click(object sender, EventArgs e)
        {
            gBusCliente.Visible = true;
            gDatosCli.Visible = false;
        }

        private void btnBusCON_Click(object sender, EventArgs e)
        {
            gBusConcep.Visible = true;
            gDatosCon.Visible = false;
        }

        private void btnAtrasConcepto_Click(object sender, EventArgs e)
        {
            gBusConcep.Visible = false;
            gDatosCon.Visible = true;
        }

        private void btnAtrasCliente_Click(object sender, EventArgs e)
        {
            gBusCliente.Visible = false;
            gDatosCli.Visible = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtDirec.Text = "";
            txtNCON.Text = "";
            txtDescripcion.Text = "";
            txtMonto.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
