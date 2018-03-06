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

        //AÑADIR INGREDIENTE
        private void añadirToolStripMenuItem1_Click(object sender, EventArgs e)//Añadir Ingrediente
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            AñadirIngrediente panel1 = new AñadirIngrediente();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)//Modificar Ingrediente
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            ModificarIngrediente panel1 = new ModificarIngrediente();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)//Agregar Producto
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

        private void añadirToolStripMenuItem2_Click(object sender, EventArgs e)//Añadir suplemento
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            SuplementoAñadir panel1 = new SuplementoAñadir();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            SuplementoModificar panel1 = new SuplementoModificar();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            ProduccionModificar panel1 = new ProduccionModificar();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void preciosProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            ProveedoresAgregar panel1 = new ProveedoresAgregar();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void añadirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            ClienteMayorAgregar panel1 = new ClienteMayorAgregar();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }

        private void modificarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            ClienteMayorModificar panel1 = new ClienteMayorModificar();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }
    }
}
