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
    public partial class VentaTienda : Form
    {
        public VentaTienda()
        {
            InitializeComponent();
            cesta.Rows.Add(1);

            cesta.Rows[0].Cells[0].Value = "tarta";
            cesta.Rows[0].Cells[1].Value = "1";
            cesta.Rows[0].Cells[2].Value = "10";
        }
    }
}
