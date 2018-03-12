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
    /// Formulario para modificar ingredientes
    /// </summary>
    public partial class ModificarIngrediente : Form
    {
        /// <summary>
        /// Constructor de la clase.
        /// Rellenar los comboBox de proveedores y de ingredientes
        /// </summary>
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

        }
        /// <summary>
        /// Rellena los datos necesarios, ya sabidos por el programa, del ingrediente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbIngrediente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbIngrediente.SelectedItem != null)
            {
                //Introduce el precio actual del ingrediente
                units.Value = Convert.ToDecimal(Constantes.precioIngredientes_TA.GetPrecio(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString()))));
                //Rellena el textbox para el cambio de nombre de ingrediente
                tbNuevoNombre.Text = cbIngrediente.Text;
                //Introduce el proveedor actual del ingrediente
                cbProveedores.SelectedIndex = Convert.ToInt32(Constantes.precioIngredientes_TA.GetCodProveedor(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString())))) - 1;
            }
        }
        /// <summary>
        /// Boton para modificar el ingrediente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modificar_Click(object sender, EventArgs e)
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
                
                String nuevoNombre = tbNuevoNombre.Text;
                String nombre = cbIngrediente.SelectedValue.ToString();
                int codProv = Convert.ToInt32(Constantes.precioIngredientes_TA.GetCodProveedor(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString()))));
                int codProvNew = (int)cbProveedores.SelectedValue;
                int codIng = Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(nombre));
                int codPrecio = (int)Constantes.precioIngredientes_TA.GetCodPrecioIngrediente(codIng, codProv);
                float precioNuevo = (float)units.Value;
                float precioActual = Convert.ToSingle(Constantes.precioIngredientes_TA.GetPrecio(Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(cbIngrediente.SelectedValue.ToString()))));
                



                if (verificar(nuevoNombre)|| nombre.Equals(nuevoNombre))
                {
                    Constantes.ingredientes_TA.Update(nuevoNombre, codIng, nombre);//update del nombre del ingrediente
                    Constantes.precioIngredientes_TA.UpdatePrecioIngrediente(precioNuevo, codProvNew, codPrecio);//update del precio y/o el proveedor

                    cbIngrediente.DataSource = Constantes.ingredientes_TA.ComboboxIngredientes();//Rellena el comboBox de ingredientes por si se modifico el nombre
                    MessageBox.Show("El ingrediente se modifico correctamente");
                }
                else
                {
                    MessageBox.Show("El ingrediente ya existe");
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al modificar el ingrediente");
            }
        }
        /// <summary>
        /// Verifica si el nuevo nombre a introducir existe en la BBDD
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>True si no existe, False si existe</returns>
        public bool verificar(string nombre)
        {
            if (Constantes.ingredientes_TA.Verificacion(nombre) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
