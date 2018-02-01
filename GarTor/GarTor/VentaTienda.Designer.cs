namespace GarTor
{
    partial class VentaTienda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaTienda));
            this.cesta = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelProdVentaTienda = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lPrecio = new System.Windows.Forms.Label();
            this.panelSeparadorVTienda = new System.Windows.Forms.Panel();
            this.panelToolboxVTienda = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btEliminarCesta = new System.Windows.Forms.Button();
            this.Comprar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAtrasVTienda = new System.Windows.Forms.Button();
            this.btAdelanteVTienda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cesta)).BeginInit();
            this.panelProdVentaTienda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelToolboxVTienda.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cesta
            // 
            this.cesta.AllowUserToAddRows = false;
            this.cesta.AllowUserToResizeColumns = false;
            this.cesta.AllowUserToResizeRows = false;
            this.cesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cesta.BackgroundColor = System.Drawing.Color.Green;
            this.cesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar,
            this.Producto,
            this.Unidad,
            this.Precio});
            this.cesta.GridColor = System.Drawing.Color.Green;
            this.cesta.Location = new System.Drawing.Point(8, 0);
            this.cesta.Name = "cesta";
            this.cesta.RowHeadersVisible = false;
            this.cesta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cesta.ShowCellErrors = false;
            this.cesta.ShowCellToolTips = false;
            this.cesta.ShowEditingIcon = false;
            this.cesta.ShowRowErrors = false;
            this.cesta.Size = new System.Drawing.Size(263, 453);
            this.cesta.TabIndex = 1;
            this.cesta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Eliminar);
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.Width = 45;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.Width = 50;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 50;
            // 
            // panelProdVentaTienda
            // 
            this.panelProdVentaTienda.Controls.Add(this.panel1);
            this.panelProdVentaTienda.Controls.Add(this.panelToolboxVTienda);
            this.panelProdVentaTienda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProdVentaTienda.Location = new System.Drawing.Point(0, 0);
            this.panelProdVentaTienda.Name = "panelProdVentaTienda";
            this.panelProdVentaTienda.Size = new System.Drawing.Size(1234, 634);
            this.panelProdVentaTienda.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lPrecio);
            this.panel1.Controls.Add(this.cesta);
            this.panel1.Controls.Add(this.panelSeparadorVTienda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(960, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 592);
            this.panel1.TabIndex = 5;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lPrecio.Font = new System.Drawing.Font("Rockwell Extra Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(8, 570);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(0, 22);
            this.lPrecio.TabIndex = 2;
            // 
            // panelSeparadorVTienda
            // 
            this.panelSeparadorVTienda.BackColor = System.Drawing.Color.DarkGreen;
            this.panelSeparadorVTienda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSeparadorVTienda.Location = new System.Drawing.Point(0, 0);
            this.panelSeparadorVTienda.Name = "panelSeparadorVTienda";
            this.panelSeparadorVTienda.Size = new System.Drawing.Size(8, 592);
            this.panelSeparadorVTienda.TabIndex = 0;
            // 
            // panelToolboxVTienda
            // 
            this.panelToolboxVTienda.BackColor = System.Drawing.Color.PaleGreen;
            this.panelToolboxVTienda.Controls.Add(this.panel3);
            this.panelToolboxVTienda.Controls.Add(this.panel2);
            this.panelToolboxVTienda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolboxVTienda.Location = new System.Drawing.Point(0, 0);
            this.panelToolboxVTienda.Name = "panelToolboxVTienda";
            this.panelToolboxVTienda.Size = new System.Drawing.Size(1234, 42);
            this.panelToolboxVTienda.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btEliminarCesta);
            this.panel3.Controls.Add(this.Comprar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1085, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 42);
            this.panel3.TabIndex = 2;
            // 
            // btEliminarCesta
            // 
            this.btEliminarCesta.BackgroundImage = global::GarTor.Properties.Resources.Delete;
            this.btEliminarCesta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEliminarCesta.Location = new System.Drawing.Point(3, 4);
            this.btEliminarCesta.Name = "btEliminarCesta";
            this.btEliminarCesta.Size = new System.Drawing.Size(36, 33);
            this.btEliminarCesta.TabIndex = 3;
            this.btEliminarCesta.UseVisualStyleBackColor = true;
            this.btEliminarCesta.Click += new System.EventHandler(this.EliminarCestaCompleta);
            // 
            // Comprar
            // 
            this.Comprar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Comprar.BackColor = System.Drawing.Color.Honeydew;
            this.Comprar.BackgroundImage = global::GarTor.Resource1.comprar;
            this.Comprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Comprar.Location = new System.Drawing.Point(64, 4);
            this.Comprar.Margin = new System.Windows.Forms.Padding(0, 0, 10, 5);
            this.Comprar.Name = "Comprar";
            this.Comprar.Size = new System.Drawing.Size(75, 33);
            this.Comprar.TabIndex = 2;
            this.Comprar.UseVisualStyleBackColor = false;
            this.Comprar.Click += new System.EventHandler(this.FinalizarCompra);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btAtrasVTienda);
            this.panel2.Controls.Add(this.btAdelanteVTienda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 42);
            this.panel2.TabIndex = 1;
            // 
            // btAtrasVTienda
            // 
            this.btAtrasVTienda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAtrasVTienda.BackgroundImage")));
            this.btAtrasVTienda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAtrasVTienda.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btAtrasVTienda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAtrasVTienda.Location = new System.Drawing.Point(68, 0);
            this.btAtrasVTienda.Name = "btAtrasVTienda";
            this.btAtrasVTienda.Size = new System.Drawing.Size(38, 36);
            this.btAtrasVTienda.TabIndex = 1;
            this.btAtrasVTienda.UseVisualStyleBackColor = true;
            this.btAtrasVTienda.Visible = false;
            this.btAtrasVTienda.Click += new System.EventHandler(this.RetroPagProductos);
            // 
            // btAdelanteVTienda
            // 
            this.btAdelanteVTienda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAdelanteVTienda.BackgroundImage")));
            this.btAdelanteVTienda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdelanteVTienda.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btAdelanteVTienda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAdelanteVTienda.Location = new System.Drawing.Point(112, 0);
            this.btAdelanteVTienda.Name = "btAdelanteVTienda";
            this.btAdelanteVTienda.Size = new System.Drawing.Size(38, 36);
            this.btAdelanteVTienda.TabIndex = 0;
            this.btAdelanteVTienda.UseVisualStyleBackColor = true;
            this.btAdelanteVTienda.Click += new System.EventHandler(this.PasarPagProductos);
            // 
            // VentaTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1234, 634);
            this.Controls.Add(this.panelProdVentaTienda);
            this.Name = "VentaTienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentaTienda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.cesta)).EndInit();
            this.panelProdVentaTienda.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelToolboxVTienda.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView cesta;
        private System.Windows.Forms.Button Comprar;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Panel panelProdVentaTienda;
        private System.Windows.Forms.Panel panelToolboxVTienda;
        private System.Windows.Forms.Button btAdelanteVTienda;
        private System.Windows.Forms.Panel panelSeparadorVTienda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btAtrasVTienda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btEliminarCesta;
        private System.Windows.Forms.Label lPrecio;
    }
}