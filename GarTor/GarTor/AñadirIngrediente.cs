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

    /// <summary>
    /// Clase para introducir nuevos ingredientes a la base de datos
    /// </summary>
    public partial class AñadirIngrediente : Form {
        public AñadirIngrediente()
        {
            InitializeComponent();

            cbMedidas.SelectedIndex = 0;//Mostramos el primer elemento del cbMedidas
            cbProveedores.DisplayMember = "Nombre_Proveedor";//Asignamos que se muestren los nombres de proveedor en el cbProveedores
            cbProveedores.ValueMember = "Cod_Proveedor";//Asignamos que el valor del proveedor seleccionado en cbProveedores sea su cod
            cbProveedores.DataSource = Constantes.proveedores_TA.GetData();//Rellenamos el cbProveedores con los datos de la tabla Proveedores
        }

        /// <summary>
        /// Metodo que añade a la base de datos el ingrediente introducido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                precio = (float)precio / (float)(Math.Round((double)Convert.ToSingle(cantidad.Value)));//Divide el precio entre la cantidad para obtener el precio por (Kg, L o Unidad)
                precio = (float)(Math.Round((double)precio, 2));//Redondeamos de nuevo para que muestre solo dos decimales

                if (verificar(tbNombre.Text.ToString()))
                {
                    Constantes.ingredientes_TA.Insert(tbNombre.Text.ToString());//Inserta un nuevo ingrediente
                    //Añade un precio y una union con un proveedor
                    Constantes.precioIngredientes_TA.Insert((Convert.ToInt32(cbProveedores.SelectedValue.ToString())), (Convert.ToInt32(Constantes.ingredientes_TA.GetCodIngrediente(tbNombre.Text.ToString()))), precio);
                    MessageBox.Show("Ingrediente Agregado correctamente");
                }
                else
                {
                    MessageBox.Show("El ingrediente ya existe");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el ingrediente");
            }

        }

        /// <summary>
        /// Metodo que verifica si existe ya un ingrediente con el nombre pasado por parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>True si no existe y False si existe</returns>
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