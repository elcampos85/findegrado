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
    public partial class Produccion : Form
    {
        public Produccion()
        {
            InitializeComponent();
            DSIngredientesTableAdapters.IngredientesTableAdapter ingreTA = new DSIngredientesTableAdapters.IngredientesTableAdapter();
            
            cbIngredientes.DisplayMember = "Nombre_Ingrediente";
            cbIngredientes.ValueMember = "Nombre_Ingrediente";

            cbIngredientes.DataSource = ingreTA.ComboboxIngredientes();

            cbMedidas.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Rows.Add(1);

            lista.Rows[lista.RowCount - 1].Cells[0].Value = Resource1.bin;
            lista.Rows[lista.RowCount - 1].Cells[1].Value = cbIngredientes.SelectedValue.ToString();
            lista.Rows[lista.RowCount - 1].Cells[2].Value = units.Value+" "+ cbMedidas.SelectedItem;
            lista.Rows[lista.RowCount - 1].Cells[3].Value = "3€";

            lista.FirstDisplayedScrollingRowIndex = lista.RowCount - 1;
        }

        private void Eliminar(object sender, DataGridViewCellEventArgs e)
        {
            if (lista.CurrentCell.ColumnIndex == 0)
            {
                int num_fila = lista.CurrentRow.Index;
                DialogResult result;
                MsgBoxUtil.HackMessageBox("Si", "No");
                result = MessageBox.Show("¿Desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lista.Rows.RemoveAt(lista.CurrentRow.Index);
                }
                else if (result == DialogResult.No)
                {
                }
            }
        }
    }
}
