﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    public partial class Finalizar_Compra : Form
    {
        private bool acabado = false;
        private float entregado = 0;
        private float importe = Convert.ToSingle(Constantes.IMPORTE);
        public Finalizar_Compra()
        {
            InitializeComponent();
            lbImporte.Text = Constantes.IMPORTE + "€";
            lbEntregado.Text = "";
            lbCambio.Text = "";
        }

        private void finalizarCompra(object sender, EventArgs e)
        {
            entregado = entregado + Convert.ToSingle(numEntrega.Value);
            lbEntregado.Text = entregado.ToString();
            lbCambio.Text = (entregado - importe).ToString();
            if (Convert.ToSingle(lbCambio.Text) >= 0)
            {
                btFinalizar.Text = "Finalizar";
                acabado = true;
            }
            if (acabado)
            {
                this.Close();
            }
        }
    }
}