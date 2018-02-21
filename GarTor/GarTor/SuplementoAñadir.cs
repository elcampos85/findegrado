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
    public partial class SuplementoAñadir : Form
    {
        public SuplementoAñadir()
        {
            InitializeComponent();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string grupo = "Suplementos";
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
