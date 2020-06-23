using Principal_Internet_elvis.ClientesCarpeta;
using Principal_Internet_elvis.Configuraciones;
using Principal_Internet_elvis.FormmGenerales;
using Principal_Internet_elvis.Pagos;
using Principal_Internet_elvis.Paquetes;
using Principal_Internet_elvis.Ubicacion;
using Proyecto_dawelin;
using Proyecto_Internet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static Principal principal;
        public static Inicio inicio;
        public static Usuarios usuarios;
        public static Opciones OpCliente;

        public static Configuracion configuracion;
        public static ConfiguracionLogo configuracionLogo;

        public static UbicacionTipo ubicacionTipo;
        public static UbicacionAgregar ubicacionAgregar;
        public static UbicacionElegir ubicacionElegir;

        public static PaquetesTipo paquetesTipo;
        public static PaquetesAgregar paquetesAgregar;
        public static PaquetesElegir paquetesElegir;

        public static Pago pago;

        public static Clientes clientes;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            principal = new Principal();
            Application.Run(principal);
        }
    }
}
