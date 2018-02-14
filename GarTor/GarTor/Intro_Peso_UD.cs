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
    public partial class Intro_Peso_UD : Form
    {
        public Intro_Peso_UD()
        {
            InitializeComponent();
        }

        private void intro_Peso_UD(object sender, EventArgs e)
        {
            introducir();
        }

        private void introducir()
        {
            string peso_UD = tbPeso_UD.Text.ToString();
            if(Convert.ToDouble(peso_UD) > 1000)
            {
                MessageBox.Show("La cantidad máxima a introducir es: 1000");
                tbPeso_UD.Text = "";
                tbPeso_UD.Select();
            }
            else
            {
                Constantes.PESO_UD_PRODUCTO = peso_UD;
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                    && tbPeso_UD.Text.Contains('.')) || e.KeyChar =='\b' || char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbPeso_UD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                introducir();
            }
        }
    }
}
