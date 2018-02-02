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
            cesta.Rows.Add(1);

            cesta.Rows[cesta.RowCount - 1].Cells[0].Value = Resource1.bin;
            cesta.Rows[cesta.RowCount - 1].Cells[1].Value = "tarta";
            cesta.Rows[cesta.RowCount - 1].Cells[2].Value = "88";
            cesta.Rows[cesta.RowCount - 1].Cells[3].Value = "10";

            cesta.FirstDisplayedScrollingRowIndex = cesta.RowCount - 1;

            Total();


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

        private void PasarPagProductos(object sender, EventArgs e)
        {
            btAtrasVTienda.Visible = true;
            btAdelanteVTienda.Visible = false;
        }

        private void RetroPagProductos(object sender, EventArgs e)
        {
            btAtrasVTienda.Visible = false;
            btAdelanteVTienda.Visible = true;
        }

        private void BusquedaProducto(object sender, EventArgs e)
        {

        }

        private void VentaTienda_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo("L:/DAM/2/Proyecto Fin de Curso/Fotos Pasteleria");

            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    this.imageList1.Images.Add(Image.FromFile(file.FullName));
                }
                catch
                {
                    Console.WriteLine("No es un archivo de imagen");
                }

                this.listView1.View = View.LargeIcon;

                this.imageList1.ImageSize = new Size(100, 100);

                this.listView1.LargeImageList = this.imageList1;

                for (int j = 0; j < this.imageList1.Images.Count; j++)
                {
                    ListViewItem item = new ListViewItem();

                    item.ImageIndex = j;

                    this.listView1.Items.Add(item);
                    Console.WriteLine(j);
                }
            }
        }
    }
}
