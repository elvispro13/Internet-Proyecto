using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis
{
    public partial class HacerPing : Form
    {
        public String ip = "", cliente = "";

        public HacerPing()
        {
            InitializeComponent();
        }

        private String ping(String ip)
        {
            Ping HacerPing = new Ping();
            int iTiempoEspera = 5000;
            PingReply RespuestaPing;
            string sDireccion;
            sDireccion = ip;
            RespuestaPing = HacerPing.Send(sDireccion, iTiempoEspera);
            if (RespuestaPing.Status == IPStatus.Success)
            {
                return "Ping a " +
                    sDireccion.ToString() +
                    "[" +
                    RespuestaPing.Address.ToString() +
                    "]" +
                    " Correcto" +
                    " Tiempo de respuesta = " +
                    RespuestaPing.RoundtripTime.ToString() +
                    " ms" +
                    System.Environment.NewLine;
            }
            else
            {
                return "Error: Ping a " +
                    sDireccion.ToString() +
                    System.Environment.NewLine;
            }
        }

        private void HacerPing_Load(object sender, EventArgs e)
        {
            ip = ip.Replace(" ","");
            timer_ping.Enabled = true;
            lb_titulo.Text += " a: " + ip + " " + cliente;
        }

        private void correrPing()
        {
            txt_log.AppendText(ping(ip) + System.Environment.NewLine);
        }

        private void timer_ping_Tick(object sender, EventArgs e)
        {
            correrPing();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            timer_ping.Enabled = false;
            Close();
        }
    }
}
