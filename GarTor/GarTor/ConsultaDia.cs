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
    public partial class ConsultaDia : Form
    {
        public ConsultaDia()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if(dtDia.Value <= DateTime.Now)
            {
                dgvDatos.DataSource = Constantes.contabilidad_TA.GetConsultaDia(dtDia.Value);
                //MessageBox.Show(dtDia.Value.ToShortDateString());
            }
            else
            {
                MessageBox.Show("No puede seleccionar un dia superior al actual");
            }
        }
    }
}
