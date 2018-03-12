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
    /// Clase para agregar clientes Mayor a la BBDD
    /// </summary>
    public partial class ClienteMayorAgregar : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public ClienteMayorAgregar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que verifica si el nuevo nombre a introducir existe en la BBDD
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>True si no existe y False si existe</returns>
        public bool verificar(string nombre)
        {
            if (Constantes.clientesMayor_TA.Verificacion(nombre) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Metodo que agrega un cliente Mayor a la BBDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = tbNombre.Text;
                string nif = tbCif.Text;
                if (verificar(nombre))
                {
                    Constantes.clientesMayor_TA.Insert(nombre, nif);
                    MessageBox.Show("Cliente agregado correctamente");
                }
                else
                {
                    MessageBox.Show("El cliente ya existe");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo un error al agregar");
            }
        }
    }
}