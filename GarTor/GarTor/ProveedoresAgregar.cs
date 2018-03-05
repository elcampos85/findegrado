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
    public partial class ProveedoresAgregar : Form
    {
        public ProveedoresAgregar()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if ((tbNombre.Text==null) && verificar(tbNombre.Text))
            {
                Constantes.proveedores_TA.Insert(tbNombre.Text);
                MessageBox.Show("Proveedor agregado correctamente");
            }
            else{
                MessageBox.Show("El proveedor ya existe");
            }
            
        }

        public bool verificar(string nombre)
        {
            if (Constantes.proveedores_TA.Verificacion(nombre) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
