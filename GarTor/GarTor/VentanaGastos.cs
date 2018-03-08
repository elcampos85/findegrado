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
    public partial class VentanaGastos : Form
    {
        public VentanaGastos()
        {
            InitializeComponent();
        }

        private void intro_Gasto(object sender, EventArgs e)
        {
            try
            {
                introducir();
            }catch (Exception ex)
            {
                MessageBox.Show("Introduzca un gasto válido");
                tbGasto.Select();
            }
            
        }

        private void introducir()
        {
            string gasto = tbGasto.Text.ToString();
            if(Convert.ToDouble(gasto) > 999999)
            {
                MessageBox.Show("La cantidad máxima a introducir es: 999.999€");
                tbGasto.Text = "";
                tbGasto.Select();
            }
            else
            {
                if(Constantes.contabilidad_TA.getRegistros(DateTime.Today.ToShortDateString()) == 0)
                {
                    Constantes.contabilidad_TA.Insert(DateTime.Now,Convert.ToDouble(tbGasto.Text),0);
                    this.Close();
                    MessageBox.Show("Se introdujo correctamente el gasto de " + tbGasto.Text.ToString() + "€ en un nuevo registro del dia " + DateTime.Today.ToShortDateString());
                }
                else
                {
                    int id = Convert.ToInt32(Constantes.contabilidad_TA.GetId(DateTime.Today.ToShortDateString()));
                    Constantes.contabilidad_TA.UpdateGastos(Convert.ToDouble(tbGasto.Text), id);
                    this.Close();
                    MessageBox.Show("Se introdujo correctamente el gasto de " + tbGasto.Text.ToString() + "€ modificando el registro del dia " + DateTime.Today.ToShortDateString());
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                    && tbGasto.Text.Contains('.')) || e.KeyChar =='\b' || char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbGasto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                introducir();
            }
        }
    }
}
