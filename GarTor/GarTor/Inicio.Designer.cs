namespace GarTor
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaEnTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaAlPorMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDeCajaDiariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarIngresosMensualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarIngresosAnualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularCosteProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.pPanelContenedor = new System.Windows.Forms.Panel();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.contabilidadCajaToolStripMenuItem,
            this.preciosProveedoresToolStripMenuItem,
            this.calcularCosteProduccionToolStripMenuItem,
            this.gestionToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1003, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaEnTiendaToolStripMenuItem,
            this.ventaAlPorMayorToolStripMenuItem});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // ventaEnTiendaToolStripMenuItem
            // 
            this.ventaEnTiendaToolStripMenuItem.Name = "ventaEnTiendaToolStripMenuItem";
            this.ventaEnTiendaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ventaEnTiendaToolStripMenuItem.Text = "Venta en Tienda";
            this.ventaEnTiendaToolStripMenuItem.Click += new System.EventHandler(this.ventaEnTiendaToolStripMenuItem_Click);
            // 
            // ventaAlPorMayorToolStripMenuItem
            // 
            this.ventaAlPorMayorToolStripMenuItem.Name = "ventaAlPorMayorToolStripMenuItem";
            this.ventaAlPorMayorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ventaAlPorMayorToolStripMenuItem.Text = "Venta al por Mayor";
            // 
            // contabilidadCajaToolStripMenuItem
            // 
            this.contabilidadCajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cierreDeCajaDiariaToolStripMenuItem,
            this.consultarIngresosMensualesToolStripMenuItem,
            this.consultarIngresosAnualesToolStripMenuItem});
            this.contabilidadCajaToolStripMenuItem.Name = "contabilidadCajaToolStripMenuItem";
            this.contabilidadCajaToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.contabilidadCajaToolStripMenuItem.Text = "Contabilidad/Caja";
            // 
            // cierreDeCajaDiariaToolStripMenuItem
            // 
            this.cierreDeCajaDiariaToolStripMenuItem.Name = "cierreDeCajaDiariaToolStripMenuItem";
            this.cierreDeCajaDiariaToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.cierreDeCajaDiariaToolStripMenuItem.Text = "Cierre de caja diaria";
            // 
            // consultarIngresosMensualesToolStripMenuItem
            // 
            this.consultarIngresosMensualesToolStripMenuItem.Name = "consultarIngresosMensualesToolStripMenuItem";
            this.consultarIngresosMensualesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.consultarIngresosMensualesToolStripMenuItem.Text = "Consultar Ingresos Mensuales";
            // 
            // consultarIngresosAnualesToolStripMenuItem
            // 
            this.consultarIngresosAnualesToolStripMenuItem.Name = "consultarIngresosAnualesToolStripMenuItem";
            this.consultarIngresosAnualesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.consultarIngresosAnualesToolStripMenuItem.Text = "Consultar Ingresos Anuales";
            // 
            // preciosProveedoresToolStripMenuItem
            // 
            this.preciosProveedoresToolStripMenuItem.Name = "preciosProveedoresToolStripMenuItem";
            this.preciosProveedoresToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.preciosProveedoresToolStripMenuItem.Text = "Precios Proveedores";
            // 
            // calcularCosteProduccionToolStripMenuItem
            // 
            this.calcularCosteProduccionToolStripMenuItem.Name = "calcularCosteProduccionToolStripMenuItem";
            this.calcularCosteProduccionToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.calcularCosteProduccionToolStripMenuItem.Text = "Calcular Coste Produccion";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // ssEstado
            // 
            this.ssEstado.Location = new System.Drawing.Point(0, 475);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(1003, 22);
            this.ssEstado.TabIndex = 1;
            this.ssEstado.Text = "statusStrip1";
            // 
            // pPanelContenedor
            // 
            this.pPanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pPanelContenedor.AutoSize = true;
            this.pPanelContenedor.Location = new System.Drawing.Point(0, 24);
            this.pPanelContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.pPanelContenedor.Name = "pPanelContenedor";
            this.pPanelContenedor.Size = new System.Drawing.Size(1009, 450);
            this.pPanelContenedor.TabIndex = 2;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1003, 497);
            this.Controls.Add(this.pPanelContenedor);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMenu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasteleria Marco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaEnTiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaAlPorMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilidadCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreDeCajaDiariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarIngresosMensualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarIngresosAnualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preciosProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularCosteProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssEstado;
        private System.Windows.Forms.Panel pPanelContenedor;
    }
}

