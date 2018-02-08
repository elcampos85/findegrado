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
            cbIngrediente.ValueMember = "Nombre_Ingrediente";

            cbIngrediente.DataSource = Constantes.ingredientes_TA.ComboboxIngredientes();

            cbProveedores.DisplayMember = "Nombre_Proveedor";
            cbProveedores.ValueMember = "Cod_Proveedor";

            cbProveedores.DataSource = Constantes.proveedores_TA.GetData();


            units.Value = Convert.ToDecimal(Constantes.precioIngredientes_TA.GetPrecio(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString()))));
            tbNuevoNombre.Text = cbIngrediente.Text;
        }

        private void CambioPrecio(object sender, EventArgs e)
        {
            if(cbIngrediente.SelectedItem != null)
            {
                units.Value = Convert.ToDecimal(Constantes.precioIngredientes_TA.GetPrecio(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString()))));
                tbNuevoNombre.Text = cbIngrediente.Text;
            }
            
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            
            float precio;
            switch (cbMedidas.SelectedIndex)
            {
                case 2://g
                    precio = (float)(Math.Round((double)Convert.ToSingle(units.Value), 2)) * (float)1000;
                    break;
                case 3://mg
                    precio = (float)(Math.Round((double)Convert.ToSingle(units.Value), 2)) * (float)1000000;
                    break;
                case 5://cL
                    precio = (float)(Math.Round((double)Convert.ToSingle(units.Value), 2)) * (float)100;
                    break;
                case 6://mL
                    precio = (float)(Math.Round((double)Convert.ToSingle(units.Value), 2)) * (float)1000;
                    break;
                default:
                    precio = (float)(Math.Round((double)Convert.ToSingle(units.Value), 2));
                    break;
            }
            precio = (float)precio / (float)(Math.Round((double)Convert.ToSingle(cantidad.Value)));
            precio = (float)(Math.Round((double)precio, 2));

            


            Constantes.ingredientes_TA.Update(tbNuevoNombre.Text.ToString(),Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString())),cbIngrediente.SelectedValue.ToString());
            Constantes.precioIngredientes_TA.UpdatePrecioIngrediente(Convert.ToDouble(units.Value), Convert.ToInt32(Constantes.precioIngredientes_TA.GetCodPrecioIngrediente(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString())),Convert.ToInt32(cbProveedores.SelectedValue))));
            MessageBox.Show(units.Value.ToString());

            MessageBox.Show(" 1: " + Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString())));
            MessageBox.Show( " 2: " + Convert.ToInt32(cbProveedores.SelectedValue).ToString());
            MessageBox.Show(Convert.ToInt32(Constantes.precioIngredientes_TA.GetCodPrecioIngrediente(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString())), Convert.ToInt32(cbProveedores.SelectedValue))).ToString());

            /*Constantes.precioIngredientes_TA.Update(
                Convert.ToInt32(cbProveedores.SelectedValue), 
                Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString())),
                Convert.ToDouble(units.Value),
                Convert.ToInt32(Constantes.precioIngredientes_TA.GetCodPrecioIngrediente(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString())), Convert.ToInt32(cbProveedores.SelectedValue))),
                Convert.ToInt32(cbProveedores.SelectedValue),
                Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString())), 
                Convert.ToDouble(Convert.ToDecimal(Constantes.precioIngredientes_TA.GetPrecio(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString()))))),
                Convert.ToInt32(Constantes.precioIngredientes_TA.GetCodPrecioIngrediente(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString())), Convert.ToInt32(cbProveedores.SelectedValue))));
            */




            //Constantes.ingredientes_TA.Update(tbNuevoNombre, Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.Text),cbIngrediente.Text);     //tbNombre.Text.ToString());
            //Constantes.precioIngredientes_TA.Insert((Convert.ToInt32(cbProveedores.SelectedValue.ToString())), (Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(tbNombre.Text.ToString()))), precio);

        }
    }

}
