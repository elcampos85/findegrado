using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    public partial class AñadirIngrediente : Form {


        public AñadirIngrediente()
        {
            InitializeComponent();

            cbMedidas.SelectedIndex = 0;

            cbProveedores.DisplayMember = "Nombre_Proveedor";
            cbProveedores.ValueMember = "Cod_Proveedor";

            cbProveedores.DataSource = Constantes.proveedores_TA.GetData();

        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            try
            {
                float precio;
                switch (cbMedidas.SelectedIndex)//Recalcula el precio de unidad, Litro o Kilo a cualquier otra medida
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
                Constantes.ingredientes_TA.Insert(tbNombre.Text.ToString());//Inserta un nuevo ingrediente
                                                                            //Añade un precio y una union con un proveedor
                Constantes.precioIngredientes_TA.Insert((Convert.ToInt32(cbProveedores.SelectedValue.ToString())), (Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(tbNombre.Text.ToString()))), precio);

                MessageBox.Show("Ingrediente Agregado correctamente");
            } catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el ingrediente");
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

                

        }
    
        /* if(Char.IsDigit(e.KeyChar))
         {
             e.Handled = false;
         }
         else if (Char.IsControl(e.KeyChar))
         {
             e.Handled = false;
         }
         else if (Char.IsSeparator(e.KeyChar))
         {
             e.Handled = false;
         }
         else
         {
             e.Handled = true;
         }*/
    }
    
}
