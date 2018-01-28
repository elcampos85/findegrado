namespace GarTor
{
    partial class ModificarIngrediente
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
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Añadir = new System.Windows.Forms.Button();
            this.cbMedidas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.units = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.units)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(389, 88);
            this.cantidad.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(120, 24);
            this.cantidad.TabIndex = 21;
            this.cantidad.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cantidad";
            // 
            // Añadir
            // 
            this.Añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Añadir.Location = new System.Drawing.Point(471, 168);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(92, 28);
            this.Añadir.TabIndex = 19;
            this.Añadir.Text = "Añadir";
            this.Añadir.UseVisualStyleBackColor = true;
            // 
            // cbMedidas
            // 
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
            this.cbMedidas.Location = new System.Drawing.Point(608, 87);
            this.cbMedidas.Name = "cbMedidas";
            this.cbMedidas.Size = new System.Drawing.Size(121, 26);
            this.cbMedidas.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Medida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio";
            // 
            // units
            // 
            this.units.DecimalPlaces = 2;
            this.units.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.units.Location = new System.Drawing.Point(175, 88);
            this.units.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(120, 24);
            this.units.TabIndex = 15;
            this.units.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(672, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre de Ingrediente";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(175, 32);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(491, 24);
            this.tbNombre.TabIndex = 12;
            // 
            // cbProveedores
            // 
            this.cbProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(755, 30);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(321, 26);
            this.cbProveedores.TabIndex = 11;
            // 
            // ModificarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1110, 512);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.cbMedidas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.units);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.cbProveedores);
            this.Name = "ModificarIngrediente";
            this.Text = "ModificarIngrediente";
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.units)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.ComboBox cbMedidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown units;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cbProveedores;
    }
}