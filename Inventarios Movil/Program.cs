﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventarios_Movil
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new FrmAcceso());
        }
    }
}