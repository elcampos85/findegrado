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
    /// Clase que consulta la contabilidad de un dia
    /// </summary>
    public partial class ConsultaDia : Form
    {
        public ConsultaDia()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que rellena la tabla con los datos de contabilidad del dia seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBuscar_Click(object sender, EventArgs e)
        {
            if(dtDia.Value <= DateTime.Now)
            {
                dgvDatos.DataSource = Constantes.contabilidad_TA.GetConsultaDia(dtDia.Value.ToString("dd/MM/yyyy"));
            }
            else
            {
                MessageBox.Show("No puede seleccionar un dia superior al actual");
            }
        }
    }
}