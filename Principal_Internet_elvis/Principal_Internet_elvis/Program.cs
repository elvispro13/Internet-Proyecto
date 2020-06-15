﻿using Principal_Internet_elvis.Cliente;
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
        public static ElegirRoles elegirRoles;
        public static Prueba_de_fuentes Prueba_de_fuentes;

        public static UbicacionTipo ubicacionTipo;

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
