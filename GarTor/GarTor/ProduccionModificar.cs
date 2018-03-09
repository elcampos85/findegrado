using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    /// <summary>
    /// Formulario para modificar productos
    /// </summary>
    public partial class ProduccionModificar : Form
    {
        #region VARIABLES
        private string ruta_foto = "";
        private const int COLUMNA_PRECIO = 3;
        private SqlConnection conexion;
        private string stringConexion;
        #endregion
        /// <summary>
        /// Constructor de la clase.
        /// Establece una conexion con la BBDD para realizar consultas
        /// </summary>
        public ProduccionModificar()
        {
            InitializeComponent();
            stringConexion = ConfigurationManager.ConnectionStrings["GarTor.Properties.Settings.PasteleriaConnectionString"].ConnectionString;//Se crea la conexion de configuracion del proyecto para utilizar la base de datos
        }
        /// <summary>
        /// Rellena el comboBox de categoria 
        /// </summary>
        private void rellenarCbTipo()
        {
            using (conexion = new SqlConnection(stringConexion))//Se crea la conexion a la base de datos y se realiza la consulta de las distintas categorias
            using (SqlDataAdapter adaptador = new SqlDataAdapter(Constantes.QUERY_CONSULTA_CATEGORIAS, conexion))//Se almacena el resultado en un adaptador
            {
                DataTable dt = new DataTable();
                adaptador.Fill(dt);//Rellenamos el DataTable con las filas de la consulta en una unica columna
                cbTipo.DataSource = dt;
            }
        }
        /// <summary>
        /// Metodo para rellenar los comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProduccionModificar_Load(object sender, EventArgs e)
        {
            cbTipo.DisplayMember = "Categoria_Producto";
            cbTipo.ValueMember = "Categoria_Producto";

            rellenarCbTipo();

            cbProducto.DisplayMember = "Nombre_Producto";
            cbProducto.ValueMember = "Nombre_Producto";

            cbProducto.DataSource = Constantes.productos_TA.GetProductosOrdenados();
            
        }
        /// <summary>
        /// Rellena con los datos del producto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbProducto.SelectedItem != null)
            {
                int cod = Convert.ToInt32(Constantes.productos_TA.GetCodProducto(cbProducto.Text));
                //Rellena el textbox para el cambio de nombre de ingrediente
                tbNuevoNombre.Text = cbProducto.Text;
                //Rellena el precio de venta en tienda
                precioTienda.Value = Convert.ToDecimal(Constantes.preciosVenta_TA.GetPrecioVenta(cod));
                //Rellena el precio de venta al mayor
                //precioMayor.Value = Convert.ToDecimal(Constantes.preciosMayor_TA.GetPrecioMayor(cod));
                //Rellena categoria del producto
                cbTipo.SelectedValue = Constantes.productos_TA.GetCategoria(cod);

                //Rellena la imagen
                //MessageBox.Show(Constantes.PRODUCTOS_RUTA + "/" + cbTipo.SelectedValue + "/" + cbProducto.SelectedValue + Constantes.EXTENSION);
                this.imagen.Image = Image.FromFile(Constantes.PRODUCTOS_RUTA+"/"+cbTipo.SelectedValue+"/"+cbProducto.SelectedValue+Constantes.EXTENSION);
                this.imagen.SizeMode = PictureBoxSizeMode.Zoom;

                
            }
        }
        /// <summary>
        /// Abre el explorador de archivos para seleccionar la nueva imagen del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
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
        /// <summary>
        /// Verifica si el nuevo nombre a introducir existe en la BBDD
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>True si no existe, False si existe</returns>
        public bool verificar(string nombre)
        {
            if (Constantes.productos_TA.Verificacion(nombre) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Modifica el producto con los datos agregados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Constantes.PRODUCTOS_RUTA + "/" + cbTipo.Text.ToString() + "/" + cbProducto.SelectedValue + Constantes.EXTENSION;
                if (verificar(tbNuevoNombre.Text) || File.Exists(ruta) || !File.Exists(ruta))
                {
                    int codProd = Convert.ToInt32(Constantes.productos_TA.GetCodProducto(cbProducto.SelectedValue.ToString()));
                    
                    File.Delete(ruta);
                    imagen.Image.Save(Constantes.PRODUCTOS_RUTA + "/" + cbTipo.Text.ToString() + "/" + tbNuevoNombre.Text + Constantes.EXTENSION, ImageFormat.Png);

                    Constantes.productos_TA.UpdateProducto(tbNuevoNombre.Text, cbTipo.Text,codProd);
                    Constantes.preciosMayor_TA.UpdatePreciosMayor((Double)precioMayor.Value,Convert.ToInt32(Constantes.preciosMayor_TA.getCodPrecioMayor(codProd)));
                    Constantes.preciosVenta_TA.UpdatePreciosVenta((Double)precioTienda.Value,Convert.ToInt32(Constantes.preciosVenta_TA.getCodPrecioVenta(codProd)));
                   

                    MessageBox.Show("Producto Modificado correctamente");
                    cbProducto.DataSource = Constantes.productos_TA.GetProductosOrdenados();
                    rellenarCbTipo();
                }
                else
                {
                    MessageBox.Show("Ya existe un producto con ese nombre");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al modificar un producto");
            }

            
        }
    }
}
