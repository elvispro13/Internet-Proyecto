﻿using Principal_Internet_elvis.Configuraciones;
using Proyecto_Internet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Program.menu.bt_inicio_Click(null,null);
            Close();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            addFuente(Program.menu.fuente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fd_fuente.ShowDialog() == DialogResult.OK)
            {
                Capsula f = new Capsula();
                f.setFuente(fd_fuente.Font);

                MemoryStream memorystream = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(memorystream, f);
                byte[] fuente = memorystream.GetBuffer();

                ConexionDB conn = new ConexionDB();
                conn.abrir();
                DataTable r = conn.fuente(Program.menu.idu,fuente,1);
                conn.cerrar();

                for(int i = 0; i < r.Rows.Count; i++)
                {
                    MessageBox.Show(r.Rows[i]["mensaje"].ToString());
                }

                Program.menu.fuente = f.getFuente();
                Program.actualizarFuente();

                addFuente(f.getFuente());
            }
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_empresa_Click(object sender, EventArgs e)
        {
            Program.configuracionLogo = new ConfiguracionLogo();
            Program.configuracionLogo.Text = "EMPRESA";
            Program.configuracionLogo.retorno = this;
            Program.configuracionLogo.ruta = "Empresa/";
            Program.menu.AbrirFormEnPanel(Program.configuracionLogo);
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

        private void bt_provedores_Click(object sender, EventArgs e)
        {
            Program.proveedor = new Proveedor();
            Program.proveedor.Text = "PROVEEDORES";
            Program.proveedor.Show();
            Program.proveedor.Focus();
        }

        private void bt_socios_Click(object sender, EventArgs e)
        {
            Program.socios = new Socios();
            Program.socios.Text = "PROVEEDORES";
            Program.socios.Show();
            Program.socios.Focus();
        }

        private void bt_usuarios_Click(object sender, EventArgs e)
        {
            Program.usuarios = new Usuarios();
            Program.usuarios.Text = "USUARIOS";
            Program.usuarios.retorno = this;
            Program.usuarios.ruta = "Usuarios/";
            Program.menu.AbrirFormEnPanel(Program.usuarios);
        }

        private void bt_servidor_Click(object sender, EventArgs e)
        {
            Program.servidorConexion = new ServidorConexion();
            Program.servidorConexion.retorno = this;
            Program.servidorConexion.ruta = "Servidor/";
            Program.menu.AbrirFormEnPanel(Program.servidorConexion);
            Program.servidorConexion.Focus();
        }
    }
}
