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
        private System.Drawing.Image modeloFactura = Properties.Resources.modeloFactura;
        private bool listaCategoria = true;
        private bool introducidoCantidad = false;
        public VentaTienda()
        {
            InitializeComponent();
            Total();
            facturaPDF();
        }
        #region FACTURA PDF
        private void facturaPDF()
        {
            /*
                using System.IO;
               using iTextSharp.text;
               using iTextSharp.text.pdf;
            */
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Constantes.FACTURAS_RUTA + "/VentasTienda/factura" + DateTime.Now.ToString("dd-MM-yyyy_H.mm.ss") + ".pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Factura 001");
            doc.AddCreator("GarTor");

            // Abrimos el archivo
            doc.Open();
            
            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //Añadimos una imagen
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Constantes.CATEGORIAS_RUTA+"/Suplementos.png");
            logo.ScaleAbsoluteWidth(100);
            logo.ScaleAbsoluteHeight(100);
            
            doc.Add(logo);
            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Factura 001"));
            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(3);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell detalle = new PdfPCell(new Phrase("Detalle", _standardFont));
            detalle.BorderWidth = 0;
            detalle.BorderWidthBottom = 0.75f;

            PdfPCell nombre = new PdfPCell(new Phrase("Nombre Producto", _standardFont));
            nombre.BorderWidth = 0;
            nombre.BorderWidthBottom = 0.75f;

            PdfPCell cantidad = new PdfPCell(new Phrase("Cantidad", _standardFont));
            cantidad.BorderWidth = 0;
            cantidad.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(detalle);
            tblPrueba.AddCell(nombre);
            tblPrueba.AddCell(cantidad);

            // Llenamos la tabla con información
            detalle = new PdfPCell(new Phrase("1", _standardFont));
            detalle.BorderWidth = 0;

            nombre = new PdfPCell(new Phrase("Tortel", _standardFont));
            nombre.BorderWidth = 0;

            cantidad = new PdfPCell(new Phrase("10", _standardFont));
            cantidad.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(detalle);
            tblPrueba.AddCell(nombre);
            tblPrueba.AddCell(cantidad);

            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

        }
        #endregion

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
                string format = "%-40s%s%n";//Formato de la factura con columnas
                DateTime fecha_dia = DateTime.Now.Date;
                DateTime fechaHora_dia = DateTime.Now;
                int num_Pedido = Convert.ToInt32(Constantes.pedidos_TA.getPedidosDia(fecha_dia));
                int cod_Pedido = 0;
                int num_detalle = 1;
                int cod_Factura=0;
                float cantidad = 0;
                int cod_Precio = 0;
                int cod_Prod = 0;

                Constantes.pedidos_TA.Insert(num_Pedido, fecha_dia);
                cod_Pedido = Convert.ToInt32(Constantes.pedidos_TA.getCodigoPedido(num_Pedido, fecha_dia));//Cod pedido introducido
                Constantes.factVenta_TA.Insert(cod_Pedido,fechaHora_dia);
                
                

                cod_Factura = Convert.ToInt32(Constantes.factVenta_TA.getCodigoFactura(cod_Pedido));
                foreach (DataGridViewRow row in cesta.Rows)
                {
                    cantidad = Convert.ToSingle(row.Cells[Constantes.COLUMNA_UNIDADES].Value);
                    cod_Prod = Convert.ToInt32(Constantes.productos_TA.GetCodProducto(Convert.ToString(row.Cells[Constantes.COLUMNA_NOMBRE].Value)));
                    cod_Precio = Convert.ToInt32(Constantes.preciosVenta_TA.getCodPrecioVenta(cod_Prod));
                    Constantes.detaPedidosVenta_TA.Insert(cod_Factura,num_detalle,cantidad,cod_Precio,cod_Prod); 
                    num_detalle += 1;
                }
                DataTable compra = Constantes.detaPedidosVenta_TA.GetDetalleDeFactura(cod_Factura);
                String CadenaCompra = "";

                foreach (DataRow row in compra.Rows)
                {
                    float total = 0.00f;
                    string nom_Producto = Constantes.productos_TA.GetNombreProducto(Convert.ToInt32(row["Cod_Producto"]));
                    int unidades = Convert.ToInt32(row["Cantidad"]);
                    float precio = Convert.ToSingle(Constantes.preciosVenta_TA.GetPrecioVenta(Convert.ToInt32( row["Cod_Precios_Venta"])));
                    
                    total = precio * (Convert.ToSingle(unidades));


                    CadenaCompra += row["Num_Detalle"] + " | " +nom_Producto +" | "+ unidades + " | "+ precio+" | "+total+"\r\n";

                }
                //
                //
                //NO FUNCIONAN LOS DESCUENTOS ROMPEN LA APLICACION
                //
                //
                //
                StreamWriter sw = new StreamWriter(factura);
                texto = "FACTURA SIMPLIFICADA" +
                    "\r\nPasteleria MARCO" +
                    "\r\nPaseo de los Jesuitas 18, Madrid" +
                    "\r\nTelf. 91 463 99 82" +
                    "\r\nN.I.F. 07487245D" +
                    "\r\n" + "Detalle" + " | "+"Nombre Articulo"+" | "+"Unidades"+" | "+"Precio"+" | "+"Total"+
                    "\r\n" + CadenaCompra +
                    
                    "\r\n" + "Factura: "+Constantes.factVenta_TA.getCodigoFactura(cod_Pedido).ToString();
                sw.WriteLine(texto);
                sw.Close();
                #endregion

                this.listView1.Items.Clear();
                this.imageList1.Images.Clear();
                btAtrasVTienda.Visible = false;
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
                            if (this.listView1.Items[index].Text.Equals("Suplementos"))
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
            if (Constantes.PRECIO_ESTRELLA != null && Convert.ToDouble(Constantes.PRECIO_ESTRELLA) != 0 && (!Constantes.CONCEPTO_ESTRELLA.Equals("")))
            {
                cesta.Rows.Add(1);
                cesta.Rows[cesta.RowCount - 1].Cells[0].Value = Resource1.bin;
                cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_NOMBRE].Value = Constantes.CONCEPTO_ESTRELLA;
                cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_UNIDADES].Value = "1";
                cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_PRECIO].Value = Convert.ToDouble(Constantes.PRECIO_ESTRELLA);
                cesta.FirstDisplayedScrollingRowIndex = cesta.RowCount - 1;
                Total();
            }

            Constantes.CONCEPTO_ESTRELLA = "";
            Constantes.PRECIO_ESTRELLA = "0";
        }
    }    
}