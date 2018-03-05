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
    

    public partial class Produccion : Form
    {
        #region
            private string ruta_foto = "";
            private const int COLUMNA_PRECIO = 3;
            private SqlConnection conexion;
            private string stringConexion;
        #endregion


        public Produccion()
        {
            InitializeComponent();
            stringConexion = ConfigurationManager.ConnectionStrings["GarTor.Properties.Settings.PasteleriaConnectionString"].ConnectionString;//Se crea la conexion de configuracion del proyecto para utilizar la base de datos
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float precio; 

            
            precio = (float)(Math.Round((double)Convert.ToSingle(units.Value) * (float) Convert.ToSingle(Constantes.precioIngredientes_TA.PrecioIngrediente(cbIngredientes.SelectedValue.ToString())), 2));

            switch (cbMedidas.SelectedIndex)
            {
                case 2://g
                    precio = precio / 1000;
                    break;
                case 3://mg
                    precio = precio / 1000000;
                    break;
                case 5://cL
                    precio = precio / 100;
                    break;
                case 6://mL
                    precio = precio / 1000;
                    break;

            }
            //(float)(Math.Round((double)float, 2);
            if ((float)(Math.Round((double)precio, 2))>0)
            {
                lista.Rows.Add(1);

                lista.Rows[lista.RowCount - 1].Cells[0].Value = Resource1.bin;
                lista.Rows[lista.RowCount - 1].Cells[1].Value = cbIngredientes.SelectedValue.ToString();
                lista.Rows[lista.RowCount - 1].Cells[2].Value = units.Value + " " + cbMedidas.SelectedItem;
                lista.Rows[lista.RowCount - 1].Cells[3].Value = (float)(Math.Round((double)precio, 2));
                lista.FirstDisplayedScrollingRowIndex = lista.RowCount - 1;
            }
            



            Total();
        }

        private void Eliminar(object sender, DataGridViewCellEventArgs e)
        {
            if (lista.CurrentCell.ColumnIndex == 0)
            {
                int num_fila = lista.CurrentRow.Index;
                DialogResult result;
                MsgBoxUtil.HackMessageBox("Si", "No");
                result = MessageBox.Show("¿Desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lista.Rows.RemoveAt(lista.CurrentRow.Index);
                    Total();
                }
            }
        }
        private void Total()
        {
            float suma = 0;
            foreach (DataGridViewRow row in lista.Rows)
            {
                suma += Convert.ToSingle(row.Cells[COLUMNA_PRECIO].Value.ToString());
            }

            lPrecio.Text = suma.ToString("#,##0.##")+" €";

            nMayor.Value = (decimal)suma +10;
            nTienda.Value= (decimal)suma +20;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            

            cbGrupo.DisplayMember = "Categoria_Producto";
            cbGrupo.ValueMember = "Categoria_Producto";

            using (conexion = new SqlConnection(stringConexion))//Se crea la conexion a la base de datos y se realiza la consulta de las distintas categorias
            using (SqlDataAdapter adaptador = new SqlDataAdapter(Constantes.QUERY_CONSULTA_CATEGORIAS, conexion))//Se almacena el resultado en un adaptador
            {
                DataTable dt = new DataTable();
                adaptador.Fill(dt);//Rellenamos el DataTable con las filas de la consulta en una unica columna
                cbGrupo.DataSource = dt;
            }

            cbIngredientes.DisplayMember = "Nombre_Ingrediente";
            cbIngredientes.ValueMember = "Nombre_Ingrediente";

            cbIngredientes.DataSource = Constantes.ingredientes_TA.ComboboxIngredientes();

            cbMedidas.SelectedIndex = 0;
            Total();
        }

        private void bImage_Click(object sender, EventArgs e)
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

        private void bAgregar_Click(object sender, EventArgs e)
        {


            if (verificar(tbNombre.Text))
            {
                if (tbNombre.Text.Length <= 0)
                {
                    MessageBox.Show("El producto debe tener un nombre");
                    MessageBox.Show(cbGrupo.Text.ToString());
                }
                else if(imagen.Image == null)
                {
                    MessageBox.Show("El producto debe contener una imagen que lo haga referencia");
                }
                else
                {
                    try
                    {

                        imagen.Image.Save(Constantes.PRODUCTOS_RUTA + "/" + cbGrupo.Text.ToString() + "/" + tbNombre.Text + Constantes.EXTENSION, ImageFormat.Png);
                        Constantes.productos_TA.Insert(tbNombre.Text, cbGrupo.Text);
                        Constantes.preciosMayor_TA.Insert((int)Constantes.productos_TA.GetCodProducto(tbNombre.Text), (Double)nMayor.Value);
                        Constantes.preciosVenta_TA.Insert((int)Constantes.productos_TA.GetCodProducto(tbNombre.Text), (Double)nTienda.Value);
                        MessageBox.Show("Producto agregado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debe rellenar correctamente los campos");
                    }
                }
                  
                //MessageBox.Show(Constantes.productos_TA.GetCodProducto(tbNombre.Text) + " " + nMayor.Value);
            }
            else
            {
                MessageBox.Show("El producto ya existe");
            }
            
                
        }

        public bool verificar(string nombre)
        {
            if (Constantes.productos_TA.Verificacion(nombre)==0)
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
