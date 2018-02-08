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
    public partial class Intro_Peso_UD : Form
    {
        public Intro_Peso_UD()
        {
            InitializeComponent();
        }

        private void intro_Peso_UD(object sender, EventArgs e)
        {
            string peso_UD = tbPeso_UD.Text.ToString();
            Constantes.PESO_UD_PRODUCTO = peso_UD;
            this.Close();
        }
    }
}
