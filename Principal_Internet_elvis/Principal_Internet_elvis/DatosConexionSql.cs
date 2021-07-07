using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Principal_Internet_elvis
{
    [Serializable]
    class DatosConexionSql
    {
        public string server, user, pass, db;

        public DatosConexionSql(string server, string user, string pass, string db)
        {
            this.server = server;
            this.user = user;
            this.pass = pass;
            this.db = db;
        }

        public int guardar()
        {
            string ruta = Application.StartupPath + "\\config.txt";
            try
            {
                using(Stream st = File.Open(ruta, FileMode.Create))
                {
                    var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binfor.Serialize(st, this);
                    return 0;
                }

            }catch(Exception ex)
            {
                return 2;
            }
        }
    }
}
