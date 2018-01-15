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


            DataSet1TableAdapters.AccesoTableAdapter ata1;
            ata1 = new DataSet1TableAdapters.AccesoTableAdapter();

            String a = ata1.GetUser(user);

            if (user.Equals(ata1.GetUser(user)) && pass.Equals(ata1.GetPass(pass)))
            {
                MessageBoxTemporal.Show("Usuario y contraseña correctos", "Acceso Permitido", 2, true);
                this.Close();
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
