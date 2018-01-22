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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaEnTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miVentaMayor = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miBalanceDiario = new System.Windows.Forms.ToolStripMenuItem();
            this.miConsultaDia = new System.Windows.Forms.ToolStripMenuItem();
            this.miBalanceMensual = new System.Windows.Forms.ToolStripMenuItem();
            this.miBalanceAnual = new System.Windows.Forms.ToolStripMenuItem();
            this.miPreciosProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.miCalcularCosteProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.miGestion = new System.Windows.Forms.ToolStripMenuItem();
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
            this.miPreciosProveedores,
            this.miCalcularCosteProduccion,
            this.miGestion});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1096, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaEnTiendaToolStripMenuItem,
            this.miVentaMayor});
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
            // miVentaMayor
            // 
            this.miVentaMayor.Name = "miVentaMayor";
            this.miVentaMayor.Size = new System.Drawing.Size(174, 22);
            this.miVentaMayor.Text = "Venta al por Mayor";
            this.miVentaMayor.Click += new System.EventHandler(this.miVentaMayor_Click);
            // 
            // contabilidadCajaToolStripMenuItem
            // 
            this.contabilidadCajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBalanceDiario,
            this.miConsultaDia,
            this.miBalanceMensual,
            this.miBalanceAnual});
            this.contabilidadCajaToolStripMenuItem.Name = "contabilidadCajaToolStripMenuItem";
            this.contabilidadCajaToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.contabilidadCajaToolStripMenuItem.Text = "Contabilidad/Caja";
            // 
            // miBalanceDiario
            // 
            this.miBalanceDiario.Name = "miBalanceDiario";
            this.miBalanceDiario.Size = new System.Drawing.Size(173, 22);
            this.miBalanceDiario.Text = "Balance Diario";
            this.miBalanceDiario.Click += new System.EventHandler(this.miBalanceDiario_Click);
            // 
            // miConsultaDia
            // 
            this.miConsultaDia.Name = "miConsultaDia";
            this.miConsultaDia.Size = new System.Drawing.Size(173, 22);
            this.miConsultaDia.Text = "Consulta de un dia";
            this.miConsultaDia.Click += new System.EventHandler(this.miConsultaDia_Click);
            // 
            // miBalanceMensual
            // 
            this.miBalanceMensual.Name = "miBalanceMensual";
            this.miBalanceMensual.Size = new System.Drawing.Size(173, 22);
            this.miBalanceMensual.Text = "Balance Mensual";
            this.miBalanceMensual.Click += new System.EventHandler(this.miBalanceMensual_Click);
            // 
            // miBalanceAnual
            // 
            this.miBalanceAnual.Name = "miBalanceAnual";
            this.miBalanceAnual.Size = new System.Drawing.Size(173, 22);
            this.miBalanceAnual.Text = "Balance Anual";
            this.miBalanceAnual.Click += new System.EventHandler(this.miBalanceAnual_Click);
            // 
            // miPreciosProveedores
            // 
            this.miPreciosProveedores.Name = "miPreciosProveedores";
            this.miPreciosProveedores.Size = new System.Drawing.Size(125, 20);
            this.miPreciosProveedores.Text = "Precios Proveedores";
            this.miPreciosProveedores.Click += new System.EventHandler(this.miPreciosProveedores_Click);
            // 
            // miCalcularCosteProduccion
            // 
            this.miCalcularCosteProduccion.Name = "miCalcularCosteProduccion";
            this.miCalcularCosteProduccion.Size = new System.Drawing.Size(159, 20);
            this.miCalcularCosteProduccion.Text = "Calcular Coste Produccion";
            this.miCalcularCosteProduccion.Click += new System.EventHandler(this.miCalcularCosteProduccion_Click);
            // 
            // miGestion
            // 
            this.miGestion.Name = "miGestion";
            this.miGestion.Size = new System.Drawing.Size(59, 20);
            this.miGestion.Text = "Gestion";
            this.miGestion.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // ssEstado
            // 
            this.ssEstado.Location = new System.Drawing.Point(0, 571);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(1096, 22);
            this.ssEstado.TabIndex = 1;
            this.ssEstado.Text = "statusStrip1";
            // 
            // pPanelContenedor
            // 
            this.pPanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pPanelContenedor.AutoSize = true;
            this.pPanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pPanelContenedor.Location = new System.Drawing.Point(0, 24);
            this.pPanelContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.pPanelContenedor.Name = "pPanelContenedor";
            this.pPanelContenedor.Size = new System.Drawing.Size(1102, 546);
            this.pPanelContenedor.TabIndex = 2;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1096, 593);
            this.Controls.Add(this.pPanelContenedor);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasteleria Marco";
            this.Move += new System.EventHandler(this.mantener);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaEnTiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miVentaMayor;
        private System.Windows.Forms.ToolStripMenuItem contabilidadCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miBalanceDiario;
        private System.Windows.Forms.ToolStripMenuItem miBalanceMensual;
        private System.Windows.Forms.ToolStripMenuItem miBalanceAnual;
        private System.Windows.Forms.ToolStripMenuItem miPreciosProveedores;
        private System.Windows.Forms.ToolStripMenuItem miCalcularCosteProduccion;
        private System.Windows.Forms.ToolStripMenuItem miGestion;
        private System.Windows.Forms.StatusStrip ssEstado;
        private System.Windows.Forms.Panel pPanelContenedor;
        private System.Windows.Forms.ToolStripMenuItem miConsultaDia;
    }
}

