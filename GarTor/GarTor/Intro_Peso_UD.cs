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
            Constantes.PESO_UD_PRODUCTO = peso_UD;
            this.Close();
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

        private void tbPeso_UD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                introducir();
            }
        }
    }
}
