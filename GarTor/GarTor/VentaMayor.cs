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
    public partial class VentaMayor : Form
    {
        private bool listaCategoria = true;
        private bool introducidoCantidad = false;
        public VentaMayor()
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
            DateTime fecha_dia = DateTime.Now.Date;
            DateTime fechaHora_dia = DateTime.Now;
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

            PdfPCell iva = new PdfPCell(new Phrase("IVA 21%:", _standardFont));
            iva.BorderWidth = 0;

            PdfPCell ivapre = new PdfPCell(new Phrase(Math.Round(((total_factura * 21) / 100), 2) + "€", _standardFont));
            ivapre.BorderWidth = 0;

            tblPrueba.AddCell(vacio2);
            tblPrueba.AddCell(vacio2);
            tblPrueba.AddCell(iva);
            tblPrueba.AddCell(ivapre);

            PdfPCell tota = new PdfPCell(new Phrase("TOTAL:", _standardFont));
            tota.BorderWidth = 0;

            PdfPCell totaliva = new PdfPCell(new Phrase(Math.Round(((total_factura * 21) / 100), 2) + total_factura + "€", _standardFont));
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

        private void VentaMayor_Load(object sender, EventArgs e)
        {
            cargarListaVenta();
            cbClientesMayor.DisplayMember = "Nombre_Cliente";
            cbClientesMayor.ValueMember = "Cod_Cliente";
            cbClientesMayor.DataSource = Constantes.clientesMayor_TA.GetData();
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
                                cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_PRECIO].Value = (float)Constantes.preciosMayor_TA.getPrecioMayor((int)Constantes.productos_TA.GetCodProducto(this.listView1.Items[index].Text));
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
    }
}