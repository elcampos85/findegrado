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
    public partial class AñadirIngrediente : Form { 
    
        private DSIngredientesTableAdapters.ProveedoresTableAdapter provTA = new DSIngredientesTableAdapters.ProveedoresTableAdapter();
        private DSIngredientesTableAdapters.IngredientesTableAdapter ingreTA = new DSIngredientesTableAdapters.IngredientesTableAdapter();
        private DSIngredientesTableAdapters.PrecioIngredientesTableAdapter preTA = new DSIngredientesTableAdapters.PrecioIngredientesTableAdapter();

        public AñadirIngrediente()
        {
            InitializeComponent();

            cbMedidas.SelectedIndex = 0;

            cbProveedores.DisplayMember = "Nombre_Proveedor";
            cbProveedores.ValueMember = "Cod_Proveedor";

            cbProveedores.DataSource = provTA.GetData();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            float precio;
            precio = (float)(Math.Round((double)Convert.ToSingle(units.Value))) / (float)(Math.Round((double)Convert.ToSingle(cantidad.Value)));
            switch (cbMedidas.SelectedIndex)
            {
                case 2://g
                    precio = (float)(Math.Round((double)Convert.ToSingle(units.Value))) / (float)(Math.Round((double)Convert.ToSingle(cantidad.Value))) * 1000.00f;
                    break;
                case 3://mg
                    precio = (float)(Math.Round((double)Convert.ToSingle(units.Value))) / (float)(Math.Round((double)Convert.ToSingle(cantidad.Value))) * 1000000.00f;
                    break;
                case 5://cL
                    precio = (float)(Math.Round((double)Convert.ToSingle(units.Value))) / (float)(Math.Round((double)Convert.ToSingle(cantidad.Value))) * 100.00f;
                    break;
                case 6://mL
                    precio = (float)(Math.Round((double)Convert.ToSingle(units.Value))) / (float)(Math.Round((double)Convert.ToSingle(cantidad.Value))) * 1000.00f;
                    break;

            }

            ingreTA.Insert(tbNombre.Text.ToString());
            ingreTA.GetCodIngrediente(tbNombre.Text);
            preTA.Insert((Convert.ToInt32(cbProveedores.SelectedValue.ToString())),(Convert.ToInt32(ingreTA.GetCodIngrediente(tbNombre.Text.ToString()))),precio);



            MessageBox.Show("Ingrediente "+tbNombre.Text+" Cod Ingre: "+ ingreTA.GetCodIngrediente(tbNombre.Text.ToString()) + " "+Convert.ToString(precio)+" € el kg/L/unidad "+ cbMedidas.SelectedItem+"    Cod "+ cbProveedores.SelectedValue.ToString());
        }
    }
}
