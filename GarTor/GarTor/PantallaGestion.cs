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
    public partial class PantallaGestion : Form
    {
        public PantallaGestion()
        {
            InitializeComponent();
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height; //Ajusta al alto de la pantalla
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width; //Ajusta al ancho de la pantalla


        }

        private void Mantener(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

       
    }
}
