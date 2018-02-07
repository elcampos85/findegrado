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
        private const int COLUMNA_PRECIO = 3;
        private bool listaCategoria = true;
        public VentaTienda()
        {

            InitializeComponent();
            for (int i = 0; i < 50; i++)
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
            


        }

        private void Total()
        {
            float suma = 0;
            foreach (DataGridViewRow row in cesta.Rows)
            {
                suma += Convert.ToSingle(row.Cells[COLUMNA_PRECIO].Value.ToString());
            }

            lPrecio.Text = "Total: " + suma.ToString() + " €";
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

                this.imageList1.ImageSize = new Size(150, 150);

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
        private void Seleccion(object sender, EventArgs e)
        {
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

                        this.imageList1.ImageSize = new Size(150, 150);

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
                ListView.SelectedIndexCollection seleccionado = this.listView1.SelectedIndices;
                foreach (int index in seleccionado)
                {
                    cesta.Rows.Add(1);

                    cesta.Rows[cesta.RowCount - 1].Cells[0].Value = Resource1.bin;
                    cesta.Rows[cesta.RowCount - 1].Cells[1].Value = this.listView1.Items[index].Text;
                    cesta.Rows[cesta.RowCount - 1].Cells[2].Value = "1";
                    cesta.Rows[cesta.RowCount - 1].Cells[3].Value = this.listView1.Items[index].Text;

                    cesta.FirstDisplayedScrollingRowIndex = cesta.RowCount - 1;

                    Total();
                }
            }
        }

        private void volverACategoria(object sender, EventArgs e)
        {
            btAtrasVTienda.Visible = false;
            listaCategoria = true;

            DirectoryInfo dir = new DirectoryInfo(Constantes.CATEGORIAS_RUTA);
            int j = 0;
            foreach (FileInfo file in dir.GetFiles())
            {
                this.listView1.View = View.LargeIcon;

                this.imageList1.ImageSize = new Size(150, 150);

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
    }    
}