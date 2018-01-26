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
            this.Comprar = new System.Windows.Forms.Button();
            this.cesta = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cesta)).BeginInit();
            this.SuspendLayout();
            // 
            // Comprar
            // 
            this.Comprar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Comprar.BackColor = System.Drawing.Color.Honeydew;
            this.Comprar.BackgroundImage = global::GarTor.Resource1.comprar;
            this.Comprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Comprar.Location = new System.Drawing.Point(821, 9);
            this.Comprar.Margin = new System.Windows.Forms.Padding(0, 0, 10, 5);
            this.Comprar.Name = "Comprar";
            this.Comprar.Size = new System.Drawing.Size(76, 33);
            this.Comprar.TabIndex = 3;
            this.Comprar.UseVisualStyleBackColor = false;
            this.Comprar.Click += new System.EventHandler(this.FinalizarCompra);
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
            this.cesta.Location = new System.Drawing.Point(641, 72);
            this.cesta.Name = "cesta";
            this.cesta.RowHeadersVisible = false;
            this.cesta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cesta.ShowCellErrors = false;
            this.cesta.ShowCellToolTips = false;
            this.cesta.ShowEditingIcon = false;
            this.cesta.ShowRowErrors = false;
            this.cesta.Size = new System.Drawing.Size(263, 367);
            this.cesta.TabIndex = 4;
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
            // lPrecio
            // 
            this.lPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(818, 468);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(0, 13);
            this.lPrecio.TabIndex = 5;
            // 
            // VentaMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(916, 506);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.cesta);
            this.Controls.Add(this.Comprar);
            this.Name = "VentaMayor";
            this.Text = "VentaMayor";
            ((System.ComponentModel.ISupportInitialize)(this.cesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Comprar;
        private System.Windows.Forms.DataGridView cesta;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lPrecio;
    }
}