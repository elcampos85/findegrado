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
    public partial class SuplementoAñadir : Form
    {
        public SuplementoAñadir()
        {
            InitializeComponent();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Constantes.suplemento_TA.Insert(tbNombre.Text, Convert.ToDouble(NPrecio.Value));
                MessageBox.Show("Suplemento agregado correctamente");
            }catch(Exception e)
            {
                MessageBox.Show("El suplemento no se agregó");
            }
        }
    }
}
