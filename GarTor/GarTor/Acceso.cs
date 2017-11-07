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
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
            tbUser.Select();

        }

        private void logIn(object sender, EventArgs e)
        {
            string user = tbUser.Text;
            string pass = tbPass.Text;

            if (pass == "123")
            {
                MessageBox.Show("yeah");
            }
        }
    }
}
