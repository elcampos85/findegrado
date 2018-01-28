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
        private const int COLUMNA_PRECIO = 3;
        private DSIngredientesTableAdapters.IngredientesTableAdapter ingreTA = new DSIngredientesTableAdapters.IngredientesTableAdapter();
        private DSIngredientesTableAdapters.PrecioIngredientesTableAdapter precioTA = new DSIngredientesTableAdapters.PrecioIngredientesTableAdapter();
        public Produccion()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float precio; 

            lista.Rows.Add(1);

            lista.Rows[lista.RowCount - 1].Cells[0].Value = Resource1.bin;
            lista.Rows[lista.RowCount - 1].Cells[1].Value = cbIngredientes.SelectedValue.ToString();
            lista.Rows[lista.RowCount - 1].Cells[2].Value = units.Value + " " + cbMedidas.SelectedItem;
            precio = (float)(Math.Round((double)Convert.ToSingle(units.Value) * Convert.ToSingle(precioTA.PrecioIngrediente(cbIngredientes.SelectedValue.ToString())), 2));
            switch (cbMedidas.SelectedIndex)
            {
                case 2://g
                    precio = precio / 1000;
                    break;
                case 3://mg
                    precio = precio / 1000000;
                    break;
                case 5://cL
                    precio = precio / 100;
                    break;
                case 6://mL
                    precio = precio / 1000;
                    break;

            }
            //(float)(Math.Round((double)float, 2);
            lista.Rows[lista.RowCount - 1].Cells[3].Value = precio;

            lista.FirstDisplayedScrollingRowIndex = lista.RowCount - 1;



            Total();
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
                    Total();
                }
            }
        }
        private void Total()
        {
            float suma = 0;
            foreach (DataGridViewRow row in lista.Rows)
            {
                suma += Convert.ToSingle(row.Cells[COLUMNA_PRECIO].Value.ToString());
            }

            lPrecio.Text = suma.ToString("#,##0.##")+" €";
        }

        private void OnLoad(object sender, EventArgs e)
        {
            cbIngredientes.DisplayMember = "Nombre_Ingrediente";
            cbIngredientes.ValueMember = "Nombre_Ingrediente";

            cbIngredientes.DataSource = ingreTA.ComboboxIngredientes();

            cbMedidas.SelectedIndex = 0;
            Total();
        }
    }
}
