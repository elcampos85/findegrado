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

        public AñadirIngrediente()
        {
            InitializeComponent();

            cbProveedores.DisplayMember = "Nombre_Proveedor";
            cbProveedores.ValueMember = "Nombre_Proveedor";

            cbProveedores.DataSource = provTA.GetData();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            float precio;
            precio = (float)(Math.Round((double)Convert.ToSingle(units.Value))) / (float)(Math.Round((double)Convert.ToSingle(cantidad.Value)));
            switch (cbMedidas.SelectedIndex)
            {
                case 2://g
                    precio = precio * 1000;
                    break;
                case 3://mg
                    precio = precio * 1000000;
                    break;
                case 5://cL
                    precio = precio * 100;
                    break;
                case 6://mL
                    precio = precio * 1000;
                    break;

            }

            MessageBox.Show(Convert.ToString(precio)+" € el kg/L/unidad "+ cbMedidas.SelectedItem);
        }
    }
}
