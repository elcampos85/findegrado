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
            this.cantidad = new System.Windows.Forms.TextBox();
            this.cbMedidas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbIngredientes
            // 
            this.cbIngredientes.FormattingEnabled = true;
            this.cbIngredientes.Location = new System.Drawing.Point(12, 24);
            this.cbIngredientes.Name = "cbIngredientes";
            this.cbIngredientes.Size = new System.Drawing.Size(512, 21);
            this.cbIngredientes.TabIndex = 0;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(543, 25);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(65, 20);
            this.cantidad.TabIndex = 1;
            // 
            // cbMedidas
            // 
            this.cbMedidas.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.cbMedidas.Location = new System.Drawing.Point(626, 24);
            this.cbMedidas.Name = "cbMedidas";
            this.cbMedidas.Size = new System.Drawing.Size(121, 21);
            this.cbMedidas.TabIndex = 2;
            // 
            // Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1090, 567);
            this.Controls.Add(this.cbMedidas);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.cbIngredientes);
            this.Name = "Produccion";
            this.Text = "Produccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIngredientes;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.ComboBox cbMedidas;
    }
}