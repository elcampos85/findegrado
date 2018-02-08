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
    public partial class VentaTienda : Form
    {
        private bool listaCategoria = true;
        private bool introducidoCantidad = false;
        DSProductosTableAdapters.ProductosTableAdapter prodTA = new DSProductosTableAdapters.ProductosTableAdapter();
        DSProductosTableAdapters.PreciosVentaTableAdapter ventTA = new DSProductosTableAdapters.PreciosVentaTableAdapter();
        public VentaTienda()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                cesta.Rows.Add(1);
                cesta.Rows[i].Cells[0].Value = Resource1.bin;
                cesta.Rows[i].Cells[1].Value = "tarta";
                cesta.Rows[i].Cells[2].Value = i;
                cesta.Rows[i].Cells[3].Value = "10";
                cesta.FirstDisplayedScrollingRowIndex = cesta.RowCount - 1;
            }
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
            foreach (DataGridViewRow row in cesta.Rows)
            {
                MessageBox.Show(row.Cells[Constantes.COLUMNA_PRECIO].Value.ToString());
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
                    MessageBox.Show("El campo debe contener algun numero");
                }
                }
            lPrecio.Text = "Total: " + Math.Round(suma, 2).ToString() + " €";
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
        
        private void VentaTienda_Load(object sender, EventArgs e)
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
                if (!introducidoCantidad)
                {
                    Intro_Peso_UD panel1 = new Intro_Peso_UD();
                    panel1.ControlBox = false;
                    panel1.ShowIcon = false;
                    panel1.ShowInTaskbar = false;
                    panel1.ShowDialog();
                    introducidoCantidad = true;
                }
                ListView.SelectedIndexCollection seleccionado = this.listView1.SelectedIndices;
                foreach (int index in seleccionado)
                {
                    cesta.Rows.Add(1);
                    cesta.Rows[cesta.RowCount - 1].Cells[0].Value = Resource1.bin;
                    cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_NOMBRE].Value = this.listView1.Items[index].Text;
                    cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_UNIDADES].Value = Constantes.PESO_UD_PRODUCTO;
                    cesta.Rows[cesta.RowCount - 1].Cells[Constantes.COLUMNA_PRECIO].Value = (float)ventTA.GetPrecioVenta((int)prodTA.GetCodProducto(this.listView1.Items[index].Text));
                    cesta.FirstDisplayedScrollingRowIndex = cesta.RowCount - 1;
                    Total();
                }
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    item.Selected = false;
                }
            }
        }
    }    
}