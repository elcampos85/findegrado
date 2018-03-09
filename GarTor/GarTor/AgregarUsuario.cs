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

    /// <summary>
    /// Clase para agregar usuarios administradores
    /// </summary>
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void AgregarUsuarioNuevo(object sender, EventArgs e)
        {
            string user = Encriptacion.Encriptar(tbUsuario.Text);//Encriptamos el usuario y lo guardamos en variable
            string pass = Encriptacion.Encriptar(tbPass.Text);//Encriptamos la contraseña y la guardamos en variable
            MessageBox.Show(user+"   "+pass);//Mostramos el usuario y contraseña introducidos para que el administrador compruebe que son correctos
            Constantes.acceso_TA.Insert(user, pass);//Insertamos el usuario encriptado
        }
    }
}
