using GarTor.Clases;
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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void AgregarUsuarioNuevo(object sender, EventArgs e)
        {
            string user =Encriptacion.Encriptar(tbUsuario.Text);
            string pass =Encriptacion.Encriptar(tbPass.Text);
            MessageBox.Show(user+"   "+pass);
            Constantes.acceso_TA.Insert(user, pass);
        }
    }
}
