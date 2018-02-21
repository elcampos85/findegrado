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
        private Image modeloFactura = Properties.Resources.modeloFactura;
        private bool listaCategoria = true;
        private bool introducidoCantidad = false;
        public VentaMayor()
        {
            InitializeComponent();
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
                string factura = @"C:\GarTor\Facturas\VentasMayor\Factura" + DateTime.Now.ToString("dd-MM-yyyy_H.mm.ss") + ".txt";
                string texto = null;

                System.IO.StreamWriter sw = new System.IO.StreamWriter(factura);
                texto = "FACTURA SIMPLIFICADA";
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
                    this.imageList1.Images.Add(Image.FromFile(file.FullName));

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
                    this.imageList1.Images.Add(Image.FromFile(file.FullName));

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
                            this.imageList1.Images.Add(Image.FromFile(file.FullName));

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
                            cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_PRECIO].Value = (float)Constantes.preciosMayor_TA.getPrecioMayor((int)Constantes.productos_TA.GetCodProducto(this.listView1.Items[index].Text));
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