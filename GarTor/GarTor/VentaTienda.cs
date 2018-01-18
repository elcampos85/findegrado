using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    public partial class VentaTienda : Form
    {
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
            

            

        }

        private void Eliminar(object sender, DataGridViewCellEventArgs e)
        {
            if (cesta.CurrentCell.ColumnIndex == 0)
            {
                int num_fila = cesta.CurrentRow.Index;
                DialogResult result;
                MsgBoxUtil.HackMessageBox("Si", "No");
                result = MessageBox.Show("¿Desea eliminar este producto?", "Eliminar",  MessageBoxButtons.YesNo, MessageBoxIcon.Question );

                if (result == DialogResult.Yes)
                {
                    cesta.Rows.RemoveAt(cesta.CurrentRow.Index);
                }
                else if (result == DialogResult.No)
                {
                }
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cesta.Rows.Add(1);

            cesta.Rows[cesta.RowCount - 1].Cells[0].Value = Resource1.bin;
            cesta.Rows[cesta.RowCount - 1].Cells[1].Value = "tarta";
            cesta.Rows[cesta.RowCount - 1].Cells[2].Value = "88";
            cesta.Rows[cesta.RowCount - 1].Cells[3].Value = "10";

            cesta.FirstDisplayedScrollingRowIndex = cesta.RowCount-1;
        }
    }
}
