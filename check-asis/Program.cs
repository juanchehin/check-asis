﻿using System;
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
            Presentacion.Login frm = new Presentacion.Login();
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
