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
    public partial class ModificarIngrediente : Form
    {
        public ModificarIngrediente()
        {
            InitializeComponent();

            cbMedidas.SelectedIndex = 0;

            cbIngrediente.DisplayMember = "Nombre_Ingrediente";
            cbIngrediente.ValueMember = "Cod_Ingrediente";

            cbIngrediente.DataSource = Constantes.ingredientes_TA.GetData();

            cbProveedores.DisplayMember = "Nombre_Proveedor";
            cbProveedores.ValueMember = "Cod_Proveedor";

            cbProveedores.DataSource = Constantes.proveedores_TA.GetData();
            

            units.Value =Convert.ToDecimal(Constantes.precioIngredientes_TA.GetPrecio(Convert.ToInt16(cbProveedores.SelectedValue.ToString())));
        }

        private void CambioPrecio(object sender, EventArgs e)
        {
            units.Value = Convert.ToDecimal(Constantes.precioIngredientes_TA.GetPrecio(Convert.ToInt16(cbProveedores.SelectedValue.ToString())));
        }
    }

}
