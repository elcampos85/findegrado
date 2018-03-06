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
    public partial class ClienteMayorModificar : Form
    {
        public ClienteMayorModificar()
        {
            InitializeComponent();
            rellenar();
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

        private void rellenar()
        {
            cbClientes.DisplayMember = "Nombre_Cliente";
            cbClientes.ValueMember = "Cod_Cliente";
            cbClientes.DataSource =Constantes.clientesMayor_TA.GetData();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string cif =Constantes.clientesMayor_TA.GetCifClienteMayor(Convert.ToInt32(cbClientes.SelectedValue));
                string nif = tbCif.Text.ToUpper();
                if (verificar(tbNuevoNombre.Text) || !nif.Equals(cif))
                {
                    Constantes.clientesMayor_TA.UpdateClientes(tbNuevoNombre.Text,nif,Convert.ToInt32(cbClientes.SelectedValue));
                    MessageBox.Show("El cliente se modifico correctamente");
                    rellenar();
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

        private void cbClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            tbNuevoNombre.Text = Constantes.clientesMayor_TA.GetNomClienteMayor(Convert.ToInt32(cbClientes.SelectedValue));
            tbCif.Text = Constantes.clientesMayor_TA.GetCifClienteMayor(Convert.ToInt32(cbClientes.SelectedValue));

        }
    }
}
