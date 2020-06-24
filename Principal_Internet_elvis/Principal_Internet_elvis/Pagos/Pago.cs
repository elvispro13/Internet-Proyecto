using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.Pagos
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
            addFuente(Program.principal.fuente);
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
    }
}
