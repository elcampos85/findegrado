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
    /// Formulario principal para la pantalla de gestion
    /// </summary>
    public partial class PantallaGestion : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// Ajusta la ventana al tamaño de la pantalla
        /// </summary>
        public PantallaGestion()
        {
            InitializeComponent();
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height; //Ajusta al alto de la pantalla
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width; //Ajusta al ancho de la pantalla
        }
        /// <summary>
        /// Metodo para impedir que la ventana se pueda mover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mantener(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        //AÑADIR INGREDIENTE
        /// <summary>
        /// Boton para añadir ingrediente, te abre el formulario indicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton para modificar ingrediente, te abre el formulario indicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton para añadir un producto, te abre el formulario indicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton para añadir suplementos, te abre el formulario indicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton para modificar suplemento, te abre el formulario indicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton para modificar productos, te abre el formulario indicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton para añadir proveedores, te abre el formulario indicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton para añadir clientes al por mayor, te abre el formulario indicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton para modificar clientes al por mayor, te abre el formulario indicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Boton para agregar usuarios de acceso, te abre el formulario indicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agregarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.pPanelContenedor.Controls.Count > 0) this.pPanelContenedor.Controls.RemoveAt(0);
            AgregarUsuario panel1 = new AgregarUsuario();
            panel1.TopLevel = false;
            panel1.FormBorderStyle = FormBorderStyle.None;
            panel1.Dock = DockStyle.Fill;
            this.pPanelContenedor.Controls.Add(panel1);
            this.pPanelContenedor.Tag = panel1;
            panel1.Show();
        }
    }
}
