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
    public partial class ConsultaAnyo : Form
    {
        public ConsultaAnyo()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if(dtAnyo.Value <= DateTime.Now)
            {
                MessageBox.Show(dtAnyo.Value.Year.ToString());
                dgvDatos.DataSource = Constantes.contabilidad_TA.GetConsultaAnyo(dtAnyo.Value.Year.ToString());
            }
            else
            {
                MessageBox.Show("No puede seleccionar un dia superior al actual");
            }
        }
    }
}
