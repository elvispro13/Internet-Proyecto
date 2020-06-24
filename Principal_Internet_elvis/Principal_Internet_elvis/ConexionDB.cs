using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace Principal_Internet_elvis
{
    class ConexionDB
    {
        public string servar = "none";
        string db = "proyecto";
        string conexion;
        public SqlConnection conectardb = new SqlConnection();
        public SqlCommand cmd;
        public SqlDataReader rd;
        public SqlDataAdapter da;
        public DataTable dt;

        public ConexionDB()
        {
            try
            {
                string ruta = Application.StartupPath + "\\config.txt";
                if (File.Exists(ruta))
                {
                    StreamReader streamReader = new StreamReader(ruta);
                    List<string> lineasConfig = new List<string>();
                    string linea = "";
                    while (linea != null)
                    {
                        linea = streamReader.ReadLine();
                        lineasConfig.Add(linea);
                    }
                    streamReader.Close();

                    this.servar = lineasConfig[0];
                }
            }
            catch(Exception ex)
            {

            }

            conexion = "Data Source=" + servar + ";Initial Catalog="+ db + ";Integrated Security=true";
            conectardb.ConnectionString = conexion;
        }

        public void abrir()
        {
            try
            {
                conectardb.Open();
                //MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo de conexion con servidor");
            }
        }

        public void cerrar()
        {
            conectardb.Close();
        }

        public DataTable fuente(int id ,byte[] fuente, int tipo)
        {
            try
            {
                cmd = new SqlCommand("sp_fuente", conectardb);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@fuente", SqlDbType.Image).Value = fuente;
                cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema: Al conectar" + ex);
            }
            return dt;
        }

        public DataTable empresa(string nombre, 
            string eslogan, 
            Byte[] logo, 
            string rtn,
            string cai,
            string correo,
            string fechalimite,
            string desde,
            string hasta,
            string moneda,
            int tipo)
        {
            try
            {
                cmd = new SqlCommand("sp_empresa", conectardb);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@eslogan", SqlDbType.NVarChar).Value = eslogan;
                cmd.Parameters.Add("@logo", SqlDbType.Image).Value = logo;
                cmd.Parameters.Add("@rtn", SqlDbType.NVarChar).Value = rtn;
                cmd.Parameters.Add("@cai", SqlDbType.NVarChar).Value = cai;
                cmd.Parameters.Add("@correo", SqlDbType.NVarChar).Value = correo;
                cmd.Parameters.Add("@fechalimite", SqlDbType.SmallDateTime).Value = fechalimite;
                cmd.Parameters.Add("@desde", SqlDbType.NVarChar).Value = desde;
                cmd.Parameters.Add("@hasta", SqlDbType.NVarChar).Value = hasta;
                cmd.Parameters.Add("@moneda", SqlDbType.NVarChar).Value = moneda;

                cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema: Al conectar" + ex);
            }
            return dt;
        }

        public List<Capsula> insertar(string proceso, List<string> p)
        {
            List<Capsula> rows = new List<Capsula>();
            try
            {
                string sql = getSQL(proceso, p);

                cmd = new SqlCommand(sql, conectardb);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        Capsula c = new Capsula();
                        for (int i = 0; i < rd.FieldCount; i++)
                        {
                            c.addCampo(rd.GetValue(i) + "");
                        }
                        rows.Add(c);
                    }
                }
            }
            catch (Exception ex)
            {
                rows = null;
                MessageBox.Show("Problema: Al conectar" + ex);
            }
            return rows;
        }

        public List<Capsula> consultar(string proceso, List<string> p)
        {
            List<Capsula> rows = new List<Capsula>();
            try
            {
                string sql = getSQL(proceso, p);

                cmd = new SqlCommand(sql, conectardb);
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        Capsula c = new Capsula();
                        for (int i = 0; i < rd.FieldCount; i++)
                        {
                            c.addCampo(rd.GetValue(i) + "");
                        }
                        rows.Add(c);
                    }
                }
            }
            catch (Exception ex)
            {
                rows = null;
                MessageBox.Show("Problema: Al conectar"+ex);
            }
            return rows;
        }

        public void llenarTabla(string proceso, List<string> p, DataGridView dataGridView)
        {
            try
            {
                dt = new DataTable();
                string sql = getSQL(proceso, p);
                cmd = new SqlCommand(sql, conectardb);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema al cargar tabla." + e);
            }
        }

        private string getSQL(string proceso, List<string> p)
        {
            string sql = "exec " + proceso;

            if (p != null)
            {
                if (p.Count > 0)
                {
                    foreach (string c in p)
                    {
                        if (c == "" || c == "''")
                        {
                            sql = sql + " null,";
                        }
                        else
                        {
                            sql = sql + " " + c + ",";
                        }
                    }
                    sql = sql.Remove(sql.Length - 1);
                }
            }

            return sql;
        }
    }
}
