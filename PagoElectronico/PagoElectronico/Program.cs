﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PagoElectronico.Modelo;
using PagoElectronico.Menu;
using PagoElectronico.ConexionDB;

namespace PagoElectronico
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RepositorioDeDatos repositorio = new RepositorioDB();
            RepositorioDeDatos.setInstance(repositorio);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaLogin());
        }
    }
}
