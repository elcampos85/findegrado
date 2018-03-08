using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GarTor
{

    /// <summary>
    /// Clase que consta de la ventana para vender articulos en la tienda con una lista y una cesta
    /// </summary>
    public partial class VentaTienda : Form
    {
        private bool listaCategoria = true;//Boolean para saber si estamos en la lista de categorias en el menu de imagenes
        private bool introducidoCantidad = false;//Boolean para saber si hemos introducido la cantidad o el peso o si hemos cerrado solo la ventana sin introducirlo
        public VentaTienda()
        {
            InitializeComponent();
            lFlecha.Visible = false;//Ocultamos la flecha que nos dice en que menu estamos
            Total();
        }


        /// <summary>
        /// Metodo que elimina el producto al seleccionarlo en la cesta de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Eliminar(object sender, DataGridViewCellEventArgs e)
        {
            if (cesta.CurrentCell.ColumnIndex == 0)//Evaluamos que se haga click en la primera columna
            {
                int num_fila = cesta.CurrentRow.Index;
                DialogResult result;
                MsgBoxUtil.HackMessageBox("Si", "No");
                result = MessageBox.Show("¿Desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cesta.Rows.RemoveAt(cesta.CurrentRow.Index);
                    Total();
                }
                else if (result == DialogResult.No)
                {
                }
            }
        }


        /// <summary>
        /// Metodo que finaliza la compra y abre una ventana para introducir el cambio de dinero
        /// y genera la factura con la venta hecha y la guarda en la ruta de facturas venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalizarCompra(object sender, EventArgs e)
        {
            Finalizar_Compra panel1 = new Finalizar_Compra();
            panel1.MinimizeBox = false;
            panel1.MaximizeBox = false;
            panel1.ShowIcon = false;
            panel1.ShowInTaskbar = false;
            panel1.ShowDialog();
            introducidoCantidad = true;
            if (Constantes.VENTA_HECHA)
            {
                //Se genera una factura con la compra realizada y la guarda en su carpeta correspondiente
                #region Generar Factura
                string factura = @"C:\GarTor\Facturas\VentasTienda\Factura" + DateTime.Now.ToString("dd-MM-yyyy_H.mm.ss") + ".txt";
                string texto = null;
                string fecha_dia = DateTime.Now.ToShortDateString();
                string fechaHora_dia = DateTime.Now.ToString();
                int num_Pedido = Convert.ToInt32(Constantes.pedidos_TA.getPedidosDia(fecha_dia));
                int cod_Pedido = 0;
                int num_detalle = 1;
                int cod_Factura=0;
                float cantidad = 0;
                float precio = 0.00f;
                string articulo = "";

                Constantes.pedidos_TA.Insert(num_Pedido, fecha_dia);
                cod_Pedido = Convert.ToInt32(Constantes.pedidos_TA.getCodigoPedido(num_Pedido, fecha_dia));//Cod pedido introducido
                Constantes.factVenta_TA.Insert(cod_Pedido,fecha_dia);
                cod_Factura = Convert.ToInt32(Constantes.factVenta_TA.getCodigoFactura(cod_Pedido));

                foreach (DataGridViewRow row in cesta.Rows)
                {
                    cantidad = Convert.ToSingle(row.Cells[Constantes.COLUMNA_UNIDADES].Value);
                    articulo = Convert.ToString(row.Cells[Constantes.COLUMNA_NOMBRE].Value);
                    precio = Convert.ToSingle(row.Cells[Constantes.COLUMNA_PRECIO].Value);
                    Constantes.detaPedidosVenta_TA.Insert(cod_Factura, num_detalle, cantidad,precio, articulo);
                    num_detalle += 1;
                }

                DataTable compra = Constantes.detaPedidosVenta_TA.GetDetallePedido(cod_Factura);//Creamos un datatable con el detalle del pedido de la factura introducida para recorrerlo
                String CadenaCompra = "";
                float total_factura = 0.00f;

                foreach (DataRow row in compra.Rows)
                {
                    float total = 0.00f;
                    string nom_Producto = Convert.ToString(row["Articulo"]);
                    int unidades = Convert.ToInt32(row["Cantidad"]);
                    float precio_detalle = Convert.ToSingle( row["Precio"]);
                    total = precio_detalle * (Convert.ToSingle(unidades));
                    
                    //Evaluamos que el nombre del producto sea mayor que 28 caracteres para acortarlo en la factura
                    //Damos formato a la cadena de compra de la factura con longitudes para tener unas tabulaciones entre columnas
                    if (nom_Producto.Length > 28)
                    {
                        CadenaCompra += String.Format("{0,-28}{1,8}{2,8}{3,12}\r\n", nom_Producto.Substring(0, 28), unidades, precio_detalle + " €", total.ToString("#,##0.##") + " €") + "\r\n"; //Para aplicar formato de columnas
                    }
                    else
                    {
                        CadenaCompra += String.Format("{0,-28}{1,8}{2,8}{3,12}\r\n", nom_Producto, unidades, precio_detalle + " €", total.ToString("#,##0.##") + " €") + "\r\n"; //Para aplicar formato de columnas
                    }
                    total_factura += total;
                }
                StreamWriter sw = new StreamWriter(factura);
                texto = "FACTURA SIMPLIFICADA" +
                    "\r\nPasteleria MARCO" +
                    "\r\nPaseo de los Jesuitas 18, Madrid" +
                    "\r\nTelf. 91 463 99 82" +
                    "\r\nN.I.F. 07487245D\r\n\r\n" +
                    String.Format("\r\n{0,-28}{1,8}{2,8}{3,12}\r\n", "Nombre Articulo", "Unidades", "Precio", "Total") + //Para aplicar formato de columnas
                    "\r\n" + CadenaCompra +
                    "\r\n TOTAL DE LA COMPRA: " + total_factura + " €\r\n"+
                    "\r\n IVA incluido" +
                    "\r\n Factura: " + Constantes.factVenta_TA.getCodigoFactura(cod_Pedido).ToString() ;
                sw.WriteLine(texto);
                sw.Close();
                #endregion

                AddIngresos();
                //Recargamos la lista de los articulos para que cargue las imagenes de categorias y ponga las flechas de menus superiores y la cesta por defecto
                this.listView1.Items.Clear();
                this.imageList1.Images.Clear();
                btAtrasVTienda.Visible = false;
                lFlecha.Visible = false;
                lCategoria.Text = "";
                cargarListaVenta();
                cesta.Rows.Clear();
                listaCategoria = true;
                Total();
                
            }
        }

        /// <summary>
        /// Agrega los ingresos del dia
        /// </summary>
        private void AddIngresos()
        {
            int facturas = Convert.ToInt32(Constantes.factVenta_TA.UltimaFactura());
            float gastos = 0.00f;
            float ingresos =Convert.ToSingle(Constantes.IMPORTE);
            if (Convert.ToInt32(Constantes.contabilidad_TA.ComprobarFechaFactura(DateTime.Now.ToShortDateString())) == 0)
            {
                Constantes.contabilidad_TA.Insert(DateTime.Now.ToShortDateString(), gastos, ingresos);
                MessageBox.Show("Insertado");
            }
            else
            {
                float actual_ingresos = Convert.ToSingle(Constantes.contabilidad_TA.getIngresos(DateTime.Now.ToShortDateString()));
                MessageBox.Show("Actualizando " + actual_ingresos.ToString());
                Constantes.contabilidad_TA.UpdateIngresos(Convert.ToDouble(ingresos + actual_ingresos), Convert.ToInt32(Constantes.contabilidad_TA.GetId(DateTime.Now.ToShortDateString())));
               
            }
                
        }

        /// <summary>
        /// Metodo que calcula el precio Total de la cesta
        /// </summary>
        private void Total()
        {
            float suma = 0;
            foreach (DataGridViewRow row in cesta.Rows)
            {
                try
                {
                    suma += (float)Convert.ToSingle(row.Cells[Constantes.COLUMNA_UNIDADES].Value) * (float)Convert.ToSingle(row.Cells[Constantes.COLUMNA_PRECIO].Value);
                }
                catch (Exception e)
                {

                }
            }
            lPrecio.Text = "Total: " + Math.Round(suma, 2).ToString() + " €";
            Constantes.IMPORTE = Math.Round(suma, 2).ToString();
        }

        /// <summary>
        /// Metodo que elimina todos los articulos que contiene la cesta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EliminarCestaCompleta(object sender, EventArgs e)
        {
            DialogResult result;
            MsgBoxUtil.HackMessageBox("Si", "No");
            result = MessageBox.Show("¿Desea eliminar TODOS los articulos?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                cesta.Rows.Clear();
                Total();
            }
            else if (result == DialogResult.No)
            {
            }
        }
        
        /// <summary>
        /// Metodo que carga la lista de Venta con las imagenes de las categorias desde su path
        /// </summary>
        private void cargarListaVenta()
        {
            DirectoryInfo dir = new DirectoryInfo(Constantes.CATEGORIAS_RUTA);
            int j = 0;//Variable para asignar un index a cada imagen diferente
            foreach (FileInfo file in dir.GetFiles())//Recorremos todas las imagenes que hay en el directorio categorias
            {
                this.listView1.View = View.LargeIcon;
                this.imageList1.ImageSize = new Size(Constantes.TAMANO_IMAGENES, Constantes.TAMANO_IMAGENES);
                try
                {
                    this.imageList1.Images.Add(System.Drawing.Image.FromFile(file.FullName));
                    this.listView1.Items.Add(new ListViewItem { ImageIndex = j, Text = file.Name.Substring(0, file.Name.Length - 4) });
                    j++;
                }
                catch
                {
                    Console.WriteLine("No es un archivo de imagen");
                }
                this.listView1.LargeImageList = this.imageList1;
            }
        }

        /// <summary>
        /// Metodo que se ejecuta al cargarse la VentaTienda y que cargamos la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VentaTienda_Load(object sender, EventArgs e)
        {
            cargarListaVenta();
        }

        /// <summary>
        /// Metodo que vuelve a cargar la lista de categorias si nos encontramos en una categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volverACategoria(object sender, EventArgs e)
        {
            btAtrasVTienda.Visible = false;//Volvemos a ocultar el boton de atras
            listaCategoria = true;//Decimos que estamos en la lista categoria para que se cargue
            lFlecha.Visible = false;//Volvemos a ocultar la flecha
            lCategoria.Text = "";//Borramos la categoria en la que estabamos

            DirectoryInfo dir = new DirectoryInfo(Constantes.CATEGORIAS_RUTA);
            int j = 0;
            this.listView1.Items.Clear();//Eliminamos la lista actual para que no se queden las imagenes que habia
            this.imageList1.Images.Clear();//Eliminamos la lista actual para que no se queden las imagenes que habia
            foreach (FileInfo file in dir.GetFiles())//Recorremos las categorias y las volvemos a cargar en la lista
            {
                this.listView1.View = View.LargeIcon;
                this.imageList1.ImageSize = new Size(Constantes.TAMANO_IMAGENES, Constantes.TAMANO_IMAGENES);
                try
                {
                    this.imageList1.Images.Add(System.Drawing.Image.FromFile(file.FullName));
                    this.listView1.Items.Add(new ListViewItem { ImageIndex = j, Text = file.Name.Substring(0, file.Name.Length - 4) });
                    j++;
                }
                catch
                {
                    Console.WriteLine("No es un archivo de imagen");
                }
                this.listView1.LargeImageList = this.imageList1;
            }
        }

        /// <summary>
        /// Metodo que calcula el total de la cesta si se cambia un precio desde la tabla de la cesta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambioPrecio(object sender, DataGridViewCellEventArgs e)
        {
           Total();
        }

        /// <summary>
        /// Metodo que evalua las selecciones de la lista, si estamos en categorias carga los articulos de esa categoria
        /// y si estamos en una categoria y clicamos un articulo abre una ventana para introducir las unidades o el peso y agrega ese articulo a la cesta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Seleccion(object sender, MouseEventArgs e)
        {
            introducidoCantidad = false;//Establecemos que no hemos introducido la cantidad
            if (listaCategoria)//Si estamos en la lista de categoria carga los articulos referentes a la categoria seleccionada desde su directorio
            {
                ListView.SelectedIndexCollection seleccionado = this.listView1.SelectedIndices;
                foreach (int index in seleccionado)
                {
                    DirectoryInfo dir = new DirectoryInfo(Constantes.PRODUCTOS_RUTA + "/" + this.listView1.Items[index].Text);
                    lCategoria.Text = this.listView1.Items[index].Text.ToString();
                    int j = 0;
                    this.listView1.Items.Clear();//Eliminamos la lista actual para que no se queden las imagenes que habia
                    this.imageList1.Images.Clear();//Eliminamos la lista actual para que no se queden las imagenes que habia
                    foreach (FileInfo file in dir.GetFiles())//Agregamos las imagenes de los articulos de la categoria seleccionada
                    {
                        this.listView1.View = View.LargeIcon;
                        this.imageList1.ImageSize = new Size(Constantes.TAMANO_IMAGENES, Constantes.TAMANO_IMAGENES);
                        try
                        {
                            this.imageList1.Images.Add(System.Drawing.Image.FromFile(file.FullName));
                            this.listView1.Items.Add(new ListViewItem { ImageIndex = j, Text = file.Name.Substring(0, file.Name.Length - 4) });
                            j++;
                        }
                        catch
                        {
                            Console.WriteLine("No es un archivo de imagen");
                        }
                        this.listView1.LargeImageList = this.imageList1;
                        lFlecha.Visible = true;//Ponemos visible la flecha para indicar en que categoria estamos
                    }
                }
                btAtrasVTienda.Visible = true;//Habilitamos el boton atras para volver a categorias
                listaCategoria = false;//Decimos que ya no estamos en la lista de categoria
            }
            else//Entramos en el else cuando estamos dentro de una categoria
            {
                try
                {
                    if (!introducidoCantidad)//Si no hemos introducido la cantidad o el peso nos abre la ventana para introducirlo
                    {
                        Intro_Peso_UD panel1 = new Intro_Peso_UD();
                        panel1.MinimizeBox = false;
                        panel1.MaximizeBox = false;
                        panel1.ShowIcon = false;
                        panel1.ShowInTaskbar = false;
                        panel1.ShowDialog();
                        introducidoCantidad = true;//Decimos que ya hemos introducido la cantidad
                    }
                    if (Constantes.PESO_UD_PRODUCTO != null && Convert.ToDouble(Constantes.PESO_UD_PRODUCTO) > 0 && Convert.ToDouble(Constantes.PESO_UD_PRODUCTO) > 0.000)//Si el peso del producto no es nulo y es mayor que 0 sera que hemos introducido un peso y que no hemos cerrado la ventana porque no queriamos introducir ese articulo
                    {
                        ListView.SelectedIndexCollection seleccionado = this.listView1.SelectedIndices;//Cogemos el articulo seleccionado para agregarlo a la cesta
                        foreach (int index in seleccionado)
                        {
                            cesta.Rows.Add(1);
                            cesta.Rows[cesta.RowCount - 1].Cells[0].Value = Resource1.bin;
                            cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_NOMBRE].Value = this.listView1.Items[index].Text;
                            cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_UNIDADES].Value = Constantes.PESO_UD_PRODUCTO;
                            if (lCategoria.Text.Equals("Suplementos"))//Evaluamos si la categoria en la que esstamos es suplementos ya que es una tabla diferente y tenemos que coger el precio con una consulta diferente
                            {
                                cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_PRECIO].Value = (float)Constantes.suplemento_TA.getPreSupleNombre(this.listView1.Items[index].Text);
                            }
                            else
                            {
                                cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_PRECIO].Value = (float)Constantes.preciosVenta_TA.GetPrecioVenta((int)Constantes.productos_TA.GetCodProducto(this.listView1.Items[index].Text));
                            }
                            cesta.FirstDisplayedScrollingRowIndex = cesta.RowCount - 1;//Hacemos que el scroll de la cesta baje hasta el ultimo al introducir articulos si hay muchos
                            Total();
                        }
                        Constantes.PESO_UD_PRODUCTO = "0.000";//Ponemos a 0 el peso/unidades para asignar que no hemos introducido nada para los siguientes articulos que seleccionemos
                    }
                }catch(Exception ex)
                {

                }
                finally
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        item.Selected = false;//Deseleccionamos los items de la lista para que no queden azules y para no tener problemas a la hora de volver a clicar en el mismo item
                    }
                }
            }
        }

        /// <summary>
        /// Metodo que abre la ventana de descuentos o extras a introducir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void descuentoExtra(object sender, EventArgs e)
        {
            try
            {
                DescuentoExtra panel1 = new DescuentoExtra();
                panel1.MinimizeBox = false;
                panel1.MaximizeBox = false;
                panel1.ShowIcon = false;
                panel1.ShowInTaskbar = false;
                panel1.ShowDialog();
                if (Constantes.PRECIO_ESTRELLA != null && Convert.ToDouble(Constantes.PRECIO_ESTRELLA) != 0)//Evaluamos que hayamos introducido un descuento o extra y que el precio no este vacio
                {
                    String concepto = "";
                    if (Convert.ToInt32(Constantes.PRECIO_ESTRELLA) < 0)//Si el precio es positivo sera un extra mientras que si es negativo sera un descuento
                    {
                        concepto = "Descuento";
                    }
                    else
                    {
                        concepto = "Extra";
                    }
                    cesta.Rows.Add(1);
                    cesta.Rows[cesta.RowCount - 1].Cells[0].Value = Resource1.bin;
                    cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_NOMBRE].Value = concepto;
                    cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_UNIDADES].Value = "1";
                    cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_PRECIO].Value = Convert.ToDouble(Constantes.PRECIO_ESTRELLA);
                    cesta.FirstDisplayedScrollingRowIndex = cesta.RowCount - 1;
                    Total();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("No se admite ese precio y no se introdujo");
            }
            finally
            {
                Constantes.PRECIO_ESTRELLA = "0";//Volvemos a poner el precio a 0 para que no queden residuos
            }
        }
    }    
}