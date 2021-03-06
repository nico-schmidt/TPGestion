﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Ventanas;

namespace PagoElectronico.ABM_Cliente
{
    public partial class DatosTarjeta : Ventana
    {
        public DatosTarjeta()
        {
            InitializeComponent();
            Numero.cantidadCaracteres = 16;
            CodigoDeSeguridad.cantidadCaracteres = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (noEsValidoYMuestraMensaje())
                return;

            tomarAccion();
        }

        protected virtual void tomarAccion()
        {}
    }
}
