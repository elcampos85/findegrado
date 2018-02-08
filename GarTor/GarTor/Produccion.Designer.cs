namespace GarTor
{
    partial class Produccion
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
            this.cbIngredientes = new System.Windows.Forms.ComboBox();
            this.cbMedidas = new System.Windows.Forms.ComboBox();
            this.units = new System.Windows.Forms.NumericUpDown();
            this.lista = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.Grupo = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bImage = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.nMayor = new System.Windows.Forms.NumericUpDown();
            this.nTienda = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.units)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMayor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTienda)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIngredientes
            // 
            this.cbIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIngredientes.FormattingEnabled = true;
            this.cbIngredientes.Location = new System.Drawing.Point(12, 73);
            this.cbIngredientes.Name = "cbIngredientes";
            this.cbIngredientes.Size = new System.Drawing.Size(512, 26);
            this.cbIngredientes.TabIndex = 0;
            // 
            // cbMedidas
            // 
            this.cbMedidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMedidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedidas.FormattingEnabled = true;
            this.cbMedidas.Items.AddRange(new object[] {
            "Unidad/es",
            "Kg",
            "g",
            "mg",
            "L",
            "cL",
            "mL"});
            this.cbMedidas.Location = new System.Drawing.Point(629, 72);
            this.cbMedidas.Name = "cbMedidas";
            this.cbMedidas.Size = new System.Drawing.Size(121, 26);
            this.cbMedidas.TabIndex = 2;
            // 
            // units
            // 
            this.units.DecimalPlaces = 2;
            this.units.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.units.Location = new System.Drawing.Point(530, 72);
            this.units.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(92, 24);
            this.units.TabIndex = 3;
            this.units.ThousandsSeparator = true;
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToResizeColumns = false;
            this.lista.AllowUserToResizeRows = false;
            this.lista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista.BackgroundColor = System.Drawing.Color.Green;
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar,
            this.Ingrediente,
            this.Unidad,
            this.Precio});
            this.lista.GridColor = System.Drawing.Color.Green;
            this.lista.Location = new System.Drawing.Point(878, 29);
            this.lista.Name = "lista";
            this.lista.RowHeadersVisible = false;
            this.lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lista.ShowCellErrors = false;
            this.lista.ShowCellToolTips = false;
            this.lista.ShowEditingIcon = false;
            this.lista.ShowRowErrors = false;
            this.lista.Size = new System.Drawing.Size(385, 636);
            this.lista.TabIndex = 4;
            this.lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Eliminar);
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.Width = 45;
            // 
            // Ingrediente
            // 
            this.Ingrediente.HeaderText = "Ingrediente";
            this.Ingrediente.Name = "Ingrediente";
            this.Ingrediente.ReadOnly = true;
            this.Ingrediente.Width = 190;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.Width = 80;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 50;
            // 
            // Agregar
            // 
            this.Agregar.BackgroundImage = global::GarTor.Resource1.fder;
            this.Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(775, 72);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(40, 27);
            this.Agregar.TabIndex = 5;
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(122, 26);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(439, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(9, 29);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(106, 13);
            this.lNom.TabIndex = 7;
            this.lNom.Text = "Nombre del producto";
            // 
            // Grupo
            // 
            this.Grupo.AutoSize = true;
            this.Grupo.Location = new System.Drawing.Point(594, 29);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(28, 13);
            this.Grupo.TabIndex = 8;
            this.Grupo.Text = "Tipo";
            // 
            // cbGrupo
            // 
            this.cbGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(629, 19);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(121, 26);
            this.cbGrupo.TabIndex = 9;
            // 
            // lPrecio
            // 
            this.lPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lPrecio.AutoEllipsis = true;
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(1119, 678);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(0, 20);
            this.lPrecio.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1037, 678);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "TOTAL: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bImage
            // 
            this.bImage.Location = new System.Drawing.Point(12, 133);
            this.bImage.Name = "bImage";
            this.bImage.Size = new System.Drawing.Size(803, 23);
            this.bImage.TabIndex = 12;
            this.bImage.Text = "Añadir Imagen";
            this.bImage.UseVisualStyleBackColor = true;
            this.bImage.Click += new System.EventHandler(this.bImage_Click);
            // 
            // imagen
            // 
            this.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagen.Location = new System.Drawing.Point(15, 162);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(800, 458);
            this.imagen.TabIndex = 13;
            this.imagen.TabStop = false;
            // 
            // bAgregar
            // 
            this.bAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Location = new System.Drawing.Point(552, 663);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(263, 35);
            this.bAgregar.TabIndex = 14;
            this.bAgregar.Text = "Añadir Producto a la Venta";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // nMayor
            // 
            this.nMayor.DecimalPlaces = 2;
            this.nMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMayor.Location = new System.Drawing.Point(122, 669);
            this.nMayor.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nMayor.Name = "nMayor";
            this.nMayor.Size = new System.Drawing.Size(92, 24);
            this.nMayor.TabIndex = 15;
            this.nMayor.ThousandsSeparator = true;
            // 
            // nTienda
            // 
            this.nTienda.DecimalPlaces = 2;
            this.nTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTienda.Location = new System.Drawing.Point(368, 669);
            this.nTienda.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nTienda.Name = "nTienda";
            this.nTienda.Size = new System.Drawing.Size(92, 24);
            this.nTienda.TabIndex = 16;
            this.nTienda.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 673);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Precio Mayor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 673);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Precio Tienda";
            // 
            // Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1264, 714);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nTienda);
            this.Controls.Add(this.nMayor);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.bImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.Grupo);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.units);
            this.Controls.Add(this.cbMedidas);
            this.Controls.Add(this.cbIngredientes);
            this.Name = "Produccion";
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.units)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMayor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTienda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIngredientes;
        private System.Windows.Forms.ComboBox cbMedidas;
        private System.Windows.Forms.NumericUpDown units;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label Grupo;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bImage;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.NumericUpDown nMayor;
        private System.Windows.Forms.NumericUpDown nTienda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}