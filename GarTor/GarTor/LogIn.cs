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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            tbUser.Select();

        }

        private void logIn(object sender, EventArgs e)
        {
            Verificacion();
            
        }
        private void Verificacion()
        {
            string user = tbUser.Text.ToString();
            string pass = tbPass.Text.ToString();

            

            String a = Constantes.acceso_TA.GetUser(user);

            if (user.Equals(Constantes.acceso_TA.GetUser(user)) && pass.Equals(Constantes.acceso_TA.GetPass(pass)))
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

        private void Entrar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Verificacion();
            }
        }
    }
}
