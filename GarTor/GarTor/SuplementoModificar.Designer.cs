namespace GarTor
{
    partial class SuplementoModificar
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
            this.cbSuplemento = new System.Windows.Forms.ComboBox();
            this.bModificar = new System.Windows.Forms.Button();
            this.NPrecio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSuplemento
            // 
            this.cbSuplemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuplemento.FormattingEnabled = true;
            this.cbSuplemento.Location = new System.Drawing.Point(178, 22);
            this.cbSuplemento.Name = "cbSuplemento";
            this.cbSuplemento.Size = new System.Drawing.Size(370, 26);
            this.cbSuplemento.TabIndex = 0;
            this.cbSuplemento.SelectedValueChanged += new System.EventHandler(this.cbSuplemento_SelectedValueChanged);
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(359, 618);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(120, 26);
            this.bModificar.TabIndex = 10;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // NPrecio
            // 
            this.NPrecio.DecimalPlaces = 2;
            this.NPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPrecio.Location = new System.Drawing.Point(178, 112);
            this.NPrecio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.NPrecio.Name = "NPrecio";
            this.NPrecio.Size = new System.Drawing.Size(120, 24);
            this.NPrecio.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nuevo nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(178, 67);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(370, 24);
            this.tbNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Suplemento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(715, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Cambiar imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imagen
            // 
            this.imagen.BackgroundImage = global::GarTor.Properties.Resources.Fondo;
            this.imagen.Location = new System.Drawing.Point(9, 185);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(715, 415);
            this.imagen.TabIndex = 41;
            this.imagen.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SuplementoModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::GarTor.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1146, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.NPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.cbSuplemento);
            this.Name = "SuplementoModificar";
            this.Text = "SuplementoModificar";
            ((System.ComponentModel.ISupportInitialize)(this.NPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSuplemento;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.NumericUpDown NPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}