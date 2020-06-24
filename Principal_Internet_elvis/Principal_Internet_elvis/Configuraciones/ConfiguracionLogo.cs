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

namespace Principal_Internet_elvis.Configuraciones
{
    public partial class ConfiguracionLogo : Form
    {
        private Byte[] file = null;
        public ConfiguracionLogo()
        {
            InitializeComponent();
        }

        private void bt_logo_Click(object sender, EventArgs e)
        {
            pfd_logo.InitialDirectory = "c:\\";
            pfd_logo.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png|Archivos jpeg (*.jpeg)|*.jpeg";
            pfd_logo.FilterIndex = 1;
            pfd_logo.RestoreDirectory = true;
            if(pfd_logo.ShowDialog() == DialogResult.OK)
            {
                txt_logo.Text = pfd_logo.FileName;

                pb_logo.Image = Image.FromFile(pfd_logo.FileName);
            }
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pb_logo.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            DataTable m = conn.empresa(txt_nombre.Text, 
                                        txt_eslogan.Text, 
                                        ms.GetBuffer(),
                                        txt_rtn.Text,
                                        txt_cai.Text,
                                        txt_correo.Text,
                                        dtp_fechalimite.Value.ToString(),
                                        txt_desde.Text,
                                        txt_hasta.Text,
                                        txt_moneda.Text,
                                        1);
            conn.cerrar();
            for (int i = 0; i < m.Rows.Count; i++)
            {
                MessageBox.Show(m.Rows[i]["mensaje"].ToString());
            }
            Program.principal.logo = pb_logo.Image;
            Program.principal.activarConUser();
            Close();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfiguracionLogo_Load(object sender, EventArgs e)
        {
            ConexionDB conn = new ConexionDB();
            conn.abrir();
            DataTable m = conn.empresa(null, null, null, null, null, null, null, null, null, null, 2);
            conn.cerrar();
            for (int i = 0; i < m.Rows.Count; i++)
            {
                txt_nombre.Text = m.Rows[i]["nombre"].ToString();
                txt_eslogan.Text = m.Rows[i]["eslogan"].ToString();
                txt_rtn.Text = m.Rows[i]["rtn"].ToString();
                txt_cai.Text = m.Rows[i]["cai"].ToString();
                txt_correo.Text = m.Rows[i]["correo"].ToString();
                dtp_fechalimite.Value = DateTime.Parse(m.Rows[i]["fechalimite"].ToString());
                txt_desde.Text = m.Rows[i]["desde"].ToString();
                txt_hasta.Text = m.Rows[i]["hasta"].ToString();
                txt_moneda.Text = m.Rows[i]["moneda"].ToString();

                byte[] logo = (byte[])m.Rows[i]["logo"];
                MemoryStream ms = new MemoryStream(logo);
                pb_logo.Image = Image.FromStream(ms);
            }
            addFuente(Program.principal.fuente);
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

            foreach (DateTimePicker e in Program.GetAllChildren(this).OfType<DateTimePicker>())
            {
                e.Font = f;
            }
        }
    }
}
