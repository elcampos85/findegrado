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
    /// Formulario para introducir gastos
    /// 
    /// </summary>
    public partial class VentanaGastos : Form
    {
        /// <summary>
        /// Contructor de la ventana gastos
        /// </summary>
        public VentanaGastos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo onClick del boton para introducir gastos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Funcion para introducir el gasto o actualizarlo en la tabla contabilidad
        /// </summary>
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
                string dia_actual = DateTime.Now.ToString("dd/MM/yyyy");
                if(Constantes.contabilidad_TA.getRegistros(dia_actual) == 0)
                {
                    Constantes.contabilidad_TA.Insert(dia_actual, Convert.ToSingle(tbGasto.Text.ToString()),0);
                    this.Close();
                    MessageBox.Show("Se introdujo correctamente el gasto de " + tbGasto.Text.ToString() + "€ en un nuevo registro del dia "  + dia_actual);
                }
                else
                {
                    int id = Convert.ToInt32(Constantes.contabilidad_TA.GetId(dia_actual));
                    float gastos = Convert.ToSingle(Constantes.contabilidad_TA.getGastos(dia_actual));
                    float nuevoGasto = Convert.ToSingle(tbGasto.Text);

                    Constantes.contabilidad_TA.UpdateGastos(Convert.ToDouble(gastos+nuevoGasto), id);
                    this.Close();
                    MessageBox.Show("Se introdujo correctamente el gasto de " + tbGasto.Text.ToString() + "€ modificando el registro del dia " + dia_actual + " con unos gastos actuales de " + (gastos + Convert.ToSingle(tbGasto.Text.ToString())).ToString() + "€");
                }
            }
        }
        /// <summary>
        /// Evento KeyPress del textbox para evitar que se escriban letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Evento KeyDown del botón para que al darle a la tecla enter se ejecute lo mismo que al hacer click en el botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbGasto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    introducir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Introduzca un gasto válido");
                    tbGasto.Select();
                }
            }
        }
    }
}
