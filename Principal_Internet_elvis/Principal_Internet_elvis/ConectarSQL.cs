using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Principal_Internet_elvis
{
    class ConectarSQL
    {

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public string InsertarDatos;


        public void conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Base de satos conectada exitisamente");
            }
            catch 
            (Exception e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos: "+e.ToString());
            }
        }


        public string insertarCliente()
        {

            string salida = "Dato insertado de forma exitosa";

            try
            {
                cmd = new SqlCommand(InsertarDatos);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                 salida = "Fallo al insertar datos: "+e.ToString();
            }

            return salida;

        }
    }
}
