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
                this.imagen.Image = Image.FromFile(ruta_foto);
                this.imagen.SizeMode = PictureBoxSizeMode.Zoom;
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
                float precio=Convert.ToSingle(NPrecio.Value);
                int codSuplemento= Convert.ToInt32(cbSuplemento.SelectedValue);
                
                ruta = Constantes.PRODUCTOS_RUTA + "/" + grupo + "/" + nombre + Constantes.EXTENSION;
                nuevaRuta = Constantes.PRODUCTOS_RUTA + "/" + grupo + "/" + nombreNuevo + Constantes.EXTENSION;

                if (!nombre.Equals(nombreNuevo))
                {
                    cambio = true;
                }

                if (verificar(nombreNuevo)|| File.Exists(ruta)|| !File.Exists(ruta))
                {
                    
                    if (!ruta.Equals(nuevaRuta))
                    {
                        if (cambio)
                        {
                            this.imagen.Image.Save(nuevaRuta, ImageFormat.Png);
                            this.imagen.Image.Dispose();
                            this.imagen.Image = null;
                            File.Delete(ruta);
                            Constantes.suplemento_TA.UpdateSuplemento(nombreNuevo, Convert.ToDouble(precio), codSuplemento, nombre);
                            MessageBox.Show("Suplemento modificado correctamente");
                        }
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
        /// <summary>
        /// Metodo para elegir una nueva imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ruta_foto = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    ruta_foto = imagen;
                    this.imagen.Image = Image.FromFile(imagen);
                    this.imagen.SizeMode = PictureBoxSizeMode.Zoom;
                }
                cambio = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
