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
    public partial class SuplementoModificar : Form
    {
        public SuplementoModificar()
        {
            InitializeComponent();

            cbSuplemento.DisplayMember = "Nom_Suplemento";
            cbSuplemento.ValueMember = "Cod_Suplemento";

            cbSuplemento.DataSource = Constantes.suplemento_TA.GetData();

        }

        private void cbSuplemento_SelectedValueChanged(object sender, EventArgs e)
        {
            tbNombre.Text = Constantes.suplemento_TA.GetNombreSuplemento(Convert.ToInt32(cbSuplemento.SelectedValue));
            NPrecio.Value =Convert.ToDecimal(Constantes.suplemento_TA.GetPrecioSuplemento(Convert.ToInt32(cbSuplemento.SelectedValue)));
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre=Constantes.suplemento_TA.GetNombreSuplemento(Convert.ToInt32(cbSuplemento.SelectedValue));
                String nombreNuevo= tbNombre.Text;
                float precio=Convert.ToSingle(NPrecio.Value);
                int codSuplemento= Convert.ToInt32(cbSuplemento.SelectedValue);
                

                Constantes.suplemento_TA.UpdateSuplemento(nombreNuevo, Convert.ToDouble(precio),codSuplemento,nombre);
                MessageBox.Show("Suplemento modificado correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo modificar el suplemento");
            }
        }
    }
}
