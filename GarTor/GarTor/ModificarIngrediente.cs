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

            cbProveedores.DisplayMember = "Nombre_Proveedor";
            cbProveedores.ValueMember = "Cod_Proveedor";

            cbProveedores.DataSource = Constantes.proveedores_TA.GetData();

            cbIngrediente.DisplayMember = "Nombre_Ingrediente";
            cbIngrediente.ValueMember = "Nombre_Ingrediente";

            cbIngrediente.DataSource = Constantes.ingredientes_TA.ComboboxIngredientes();

           


            units.Value = Convert.ToDecimal(Constantes.precioIngredientes_TA.GetPrecio(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString()))));
            tbNuevoNombre.Text = cbIngrediente.Text;
        }

        private void CambioPrecio(object sender, EventArgs e)
        {
            if(cbIngrediente.SelectedItem != null)
            {
                units.Value = Convert.ToDecimal(Constantes.precioIngredientes_TA.GetPrecio(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString()))));
                tbNuevoNombre.Text = cbIngrediente.Text;

                cbProveedores.SelectedIndex = Convert.ToInt32(Constantes.precioIngredientes_TA.GetCodProveedor(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString()))))-1;
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

            String nuevoNombre= tbNuevoNombre.Text;
            String nombre= cbIngrediente.SelectedValue.ToString();
            int codProv= Convert.ToInt32(Constantes.precioIngredientes_TA.GetCodProveedor(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString()))));
            int codProvNew = (int)cbProveedores.SelectedValue;
            int codIng =Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(nombre)) ;
            int codPrecio = (int)Constantes.precioIngredientes_TA.GetCodPrecioIngrediente(codIng, codProv);
            float precioNuevo=(float) units.Value;
            float precioActual=Convert.ToSingle(Constantes.precioIngredientes_TA.GetPrecio(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString()))));



            Constantes.ingredientes_TA.Update(nuevoNombre,codIng,nombre);
            Constantes.precioIngredientes_TA.UpdatePrecioIngrediente(precioNuevo, codProvNew ,codPrecio);

            cbIngrediente.DataSource = Constantes.ingredientes_TA.ComboboxIngredientes();
        }
    }

}
