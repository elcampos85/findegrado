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
                string mes = dtDia.Value.Month.ToString();
                string anio = dtDia.Value.Year.ToString();
                string uno;
                string dos;
                if (Convert.ToInt32(mes) < 10)
                {
                    uno = "1/" + "0" + mes + "/" + anio;
                    dos = "31/" + "0" + mes + "/" + anio;
                }
                else
                {
                    uno = "1/" + mes + "/" + anio;
                    dos = "31/" + mes + "/" + anio;
                }

                if (uno.Equals("1/03/2018"))
                {
                    MessageBox.Show("si");
                }
                MessageBox.Show(uno);
                MessageBox.Show(dos);
                MessageBox.Show(DateTime.Now.ToShortDateString());

                dgvDatos.DataSource = Constantes.contabilidad_TA.GetConsultaMes(mes,anio);
            }
            else
            {
                MessageBox.Show("No puede seleccionar un dia superior al actual");
            }
        }
    }
}
