namespace GarTor
{
    partial class VentaMayor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaMayor));
            this.btAtrasVTienda = new System.Windows.Forms.Button();
            this.panelToolboxVTienda = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btEliminarCesta = new System.Windows.Forms.Button();
            this.Comprar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelSeparadorVTienda = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lPrecio = new System.Windows.Forms.Label();
            this.cesta = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolboxVTienda.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cesta)).BeginInit();
            this.SuspendLayout();
            // 
            // btAtrasVTienda
            // 
            this.btAtrasVTienda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAtrasVTienda.BackgroundImage")));
            this.btAtrasVTienda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAtrasVTienda.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btAtrasVTienda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAtrasVTienda.Location = new System.Drawing.Point(3, 0);
            this.btAtrasVTienda.Name = "btAtrasVTienda";
            this.btAtrasVTienda.Size = new System.Drawing.Size(38, 36);
            this.btAtrasVTienda.TabIndex = 1;
            this.btAtrasVTienda.UseVisualStyleBackColor = true;
            this.btAtrasVTienda.Visible = false;
            // 
            // panelToolboxVTienda
            // 
            this.panelToolboxVTienda.BackColor = System.Drawing.Color.PaleGreen;
            this.panelToolboxVTienda.Controls.Add(this.panel3);
            this.panelToolboxVTienda.Controls.Add(this.panel2);
            this.panelToolboxVTienda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolboxVTienda.Location = new System.Drawing.Point(0, 0);
            this.panelToolboxVTienda.Name = "panelToolboxVTienda";
            this.panelToolboxVTienda.Size = new System.Drawing.Size(1434, 42);
            this.panelToolboxVTienda.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btEliminarCesta);
            this.panel3.Controls.Add(this.Comprar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1285, 0);
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btAtrasVTienda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 42);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.ForestGreen;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 42);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1160, 628);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panelSeparadorVTienda
            // 
            this.panelSeparadorVTienda.BackColor = System.Drawing.Color.DarkGreen;
            this.panelSeparadorVTienda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSeparadorVTienda.Location = new System.Drawing.Point(0, 0);
            this.panelSeparadorVTienda.Name = "panelSeparadorVTienda";
            this.panelSeparadorVTienda.Size = new System.Drawing.Size(8, 628);
            this.panelSeparadorVTienda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lPrecio);
            this.panel1.Controls.Add(this.cesta);
            this.panel1.Controls.Add(this.panelSeparadorVTienda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1160, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 628);
            this.panel1.TabIndex = 7;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lPrecio.Font = new System.Drawing.Font("Rockwell Extra Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(8, 606);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(0, 22);
            this.lPrecio.TabIndex = 2;
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
            this.cesta.Size = new System.Drawing.Size(263, 573);
            this.cesta.TabIndex = 1;
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
            // VentaMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1434, 670);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelToolboxVTienda);
            this.Name = "VentaMayor";
            this.Text = "VentaMayor";
            this.panelToolboxVTienda.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cesta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btAtrasVTienda;
        private System.Windows.Forms.Panel panelToolboxVTienda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btEliminarCesta;
        private System.Windows.Forms.Button Comprar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panelSeparadorVTienda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.DataGridView cesta;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}