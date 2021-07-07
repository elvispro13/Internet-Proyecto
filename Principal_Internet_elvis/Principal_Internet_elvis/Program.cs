using Principal_Internet_elvis.ClientesCarpeta;
using Principal_Internet_elvis.Configuraciones;
using Principal_Internet_elvis.FormmGenerales;
using Principal_Internet_elvis.Pagos;
using Principal_Internet_elvis.Paquetes;
using Principal_Internet_elvis.Reportes;
using Principal_Internet_elvis.Ubicacion;
using Proyecto_dawelin;
using Proyecto_Internet;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public static Dashboard dashboard;
        public static Menu menu;
        public static HacerPing hacerPing;
        public static Principal principal;
        public static Inicio inicio;
        public static Usuarios usuarios;
        public static Permisos permisos;
        public static Opciones OpCliente; 

        public static Configuracion configuracion;
        public static ConfiguracionLogo configuracionLogo;
        public static ServidorConexion servidorConexion;

        public static UbicacionTipo ubicacionTipo;
        public static UbicacionAgregar ubicacionAgregar;
        public static UbicacionElegir ubicacionElegir;
        public static Proveedor proveedor;
        public static PaquetesTipo paquetesTipo;
        public static PaquetesAgregar paquetesAgregar;
        public static PaquetesElegir paquetesElegir;
        public static Estado_cliente estado_Cliente;
        public static Socios socios;
        public static Bus_factura bus_Factura;
        

        public static Pago pago;

        public static Clientes clientes;
        public static ClientesPaquetes clientesPaquetes;
        public static ReportesTipo reportesTipo;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            menu = new Menu();
            Application.Run(menu);
        }

        public static void actualizarFuente()
        {
            menu.addFuente(menu.fuente);
        }

        public static IEnumerable<Control> GetAllChildren(this Control root) //recorrer un tipo de elemento en el formularuo
        {
            var stack = new Stack<Control>();
            stack.Push(root);

            while (stack.Any())
            {
                var next = stack.Pop();
                foreach (Control child in next.Controls)
                    stack.Push(child);
                yield return next;
            }
        }
    }
}
