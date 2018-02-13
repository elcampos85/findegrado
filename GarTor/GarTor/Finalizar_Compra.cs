using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            Constantes.VENTA_HECHA = false;
            InitializeComponent();
            lbImporte.Text = Constantes.IMPORTE + "€";
            lbEntregado.Text = "";
            lbCambio.Text = "";


        }

        private void finalizarCompra(object sender, EventArgs e)
        {
            introducir();
        }

        private void introducir()
        {
            if (acabado)
            {
                Constantes.VENTA_HECHA = true;
                this.Close();
            }
            entregado = entregado + Convert.ToSingle(tbEntrega.Text.ToString());
            lbEntregado.Text = entregado.ToString("#,##0.##");
            lbCambio.Text = (entregado - importe).ToString("#,##0.##");
            if (Convert.ToSingle(lbCambio.Text) >= 0.00)
            {
                btFinalizar.Text = "Finalizar";
                acabado = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbEntrega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                introducir();
            }
        }
    }
}
