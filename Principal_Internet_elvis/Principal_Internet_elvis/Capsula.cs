using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal_Internet_elvis
{
    class Capsula
    {
        private List<string> campos = new List<string>();

        public Capsula()
        {
            campos.Clear();
        }

        public void addCampo(string d)
        {
            campos.Add(d);
        }

        public List<string> getCampos()
        {
            return campos;
        }
    }
}
