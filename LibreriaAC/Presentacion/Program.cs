﻿using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Globales.ip = "192.168.0.104";
            //Globales.ip = "10.1.10.202";
            //Globales.ip = "127.0.0.1";
            Application.Run(new Login());
        }
    }
}
