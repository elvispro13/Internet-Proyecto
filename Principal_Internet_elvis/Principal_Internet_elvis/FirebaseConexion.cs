using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Principal_Internet_elvis
{
    class FirebaseConexion
    {
        public IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret= "7JjRRhqf3TwWl32Y5Y4eLe9dmNYu0OUiANvCxnvl",
            BasePath= "https://cybernet-1999.firebaseio.com/"
        };

        public IFirebaseClient client;

        public FirebaseConexion()
        {
            client = new FireSharp.FirebaseClient(config);

            if(client == null)
            {
                MessageBox.Show("Fallo de conexion con servidor Firebase");
            }
        }
    }
}
