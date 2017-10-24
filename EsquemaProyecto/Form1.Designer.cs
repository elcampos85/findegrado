namespace EsquemaProyecto
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularCosteProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaEnTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaAPorMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDeCajaDiariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarIngresosMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarIngresosAnualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.contabilidadCajaToolStripMenuItem,
            this.preciosProveedoresToolStripMenuItem,
            this.calcularCosteProduccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1313, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaEnTiendaToolStripMenuItem,
            this.ventaAPorMayorToolStripMenuItem});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // contabilidadCajaToolStripMenuItem
            // 
            this.contabilidadCajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cierreDeCajaDiariaToolStripMenuItem,
            this.consultarIngresosMesToolStripMenuItem,
            this.consultarIngresosAnualesToolStripMenuItem});
            this.contabilidadCajaToolStripMenuItem.Name = "contabilidadCajaToolStripMenuItem";
            this.contabilidadCajaToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.contabilidadCajaToolStripMenuItem.Text = "Contabilidad/Caja";
            // 
            // preciosProveedoresToolStripMenuItem
            // 
            this.preciosProveedoresToolStripMenuItem.Name = "preciosProveedoresToolStripMenuItem";
            this.preciosProveedoresToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.preciosProveedoresToolStripMenuItem.Text = "Precios Proveedores";
            this.preciosProveedoresToolStripMenuItem.Click += new System.EventHandler(this.preciosProveedoresToolStripMenuItem_Click);
            // 
            // calcularCosteProduccionToolStripMenuItem
            // 
            this.calcularCosteProduccionToolStripMenuItem.Name = "calcularCosteProduccionToolStripMenuItem";
            this.calcularCosteProduccionToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.calcularCosteProduccionToolStripMenuItem.Text = "Calcular Coste Produccion";
            this.calcularCosteProduccionToolStripMenuItem.Click += new System.EventHandler(this.calcularCosteProduccionToolStripMenuItem_Click);
            // 
            // ventaEnTiendaToolStripMenuItem
            // 
            this.ventaEnTiendaToolStripMenuItem.Name = "ventaEnTiendaToolStripMenuItem";
            this.ventaEnTiendaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ventaEnTiendaToolStripMenuItem.Text = "Venta en Tienda";
            this.ventaEnTiendaToolStripMenuItem.Click += new System.EventHandler(this.ventaEnTiendaToolStripMenuItem_Click);
            // 
            // ventaAPorMayorToolStripMenuItem
            // 
            this.ventaAPorMayorToolStripMenuItem.Name = "ventaAPorMayorToolStripMenuItem";
            this.ventaAPorMayorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ventaAPorMayorToolStripMenuItem.Text = "Venta al por Mayor";
            // 
            // cierreDeCajaDiariaToolStripMenuItem
            // 
            this.cierreDeCajaDiariaToolStripMenuItem.Name = "cierreDeCajaDiariaToolStripMenuItem";
            this.cierreDeCajaDiariaToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.cierreDeCajaDiariaToolStripMenuItem.Text = "Cierre de caja diaria";
            this.cierreDeCajaDiariaToolStripMenuItem.Click += new System.EventHandler(this.cierreDeCajaDiariaToolStripMenuItem_Click);
            // 
            // consultarIngresosMesToolStripMenuItem
            // 
            this.consultarIngresosMesToolStripMenuItem.Name = "consultarIngresosMesToolStripMenuItem";
            this.consultarIngresosMesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.consultarIngresosMesToolStripMenuItem.Text = "Consultar Ingresos Mensuales";
            // 
            // consultarIngresosAnualesToolStripMenuItem
            // 
            this.consultarIngresosAnualesToolStripMenuItem.Name = "consultarIngresosAnualesToolStripMenuItem";
            this.consultarIngresosAnualesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.consultarIngresosAnualesToolStripMenuItem.Text = "Consultar ingresos Anuales";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1313, 636);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "Pasteleria Marco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaEnTiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaAPorMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilidadCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreDeCajaDiariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarIngresosMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarIngresosAnualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preciosProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularCosteProduccionToolStripMenuItem;
    }
}

