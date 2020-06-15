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
    public partial class Prueba_de_fuentes : Form
    {
        public Prueba_de_fuentes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbFuentes_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            String texto = cbFuentes.Items[e.Index].ToString();
            Font fuente = new Font(texto, e.Font.Size);

            e.Graphics.DrawString(texto, fuente, new SolidBrush(e.ForeColor), e.Bounds.Left + 2, e.Bounds.Top + 2);

            e.DrawFocusRectangle();
        }

        private void cbFuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFuentes.Font = new Font(cbFuentes.Text, cbFuentes.Font.Size);
            

        }

        private void cbFuentes_Click(object sender, EventArgs e)
        {
            cbFuentes.Items.Clear();
            foreach (FontFamily Fuentes in FontFamily.Families)
            {
                String nombre = Fuentes.Name;

                cbFuentes.Items.Add(nombre);

            }
        }

        private void cambiar_fuentes(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control.Controls.Count > 0)
                    cambiar_fuentes(control);
                else
                {
                    if (control is Label) ((Label)control).Font = new Font(cbFuentes.Text, 10, FontStyle.Regular);
                }
            }
        }
    }
}
