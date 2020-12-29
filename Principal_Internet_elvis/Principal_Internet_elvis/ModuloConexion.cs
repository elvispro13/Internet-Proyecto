using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis
{
    class ModuloConexion
    {

        public bool bandera = false;

        public OdbcConnection conec = new OdbcConnection();

        public string usuario;

        public string linea = "DSN=proyecto;Uid=;pwd=;";

        public void conectar()
        {
            try
            {
                if(conec.State == ConnectionState.Closed)
                {
                    conec.ConnectionString = linea;
                    conec.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay red favor comunicarse con el departamento de informatica");
            }
        }

    }
}
