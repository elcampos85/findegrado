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
    public partial class ClienteMayorAgregar : Form
    {

        /// <summary>
        /// Clase para agregar clientes al por mayor en la BBDD
        /// </summary>
        public ClienteMayorAgregar()
        {
            InitializeComponent();
        }

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
