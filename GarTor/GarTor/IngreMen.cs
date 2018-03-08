﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    public partial class IngreMen : Form
    {
        public IngreMen()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (dtDia.Value <= DateTime.Now)
            {
                string mes = DateTime.Now.Month.ToString();
                string anio = DateTime.Now.Year.ToString();

                dgvDatos.DataSource = Constantes.contabilidad_TA.GetConsultaDia("*/"+mes+"/"+anio);
            }
            else
            {
                MessageBox.Show("No puede seleccionar un dia superior al actual");
            }
        }
    }
}
