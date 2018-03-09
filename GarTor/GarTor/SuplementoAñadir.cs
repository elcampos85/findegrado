using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    /// <summary>
    /// Clase para añadir suplementos a la BBDD
    /// </summary>
    public partial class SuplementoAñadir : Form
    {
        private string grupo = "Suplementos";
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public SuplementoAñadir()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo para agregar el suplemento a la BBDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificar(tbNombre.Text))
                {
                    Constantes.suplemento_TA.Insert(tbNombre.Text, Convert.ToDouble(NPrecio.Value));
                    imagen.Image.Save(Constantes.PRODUCTOS_RUTA + "/" + grupo + "/" + tbNombre.Text + Constantes.EXTENSION, ImageFormat.Png);

                    MessageBox.Show("Suplemento agregado correctamente");
                }
                else
                {
                    MessageBox.Show("El suplemento ya existe");
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("El suplemento no se agregó");
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
        /// Boton que abre el explorador de archivos para seleccionar la imagen que tendra el suplemento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bImage_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta_foto = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    ruta_foto = imagen;
                    this.imagen.Image = Image.FromFile(imagen);
                    this.imagen.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
