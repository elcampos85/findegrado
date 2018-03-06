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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaEnTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miVentaMayor = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miConsultaDia = new System.Windows.Forms.ToolStripMenuItem();
            this.miBalanceMensual = new System.Windows.Forms.ToolStripMenuItem();
            this.miBalanceAnual = new System.Windows.Forms.ToolStripMenuItem();
            this.miGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.tslbFechayHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.pPanelContenedor = new System.Windows.Forms.Panel();
            this.timFechayHora = new System.Windows.Forms.Timer(this.components);
            this.insertarGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.ssEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.contabilidadCajaToolStripMenuItem,
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
            this.ventaEnTiendaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.ventaEnTiendaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ventaEnTiendaToolStripMenuItem.Text = "Venta en Tienda";
            this.ventaEnTiendaToolStripMenuItem.Click += new System.EventHandler(this.ventaEnTiendaToolStripMenuItem_Click);
            // 
            // miVentaMayor
            // 
            this.miVentaMayor.Name = "miVentaMayor";
            this.miVentaMayor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.miVentaMayor.Size = new System.Drawing.Size(214, 22);
            this.miVentaMayor.Text = "Venta al por Mayor";
            this.miVentaMayor.Click += new System.EventHandler(this.miVentaMayor_Click);
            // 
            // contabilidadCajaToolStripMenuItem
            // 
            this.contabilidadCajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miConsultaDia,
            this.miBalanceMensual,
            this.miBalanceAnual,
            this.insertarGastosToolStripMenuItem});
            this.contabilidadCajaToolStripMenuItem.Name = "contabilidadCajaToolStripMenuItem";
            this.contabilidadCajaToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.contabilidadCajaToolStripMenuItem.Text = "Contabilidad/Caja";
            // 
            // miConsultaDia
            // 
            this.miConsultaDia.Name = "miConsultaDia";
            this.miConsultaDia.Size = new System.Drawing.Size(163, 22);
            this.miConsultaDia.Text = "Consulta Diaria";
            this.miConsultaDia.Click += new System.EventHandler(this.miConsultaDia_Click);
            // 
            // miBalanceMensual
            // 
            this.miBalanceMensual.Name = "miBalanceMensual";
            this.miBalanceMensual.Size = new System.Drawing.Size(163, 22);
            this.miBalanceMensual.Text = "Balance Mensual";
            this.miBalanceMensual.Click += new System.EventHandler(this.miBalanceMensual_Click);
            // 
            // miBalanceAnual
            // 
            this.miBalanceAnual.Name = "miBalanceAnual";
            this.miBalanceAnual.Size = new System.Drawing.Size(163, 22);
            this.miBalanceAnual.Text = "Balance Anual";
            this.miBalanceAnual.Click += new System.EventHandler(this.miBalanceAnual_Click);
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
            this.ssEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbFechayHora});
            this.ssEstado.Location = new System.Drawing.Point(0, 571);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(1096, 22);
            this.ssEstado.TabIndex = 1;
            this.ssEstado.Text = "statusStrip1";
            // 
            // tslbFechayHora
            // 
            this.tslbFechayHora.BackColor = System.Drawing.Color.Transparent;
            this.tslbFechayHora.Name = "tslbFechayHora";
            this.tslbFechayHora.Size = new System.Drawing.Size(0, 17);
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
            // timFechayHora
            // 
            this.timFechayHora.Enabled = true;
            this.timFechayHora.Interval = 1000;
            this.timFechayHora.Tick += new System.EventHandler(this.mostrarHora);
            // 
            // insertarGastosToolStripMenuItem
            // 
            this.insertarGastosToolStripMenuItem.Name = "insertarGastosToolStripMenuItem";
            this.insertarGastosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.insertarGastosToolStripMenuItem.Text = "Insertar Gastos";
            this.insertarGastosToolStripMenuItem.Click += new System.EventHandler(this.IngreGastos);
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
            this.ssEstado.ResumeLayout(false);
            this.ssEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaEnTiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miVentaMayor;
        private System.Windows.Forms.ToolStripMenuItem contabilidadCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miBalanceMensual;
        private System.Windows.Forms.ToolStripMenuItem miBalanceAnual;
        private System.Windows.Forms.ToolStripMenuItem miGestion;
        private System.Windows.Forms.StatusStrip ssEstado;
        private System.Windows.Forms.Panel pPanelContenedor;
        private System.Windows.Forms.ToolStripMenuItem miConsultaDia;
        private System.Windows.Forms.Timer timFechayHora;
        private System.Windows.Forms.ToolStripStatusLabel tslbFechayHora;
        private System.Windows.Forms.ToolStripMenuItem insertarGastosToolStripMenuItem;
    }
}

