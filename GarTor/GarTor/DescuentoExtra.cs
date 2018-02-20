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

        }

        private void introducirDescuento()
        {
            string peso_UD = tbPrecio.Text.ToString();
            if(Convert.ToDouble(peso_UD) > 1000)
            {
                MessageBox.Show("La cantidad máxima a introducir es: 1000");
                tbPrecio.Text = "";
                tbPrecio.Select();
            }
            else
            {
                Constantes.PESO_UD_PRODUCTO = peso_UD;
                this.Close();
            }
        }

        private void introducirExtra()
        {
            //Modificar para guardar constantes con el concepto y el precio para pasarlo a la cesta de compra
            /*
            string precio = tbPrecio.Text.ToString();
            if (Convert.ToDouble(precio) > 1000)
            {
                MessageBox.Show("La cantidad máxima a introducir es: 1000");
                tbPrecio.Text = "";
                tbPrecio.Select();
            }
            else
            {
                Constantes.PESO_UD_PRODUCTO = precio;
                this.Close();
            }
            */
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                    && tbPrecio.Text.Contains('.')) || e.KeyChar =='\b' || char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
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
