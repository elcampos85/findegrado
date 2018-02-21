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
    public partial class DescuentoExtra : Form
    {
        public DescuentoExtra()
        {
            InitializeComponent();
        }

        private void intro(object sender, EventArgs e)
        {
            introducirExtra();
        }

        private void introducirExtra()
        {
            string precio = tbPrecio.Text.ToString();
            string concepto = tbConcepto.Text.ToString();
            try
            {
                if (Convert.ToDouble(precio) > 9999 || concepto.Equals("") || precio.Equals(""))
                {
                    MessageBox.Show("La cantidad máxima a introducir es: 9999\nY el concepto no puede quedar vacio");
                    tbPrecio.Select();
                }
                else
                {
                    Constantes.PRECIO_ESTRELLA = precio;
                    Constantes.CONCEPTO_ESTRELLA = concepto;
                    this.Close();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Debes rellenar AMBOS datos correctamente");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                    && tbPrecio.Text.Contains('.')) || e.KeyChar =='\b' || e.KeyChar == '-' || char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
