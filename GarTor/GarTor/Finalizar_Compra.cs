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
    /// <summary>
    /// Formulario para cuando se finaliza la compra
    /// </summary>
    public partial class Finalizar_Compra : Form
    {
        private bool acabado = false;
        private float entregado = 0;
        private float importe = Convert.ToSingle(Constantes.IMPORTE);
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public Finalizar_Compra()
        {
            Constantes.VENTA_HECHA = false;
            InitializeComponent();
            lbImporte.Text = Constantes.IMPORTE + "€";
            lbEntregado.Text = "";
            lbCambio.Text = "";
        }
        /// <summary>
        /// Metodo onClick que llama al metodo introducir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finalizarCompra(object sender, EventArgs e)
        {
            introducir();
        }
        /// <summary>
        /// Metodo para calcular la diferencia entre el precio y lo entregado.
        /// Cuando esta pagado finaliza la compra.
        /// </summary>
        private void introducir()
        {
            if (acabado)
            {
                Constantes.VENTA_HECHA = true;
                this.Close();
            }
            try
            {
                if (Convert.ToSingle(tbEntrega.Text.ToString()) < 999999)
                {
                    entregado = entregado + Convert.ToSingle(tbEntrega.Text.ToString());
                    lbEntregado.Text = entregado.ToString("#,##0.##");
                    lbCambio.Text = (entregado - importe).ToString("#,##0.##");
                    if (Convert.ToSingle(lbCambio.Text) >= 0.00)
                    {
                        btFinalizar.Text = "Finalizar";
                        acabado = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se puede introducir una cantidad mayor a 999.999€");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se puede introducir una cantidad mayor a 999.999€");
            }
            
        }
        /// <summary>
        /// Metodo para evaluar la introduccion de datos del textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                    && tbEntrega.Text.Contains('.')) || e.KeyChar == '\b' || char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Metodo para que el "enter" llame al metodo introducir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbEntrega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                introducir();
            }
        }
    }
}
