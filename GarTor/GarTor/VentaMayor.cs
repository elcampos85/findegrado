using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    /// <summary>
    /// Formulario para la venta al por mayor
    /// </summary>
    public partial class VentaMayor : Form
    {

        private bool listaCategoria = true;//Boolean para saber si estamos en la lista de categorias en el menu de imagenes
        private bool introducidoCantidad = false;//Boolean para saber si hemos introducido la cantidad o el peso o si hemos cerrado solo la ventana sin introducirlo
        private string ivacb = "";

        /// <summary>
        /// Contructor de VentaMayor
        /// </summary>
        public VentaMayor()
        {
            InitializeComponent();
            lFlecha.Visible = false;
            Total();
        }
        /// <summary>
        /// Evento onClick para eliminar productos de la cesta de la compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Metodo para generarla factura en pdf
        /// </summary>
        #region FACTURA PDF
        private void facturaPDF()
        {
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Constantes.FACTURAS_VM + "/factura" + DateTime.Now.ToString("dd-MM-yyyy_H.mm.ss") + ".pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Factura");
            doc.AddCreator("Pasteleria Marco");

            // Abrimos el archivo
            doc.Open();

            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //Añadimos una imagen
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Constantes.MAIN_RUTA + "/Logo.PNG");
            logo.ScaleAbsoluteWidth(100);
            logo.ScaleAbsoluteHeight(100);
            logo.BorderWidth = 0;

            PdfPCell texto = new PdfPCell(new Phrase("Pasteleria Marco" + "\r\nPaseo de los Jesuitas 18, Madrid" + "\r\nTelf. 91 463 99 82" + "\r\nN.I.F. 07487245D"));
            texto.BorderWidth = 0;

            PdfPTable tblEncab = new PdfPTable(2);
            tblEncab.WidthPercentage = 100;

            tblEncab.AddCell(logo);
            tblEncab.AddCell(texto);

            doc.Add(tblEncab);

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Factura Nº: " + (Constantes.facturasMayor_TA.GetUltimaFactura() + 1)));
            doc.Add(new Paragraph("Fecha: " + System.DateTime.Now.ToString("dd - MM - yyyy")));
            doc.Add(new Paragraph("Cliente: " + Constantes.clientesMayor_TA.GetNomClienteMayor(Convert.ToInt32(cbClientesMayor.SelectedValue))));
            doc.Add(new Paragraph("CIF/NIF: " + Constantes.clientesMayor_TA.GetCifClienteMayor(Convert.ToInt32(cbClientesMayor.SelectedValue))));
            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla 
            PdfPTable tblPrueba = new PdfPTable(4);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla

            PdfPCell nombre = new PdfPCell(new Phrase("Nombre Producto", _standardFont));
            nombre.BorderWidth = 0;
            nombre.BorderWidthBottom = 0.75f;

            PdfPCell cantidad = new PdfPCell(new Phrase("Cantidad", _standardFont));
            cantidad.BorderWidth = 0;
            cantidad.BorderWidthBottom = 0.75f;

            PdfPCell precio = new PdfPCell(new Phrase("Precio", _standardFont));
            precio.BorderWidth = 0;
            precio.BorderWidthBottom = 0.75f;

            PdfPCell total = new PdfPCell(new Phrase("Total", _standardFont));
            total.BorderWidth = 0;
            total.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(nombre);
            tblPrueba.AddCell(cantidad);
            tblPrueba.AddCell(precio);
            tblPrueba.AddCell(total);

            //Guardamos en la base de datos la factura
            string fecha_dia = DateTime.Now.ToShortDateString();
            string fechaHora_dia = DateTime.Now.ToString();
            int num_Pedido = Convert.ToInt32(Constantes.pedidosMayor_TA.getPedidosDia(fecha_dia));
            int cod_Pedido = 0;
            int num_detalle = 1;
            int cod_Factura = 0;
            float cant = 0;
            float pre = 0.00f;
            string articulo = "";

            Constantes.pedidosMayor_TA.Insert(fecha_dia, num_Pedido, Convert.ToInt32(cbClientesMayor.SelectedValue));
            cod_Pedido = Convert.ToInt32(Constantes.pedidosMayor_TA.getCodigoPedido(num_Pedido, fecha_dia));//Cod pedido introducido
            Constantes.facturasMayor_TA.Insert(cod_Pedido, fechaHora_dia);



            cod_Factura = Convert.ToInt32(Constantes.facturasMayor_TA.getCodigoFactura(cod_Pedido));
            foreach (DataGridViewRow row in cesta.Rows)
            {

                cant = Convert.ToSingle(row.Cells[Constantes.COLUMNA_UNIDADES].Value);
                articulo = Convert.ToString(row.Cells[Constantes.COLUMNA_NOMBRE].Value);
                pre = Convert.ToSingle(row.Cells[Constantes.COLUMNA_PRECIO].Value);

                Constantes.detalleFacMayor_TA.Insert(cod_Factura, num_detalle, cant, pre, articulo);
                num_detalle += 1;
            }
            DataTable compra = Constantes.detalleFacMayor_TA.GetDetallePedido(cod_Factura);
            float total_factura = 0.00f;

            // Llenamos la tabla con información
            foreach (DataRow row in compra.Rows)
            {
                float tot = 0.00f;

                string nom_Producto = Convert.ToString(row["Articulo"]);

                int unidades = Convert.ToInt32(row["Cantidad"]);
                float precio_detalle = Convert.ToSingle(row["Precio"]);

                tot = precio_detalle * (Convert.ToSingle(unidades));

                nombre = new PdfPCell(new Phrase(nom_Producto, _standardFont));
                nombre.BorderWidth = 0;

                cantidad = new PdfPCell(new Phrase(unidades.ToString(), _standardFont));
                cantidad.BorderWidth = 0;

                precio = new PdfPCell(new Phrase(Math.Round(precio_detalle,2).ToString() + "€", _standardFont));
                precio.BorderWidth = 0;

                total = new PdfPCell(new Phrase(Math.Round(tot,2).ToString() + "€", _standardFont));
                total.BorderWidth = 0;

                total_factura += tot;

                // Añadimos las celdas a la tabla
                tblPrueba.AddCell(nombre);
                tblPrueba.AddCell(cantidad);
                tblPrueba.AddCell(precio);
                tblPrueba.AddCell(total);

            }
            PdfPCell vacio = new PdfPCell(new Phrase("", _standardFont));
            vacio.BorderWidth = 0;
            vacio.BorderWidthTop = 0.75f;

            PdfPCell subtotal = new PdfPCell(new Phrase("SUBTOTAL:", _standardFont));
            subtotal.BorderWidth = 0;
            subtotal.BorderWidthTop = 0.75f;

            PdfPCell subtota = new PdfPCell(new Phrase(total_factura + "€", _standardFont));
            subtota.BorderWidth = 0;
            subtota.BorderWidthTop = 0.75f;

            tblPrueba.AddCell(vacio);
            tblPrueba.AddCell(vacio);
            tblPrueba.AddCell(subtotal);
            tblPrueba.AddCell(subtota);

            PdfPCell vacio2 = new PdfPCell(new Phrase("", _standardFont));
            vacio2.BorderWidth = 0;

            PdfPCell iva = new PdfPCell(new Phrase("IVA " + ivacb + "%", _standardFont));
            iva.BorderWidth = 0;

            PdfPCell ivapre = new PdfPCell(new Phrase(Math.Round(((total_factura * Convert.ToInt32(ivacb)) / 100), 2) + "€", _standardFont));
            ivapre.BorderWidth = 0;

            tblPrueba.AddCell(vacio2);
            tblPrueba.AddCell(vacio2);
            tblPrueba.AddCell(iva);
            tblPrueba.AddCell(ivapre);

            PdfPCell tota = new PdfPCell(new Phrase("TOTAL:", _standardFont));
            tota.BorderWidth = 0;

            PdfPCell totaliva = new PdfPCell(new Phrase(Math.Round(((total_factura * Convert.ToInt32(ivacb)) / 100) + total_factura, 2) + "€", _standardFont));
            totaliva.BorderWidth = 0;

            tblPrueba.AddCell(vacio2);
            tblPrueba.AddCell(vacio2);
            tblPrueba.AddCell(tota);
            tblPrueba.AddCell(totaliva);

            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

        }
        #endregion
        /// <summary>
        /// Evento onClick para finalizar la compra
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
                facturaPDF();

                float importeIVA = ((Convert.ToSingle(Constantes.IMPORTE) * Convert.ToInt32(ivacb)) / 100) + Convert.ToSingle(Constantes.IMPORTE);

                if (Constantes.contabilidad_TA.getRegistros(DateTime.Today.ToShortDateString()) == 0)
                {
                    Constantes.contabilidad_TA.Insert(DateTime.Now.ToShortDateString(), 0, Math.Round(importeIVA, 2));
                }
                else
                {
                    int id = Convert.ToInt32(Constantes.contabilidad_TA.GetId(DateTime.Now.ToShortDateString()));
                    float ingresos = Convert.ToSingle(Constantes.contabilidad_TA.getIngresos(DateTime.Now.ToShortDateString()));

                    Constantes.contabilidad_TA.UpdateIngresos(Convert.ToDouble(ingresos + Math.Round(importeIVA, 2)), id);
                }
                listView1.Items.Clear();
                imageList1.Images.Clear();
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
        /// Metodo que calcula el total del precio de los productos
        /// </summary>
        private void Total()
        {
            float suma = 0;
            foreach (DataGridViewRow row in cesta.Rows)
            {
                try
                {
                    suma += (float)Convert.ToSingle(row.Cells[Constantes.COLUMNA_UNIDADES].Value) * (float)Convert.ToSingle(row.Cells[Constantes.COLUMNA_PRECIO].Value);
                    suma = ((Convert.ToSingle(suma) * Convert.ToInt32(ivacb)) / 100) + Convert.ToSingle(suma);
                }
                catch (Exception e)
                {

                }
            }
            lPrecio.Text = "Total: " + Math.Round(suma, 2).ToString() + " €";
            Constantes.IMPORTE = Math.Round(suma, 2).ToString();
        }
        /// <summary>
        /// Método onClick para eliminar la cesta de la compra completa
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
            int j = 0;
            foreach (FileInfo file in dir.GetFiles())
            {
                listView1.View = View.LargeIcon;

                imageList1.ImageSize = new Size(Constantes.TAMANO_IMAGENES, Constantes.TAMANO_IMAGENES);

                try
                {
                    imageList1.Images.Add(System.Drawing.Image.FromFile(file.FullName));

                    listView1.Items.Add(new ListViewItem { ImageIndex = j, Text = file.Name.Substring(0, file.Name.Length - 4) });
                    j++;
                }
                catch
                {
                    Console.WriteLine("No es un archivo de imagen");
                }
                listView1.LargeImageList = imageList1;
            }
        }
        /// <summary>
        /// Metodo que se ejecuta al cargarse la VentaTienda y que cargamos la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VentaMayor_Load(object sender, EventArgs e)
        {
            cargarListaVenta();
            cbClientesMayor.DisplayMember = "Nombre_Cliente";
            cbClientesMayor.ValueMember = "Cod_Cliente";
            cbClientesMayor.DataSource = Constantes.clientesMayor_TA.GetData();
            cbIVA.SelectedIndex = 0;
        }
        /// <summary>
        /// Metodo que vuelve a cargar la lista de categorias si nos encontramos en una categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volverACategoria(object sender, EventArgs e)
        {
            btAtrasVTienda.Visible = false;
            listaCategoria = true;
            lFlecha.Visible = false;
            lCategoria.Text = "";

            DirectoryInfo dir = new DirectoryInfo(Constantes.CATEGORIAS_RUTA);
            int j = 0;
            listView1.Items.Clear();
            imageList1.Images.Clear();
            foreach (FileInfo file in dir.GetFiles())
            {
                listView1.View = View.LargeIcon;

                imageList1.ImageSize = new Size(Constantes.TAMANO_IMAGENES, Constantes.TAMANO_IMAGENES);

                try
                {
                    imageList1.Images.Add(System.Drawing.Image.FromFile(file.FullName));

                    listView1.Items.Add(new ListViewItem { ImageIndex = j, Text = file.Name.Substring(0, file.Name.Length - 4) });
                    j++;
                }
                catch
                {
                    Console.WriteLine("No es un archivo de imagen");
                }
                listView1.LargeImageList = imageList1;
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
            introducidoCantidad = false;
            if (listaCategoria)
            {
                ListView.SelectedIndexCollection seleccionado = listView1.SelectedIndices;
                foreach (int index in seleccionado)
                {
                    DirectoryInfo dir = new DirectoryInfo(Constantes.PRODUCTOS_RUTA + "/" + listView1.Items[index].Text);
                    lCategoria.Text = listView1.Items[index].Text.ToString();
                    int j = 0;
                    listView1.Items.Clear();
                    imageList1.Images.Clear();
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        listView1.View = View.LargeIcon;

                        imageList1.ImageSize = new Size(Constantes.TAMANO_IMAGENES, Constantes.TAMANO_IMAGENES);

                        try
                        {
                            imageList1.Images.Add(System.Drawing.Image.FromFile(file.FullName));

                            listView1.Items.Add(new ListViewItem { ImageIndex = j, Text = file.Name.Substring(0, file.Name.Length - 4) });
                            j++;
                        }
                        catch
                        {
                            Console.WriteLine("No es un archivo de imagen");
                        }
                        listView1.LargeImageList = imageList1;
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
                        ListView.SelectedIndexCollection seleccionado = listView1.SelectedIndices;
                        foreach (int index in seleccionado)
                        {
                            cesta.Rows.Add(1);
                            cesta.Rows[cesta.RowCount - 1].Cells[0].Value = Resource1.bin;
                            cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_NOMBRE].Value = listView1.Items[index].Text;
                            cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_UNIDADES].Value = Constantes.PESO_UD_PRODUCTO;
                            if (lCategoria.Text.Equals("Suplementos"))
                            {
                                cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_PRECIO].Value = (float)Constantes.suplemento_TA.getPreSupleNombre(listView1.Items[index].Text);
                            }
                            else
                            {
                                cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_PRECIO].Value = (float)Constantes.preciosMayor_TA.getPrecioMayor((int)Constantes.productos_TA.GetCodProducto(listView1.Items[index].Text));
                            }
                            cesta.FirstDisplayedScrollingRowIndex = cesta.RowCount - 1;
                            Total();
                        }
                        Constantes.PESO_UD_PRODUCTO = "0.000";
                    }
                }
                catch (Exception ex)
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
        /// <summary>
        /// Metodo que abre la ventana de descuentos o extras a introducir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (Convert.ToInt32(Constantes.PRECIO_ESTRELLA) < 0)
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
        /// <summary>
        /// Método para calcular el iva que se va a aplicar dependiendo de la seleccion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ivaSeleccionado(object sender, EventArgs e)
        {
            ivacb =  cbIVA.SelectedItem.ToString();
            Total();
        }
    }
}