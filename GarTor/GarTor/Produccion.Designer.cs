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
            this.Agregar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.units)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIngredientes
            // 
            this.cbIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIngredientes.FormattingEnabled = true;
            this.cbIngredientes.Location = new System.Drawing.Point(12, 24);
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
            "Unidad",
            "Kg",
            "g",
            "mg",
            "L",
            "cL",
            "mL",
            "Caja"});
            this.cbMedidas.Location = new System.Drawing.Point(631, 25);
            this.cbMedidas.Name = "cbMedidas";
            this.cbMedidas.Size = new System.Drawing.Size(121, 26);
            this.cbMedidas.TabIndex = 2;
            // 
            // units
            // 
            this.units.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.units.Location = new System.Drawing.Point(538, 26);
            this.units.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(76, 24);
            this.units.TabIndex = 3;
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
            this.lista.Location = new System.Drawing.Point(811, 26);
            this.lista.Name = "lista";
            this.lista.RowHeadersVisible = false;
            this.lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lista.ShowCellErrors = false;
            this.lista.ShowCellToolTips = false;
            this.lista.ShowEditingIcon = false;
            this.lista.ShowRowErrors = false;
            this.lista.Size = new System.Drawing.Size(385, 565);
            this.lista.TabIndex = 4;
            this.lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Eliminar);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(539, 68);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button1_Click);
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
            this.Unidad.Width = 80;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 50;
            // 
            // Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1221, 632);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.units);
            this.Controls.Add(this.cbMedidas);
            this.Controls.Add(this.cbIngredientes);
            this.Name = "Produccion";
            this.Text = "Produccion";
            ((System.ComponentModel.ISupportInitialize)(this.units)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIngredientes;
        private System.Windows.Forms.ComboBox cbMedidas;
        private System.Windows.Forms.NumericUpDown units;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}