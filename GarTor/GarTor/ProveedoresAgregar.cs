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
    /// <summary>
    /// Formulario para agregar proveedores
    /// </summary>
    public partial class ProveedoresAgregar : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public ProveedoresAgregar()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo para agregar el nuevo proveedor a la BBDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Verifica si el nuevo nombre a introducir existe en la BBDD
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>True si no existe, False si existe</returns>
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
