using GarTor.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    /// <summary>
    /// Formulariio para el LogIn del programa
    /// </summary>
    public partial class LogIn : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public LogIn()
        {
            InitializeComponent();
            tbUser.Select();

        }
        /// <summary>
        /// Evento onClick del boton de acceder, que llama al metodo para verificar los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logIn(object sender, EventArgs e)
        {
            Verificacion();
            
        }
        /// <summary>
        /// Metodo que comprueba que el usuario y la contraseña existan en la BBDD
        /// </summary>
        private void Verificacion()
        {
            string user = Encriptacion.Encriptar(tbUser.Text.ToString());
            string pass = Encriptacion.Encriptar(tbPass.Text.ToString());
            
            string userBBDD =Convert.ToString(Constantes.acceso_TA.GetUser(user));
            string passBBDD =Convert.ToString(Constantes.acceso_TA.GetPass(pass));

            if (user.Equals(userBBDD) && pass.Equals(passBBDD))
            {
                MessageBoxTemporal.Show("Usuario y contraseña correctos", "Acceso Permitido", 2, true);
                this.Close();
                
                PantallaGestion panel1 = new PantallaGestion();
                panel1.MaximizeBox = false;
                panel1.MinimizeBox = false;
                panel1.ShowIcon = true;
                panel1.ShowInTaskbar = false;

                panel1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Al pulsar "enter" llama al metodo para verificar los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entrar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Verificacion();
            }
        }
    }
}
