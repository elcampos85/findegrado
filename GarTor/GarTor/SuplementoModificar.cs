using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    /// <summary>
    /// Clase para modificar suplementos
    /// </summary>
    public partial class SuplementoModificar : Form
    {
        private string ruta = "";
        private string nuevaRuta = "";
        private string ruta_foto="";
        private bool cambio = false;
        private bool cambioPrecio = false;
        private string grupo = "Suplementos";
        /// <summary>
        /// Constructor de la clase.
        /// Se rellena el comboBox de suplementos
        /// </summary>
        public SuplementoModificar()
        {
            InitializeComponent();

            cbSuplemento.DisplayMember = "Nom_Suplemento";
            cbSuplemento.ValueMember = "Cod_Suplemento";

            cbSuplemento.DataSource = Constantes.suplemento_TA.GetData();

        }
        /// <summary>
        /// Metodo para actualizar los datos de cada suplemento cuando es seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSuplemento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSuplemento.SelectedItem != null)
            {
                tbNombre.Text = Constantes.suplemento_TA.GetNombreSuplemento(Convert.ToInt32(cbSuplemento.SelectedValue));
                NPrecio.Value = Convert.ToDecimal(Constantes.suplemento_TA.GetPrecioSuplemento(Convert.ToInt32(cbSuplemento.SelectedValue)));

                //Rellena la imagen
                ruta_foto = Constantes.PRODUCTOS_RUTA + "/" + grupo + "/" + Constantes.suplemento_TA.GetNombreSuplemento(Convert.ToInt32(Convert.ToInt32(cbSuplemento.SelectedValue))) + Constantes.EXTENSION;
            }
        }
        /// <summary>
        /// Metodo para modificar el suplemento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre=Convert.ToString(Constantes.suplemento_TA.GetNombreSuplemento(Convert.ToInt32(cbSuplemento.SelectedValue)));
                String nombreNuevo= tbNombre.Text;
                int codSuplemento = Convert.ToInt32(cbSuplemento.SelectedValue);
                float precioBBDD = Convert.ToSingle(Constantes.suplemento_TA.GetPrecioSuplemento(codSuplemento));
                float precio = Convert.ToSingle(NPrecio.Value);
                
                ruta = Constantes.PRODUCTOS_RUTA + "/" + grupo + "/" + nombre + Constantes.EXTENSION;
                nuevaRuta = Constantes.PRODUCTOS_RUTA + "/" + grupo + "/" + nombreNuevo + Constantes.EXTENSION;

                if (!nombre.Equals(nombreNuevo))
                {
                    cambio = true;
                }

                if (verificar(nombreNuevo)|| File.Exists(ruta)|| !File.Exists(ruta))
                {
                    
                    if (!ruta.Equals(nuevaRuta) || precio != precioBBDD)
                    {
                        if (cambio)
                        {
                            File.Move(ruta, nuevaRuta);
                        }

                        Constantes.suplemento_TA.UpdateSuplemento(nombreNuevo, Convert.ToDouble(precio), codSuplemento, nombre);
                        MessageBox.Show("Suplemento modificado correctamente");
                        cambio = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar");
                    }
                    
                    cbSuplemento.DataSource = Constantes.suplemento_TA.GetData();

                }
                else
                {
                    MessageBox.Show("El suplemento ya existe");
                }

                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo modificar el suplemento");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
        /// <summary>
        /// Verifica si el nuevo nombre a introducir existe en la BBDD
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>True si no existe, False si existe</returns>
        public bool verificar(string nombre)
        {
            if (Constantes.suplemento_TA.Verificacion(nombre) == 0)
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
