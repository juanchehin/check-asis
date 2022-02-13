﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_asis
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
            Presentacion.MenuPrincipal frm = new Presentacion.MenuPrincipal();
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
            Application.Run();
        }
        private static void Frm_FormClosed(object sender,FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
