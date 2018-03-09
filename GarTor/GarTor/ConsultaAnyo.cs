using System;
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
    /// <summary>
    /// Clase para consultar la contabilidad de un año
    /// </summary>
    public partial class ConsultaAnyo : Form
    {
        public ConsultaAnyo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que rellena la tabla con los datos de contabilidad del año seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBuscar_Click(object sender, EventArgs e)
        {
            if(dtAnyo.Value <= DateTime.Now)
            {
                dgvDatos.DataSource = Constantes.contabilidad_TA.GetConsultaAnyo(dtAnyo.Value.Year.ToString());
            }
            else
            {
                MessageBox.Show("No puede seleccionar un dia superior al actual");
            }
        }
    }
}