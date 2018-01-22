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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height; //Ajusta al alto de la pantalla
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width; //Ajusta al ancho de la pantalla

            //int a=DesktopBounds.Height; //Muestra el alto de la pantalla actual
            //this.MaximizeBox = false;
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            Portada panel1 = new Portada();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            LogIn panel1 = new LogIn();
            panel1.MaximizeBox = false;
            panel1.MinimizeBox = false;
            panel1.ShowIcon = false;
            panel1.ShowInTaskbar = false;
            
            //panel1.IsRestrictedWindow;
            panel1.ShowDialog();
        }

        private void ventaEnTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0)this.pPanelContenedor.Controls.RemoveAt(0);
            VentaTienda panel1 = new VentaTienda();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void mantener(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void miVentaMayor_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0)this.pPanelContenedor.Controls.RemoveAt(0);
            VentaMayor panel1 = new VentaMayor();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void miBalanceDiario_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            CierreCaja panel1 = new CierreCaja();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void miConsultaDia_Click(object sender, EventArgs e)
        {
            if(this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            ConsultaDia panel1 = new ConsultaDia();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void miBalanceMensual_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            IngreMen panel1 = new IngreMen();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void miBalanceAnual_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            IngreAnu panel1 = new IngreAnu();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void miCalcularCosteProduccion_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            Produccion panel1 = new Produccion();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void miPreciosProveedores_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            Proveedores panel1 = new Proveedores();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        
    }
}
