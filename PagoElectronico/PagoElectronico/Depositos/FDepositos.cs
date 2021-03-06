﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Ventanas;
using PagoElectronico.Modelo;

namespace PagoElectronico.Depositos
{
    public partial class FDepositos : Ventana
    {
        protected Cliente cliente;
        protected List<Tarjeta> tarjetas;

        public FDepositos(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            Importe.mayorOIgualA = 1;
        }

        protected override void cargarDatos()
        {
            tarjetas = RepositorioDeDatos.getInstance().obtenerTarjetasHabilitadasDeCliente(cliente);
            mostrarTarjetas(tarjetas);

            Cuentas.cargarCuentas(RepositorioDeDatos.getInstance().obtenerCuentasDeCliente(cliente));
        }

        private void mostrarTarjetas(List<Tarjeta> tarjetas)
        {
            foreach (Tarjeta t in tarjetas)
            {
                Tarjetas_Disponibles.Rows.Add(
                    soloLos4UltimosNumeros(t.numero),
                    t.fechaEmision.ToShortDateString(),
                    t.fechaVencimiento.ToShortDateString(),
                    t.codigoSeguridad,
                    t.emisor,
                    false);
            }
        }
        
        private String soloLos4UltimosNumeros(decimal p)
        {
            String numeroTarjeta = p.ToString();
            return "******************".Substring(0, numeroTarjeta.Length -4) +
                numeroTarjeta.Substring(numeroTarjeta.Length - 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (noEsValidoYMuestraMensaje())
                return;

            Cuenta cuenta = Cuentas.obtenerCuenta();

            try
            {
                RepositorioDeDatos.getInstance().depositar(
                    cuenta,
                    Convert.ToDecimal(Importe.Text),
                    Moneda.obtenerMoneda(),
                    obtenerTarjeta());
                volverDeOperacionExitosa("Se realizó el depósito");
            }
            catch (ErrorEnRepositorioException excepcion)
            {
                mostrarError(excepcion.mensaje);
            }
        }

        private Tarjeta obtenerTarjeta()
        {
            foreach (DataGridViewRow fila in Tarjetas_Disponibles.Rows)
            {
                if (Convert.ToBoolean(fila.Cells[5].Value) == true)
                    return tarjetas.ElementAt(fila.Index);
            }

            return null;
        }

    }
}
