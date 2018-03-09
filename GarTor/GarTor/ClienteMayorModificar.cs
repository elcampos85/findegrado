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
    /// Clase que modifica los clientes Mayor de la BBDD
    /// </summary>
    public partial class ClienteMayorModificar : Form
    {
        public ClienteMayorModificar()
        {
            InitializeComponent();
            rellenar();
        }

        /// <summary>
        /// Metodo que verifica que no haya un cliente en la BBDD con el nombre pasado por parametro
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
        /// Metodo que rellena los datos del cbClientes
        /// </summary>
        private void rellenar()
        {
            cbClientes.DisplayMember = "Nombre_Cliente";//Mostramos el Nombre del cliente en el cbClientes
            cbClientes.ValueMember = "Cod_Cliente";//Cogemos como valor el cod en cbClientes
            cbClientes.DataSource =Constantes.clientesMayor_TA.GetData();//Rellenamos el cbClientes con los datos de la tablaClientesMayor
        }

        /// <summary>
        /// Metodo que modifica la tabla de clientesMayor de la BBDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string cif =Constantes.clientesMayor_TA.GetCifClienteMayor(Convert.ToInt32(cbClientes.SelectedValue));//Recoges el cif del cliente seleccionado de la BBDD
                string nif = tbCif.Text.ToUpper();//Recoges el cif del tbCif
                if (verificar(tbNuevoNombre.Text) || !nif.Equals(cif))//Evaluar que el nombre o el nif sean distintos a los originales
                {
                    Constantes.clientesMayor_TA.UpdateClientes(tbNuevoNombre.Text,nif,Convert.ToInt32(cbClientes.SelectedValue));//Modificamos el cliente en la BBDD
                    MessageBox.Show("El cliente se modifico correctamente");
                    rellenar();//Rellenamos el cbCleintes con los datos modificados
                }
                else
                {
                    MessageBox.Show("El cliente ya existe");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente");
            }
        }

        /// <summary>
        /// Metodo que Rellena los textBox con los datos del cliente que se selecciona en el cbClientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            tbNuevoNombre.Text = Constantes.clientesMayor_TA.GetNomClienteMayor(Convert.ToInt32(cbClientes.SelectedValue));
            tbCif.Text = Constantes.clientesMayor_TA.GetCifClienteMayor(Convert.ToInt32(cbClientes.SelectedValue));

        }
    }
}