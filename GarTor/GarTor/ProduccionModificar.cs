using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    public partial class ProduccionModificar : Form
    {
        #region VARIABLES
        private string ruta_foto = "";
        private const int COLUMNA_PRECIO = 3;
        private SqlConnection conexion;
        private string stringConexion;
        #endregion

        public ProduccionModificar()
        {
            InitializeComponent();
            stringConexion = ConfigurationManager.ConnectionStrings["GarTor.Properties.Settings.PasteleriaConnectionString"].ConnectionString;//Se crea la conexion de configuracion del proyecto para utilizar la base de datos
        }

        private void ProduccionModificar_Load(object sender, EventArgs e)
        {
            cbTipo.DisplayMember = "Categoria_Producto";
            cbTipo.ValueMember = "Categoria_Producto";

            // cbGrupo.DataSource = producTA.GetCategoria();



            using (conexion = new SqlConnection(stringConexion))//Se crea la conexion a la base de datos y se realiza la consulta de las distintas categorias
            using (SqlDataAdapter adaptador = new SqlDataAdapter(Constantes.QUERY_CONSULTA_CATEGORIAS, conexion))//Se almacena el resultado en un adaptador
            {
                DataTable dt = new DataTable();
                adaptador.Fill(dt);//Rellenamos el DataTable con las filas de la consulta en una unica columna
                cbTipo.DataSource = dt;
            }

            cbProducto.DisplayMember = "Nombre_Producto";
            cbProducto.ValueMember = "Nombre_Producto";

            cbProducto.DataSource = Constantes.productos_TA.GetProductosOrdenados();
            
        }

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

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (verificar(tbNuevoNombre.Text))
            {
                Constantes.productos_TA.Insert(tbNuevoNombre.Text, cbTipo.Text);
                Constantes.preciosMayor_TA.Insert((int)Constantes.productos_TA.GetCodProducto(tbNuevoNombre.Text), (Double)precioMayor.Value);
                Constantes.preciosVenta_TA.Insert((int)Constantes.productos_TA.GetCodProducto(tbNuevoNombre.Text), (Double)precioTienda.Value);
                string path = Constantes.PRODUCTOS_RUTA + "/" + cbTipo.Text.ToString() + "/" + cbProducto.SelectedValue + Constantes.EXTENSION;
                imagen.Image.Dispose();
                imagen.Image = null;
                System.IO.File.Delete(path); 
                imagen.Image.Save(Constantes.PRODUCTOS_RUTA + "/" + cbTipo.Text.ToString() + "/" + tbNuevoNombre.Text + Constantes.EXTENSION, ImageFormat.Png);

                MessageBox.Show("Producto agregado correctamente");
                //MessageBox.Show(Constantes.productos_TA.GetCodProducto(tbNombre.Text) + " " + nMayor.Value);
            }
            else
            {
                MessageBox.Show("El producto ya existe");
            }
        }
    }
}
