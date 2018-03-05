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
    public partial class VentaTienda : Form
    {
        private bool listaCategoria = true;
        private bool introducidoCantidad = false;
        public VentaTienda()
        {
            InitializeComponent();
            lFlecha.Visible = false;
            Total();
        }

        private void Eliminar(object sender, DataGridViewCellEventArgs e)
        {
            if (cesta.CurrentCell.ColumnIndex == 0)
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
                DateTime fecha_dia = DateTime.Now.Date;
                DateTime fechaHora_dia = DateTime.Now;
                int num_Pedido = Convert.ToInt32(Constantes.pedidos_TA.getPedidosDia(fecha_dia));
                int cod_Pedido = 0;
                int num_detalle = 1;
                int cod_Factura=0;
                float cantidad = 0;
                float precio = 0.00f;
                string articulo = "";

                Constantes.pedidos_TA.Insert(num_Pedido, fecha_dia);
                cod_Pedido = Convert.ToInt32(Constantes.pedidos_TA.getCodigoPedido(num_Pedido, fecha_dia));//Cod pedido introducido
                Constantes.factVenta_TA.Insert(cod_Pedido,fechaHora_dia);
                
                

                cod_Factura = Convert.ToInt32(Constantes.factVenta_TA.getCodigoFactura(cod_Pedido));
                foreach (DataGridViewRow row in cesta.Rows)
                {
                  
                        cantidad = Convert.ToSingle(row.Cells[Constantes.COLUMNA_UNIDADES].Value);
                        articulo = Convert.ToString(row.Cells[Constantes.COLUMNA_NOMBRE].Value);
                        precio = Convert.ToSingle(row.Cells[Constantes.COLUMNA_PRECIO].Value);
                  
                    Constantes.detaPedidosVenta_TA.Insert(cod_Factura, num_detalle, cantidad,precio, articulo);
                    num_detalle += 1;
                }
                DataTable compra = Constantes.detaPedidosVenta_TA.GetDetallePedido(cod_Factura);
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
        
        private void cargarListaVenta()
        {
            DirectoryInfo dir = new DirectoryInfo(Constantes.CATEGORIAS_RUTA);
            int j = 0;
            foreach (FileInfo file in dir.GetFiles())
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

        private void VentaTienda_Load(object sender, EventArgs e)
        {
            cargarListaVenta();
        }

        private void volverACategoria(object sender, EventArgs e)
        {
            btAtrasVTienda.Visible = false;
            listaCategoria = true;
            lFlecha.Visible = false;
            lCategoria.Text = "";

            DirectoryInfo dir = new DirectoryInfo(Constantes.CATEGORIAS_RUTA);
            int j = 0;
            this.listView1.Items.Clear();
            this.imageList1.Images.Clear();
            foreach (FileInfo file in dir.GetFiles())
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

        private void cambioPrecio(object sender, DataGridViewCellEventArgs e)
        {
           Total();
        }

        private void Seleccion(object sender, MouseEventArgs e)
        {
            introducidoCantidad = false;
            if (listaCategoria)
            {
                ListView.SelectedIndexCollection seleccionado = this.listView1.SelectedIndices;
                foreach (int index in seleccionado)
                {
                    DirectoryInfo dir = new DirectoryInfo(Constantes.PRODUCTOS_RUTA + "/" + this.listView1.Items[index].Text);
                    lCategoria.Text = this.listView1.Items[index].Text.ToString();
                    int j = 0;
                    this.listView1.Items.Clear();
                    this.imageList1.Images.Clear();
                    foreach (FileInfo file in dir.GetFiles())
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
                        lFlecha.Visible = true;
                        
                    }
                   
                }
                btAtrasVTienda.Visible = true;
                listaCategoria = false;
                
            }
            else
            {
                try
                {
                    

                    if (!introducidoCantidad)
                    {
                        Intro_Peso_UD panel1 = new Intro_Peso_UD();
                        panel1.MinimizeBox = false;
                        panel1.MaximizeBox = false;
                        panel1.ShowIcon = false;
                        panel1.ShowInTaskbar = false;
                        panel1.ShowDialog();
                        introducidoCantidad = true;
                    }
                    if (Constantes.PESO_UD_PRODUCTO != null && Convert.ToDouble(Constantes.PESO_UD_PRODUCTO) > 0 && Convert.ToDouble(Constantes.PESO_UD_PRODUCTO) > 0.000)
                    {
                        ListView.SelectedIndexCollection seleccionado = this.listView1.SelectedIndices;
                        foreach (int index in seleccionado)
                        {
                            cesta.Rows.Add(1);
                            cesta.Rows[cesta.RowCount - 1].Cells[0].Value = Resource1.bin;
                            cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_NOMBRE].Value = this.listView1.Items[index].Text;
                            cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_UNIDADES].Value = Constantes.PESO_UD_PRODUCTO;
                            if (lCategoria.Text.Equals("Suplementos"))
                            {
                                cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_PRECIO].Value = (float)Constantes.suplemento_TA.getPreSupleNombre(this.listView1.Items[index].Text);
                            }
                            else
                            {
                                cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_PRECIO].Value = (float)Constantes.preciosVenta_TA.GetPrecioVenta((int)Constantes.productos_TA.GetCodProducto(this.listView1.Items[index].Text));
                            }
                            cesta.FirstDisplayedScrollingRowIndex = cesta.RowCount - 1;
                            Total();
                        }
                        Constantes.PESO_UD_PRODUCTO = "0.000";
                    }
                }catch(Exception ex)
                {

                }
                finally
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        item.Selected = false;
                    }
                }
            }
        }

        private void descuentoExtra(object sender, EventArgs e)
        {
            DescuentoExtra panel1 = new DescuentoExtra();
            panel1.MinimizeBox = false;
            panel1.MaximizeBox = false;
            panel1.ShowIcon = false;
            panel1.ShowInTaskbar = false;
            panel1.ShowDialog();
            if (Constantes.PRECIO_ESTRELLA != null && Convert.ToDouble(Constantes.PRECIO_ESTRELLA) != 0)
            {
                String concepto = "";
                if(Convert.ToInt32(Constantes.PRECIO_ESTRELLA) < 0)
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
            Constantes.PRECIO_ESTRELLA = "0";
        }
    }    
}