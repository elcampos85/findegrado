namespace GarTor
{
    partial class Finalizar_Compra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEntregado = new System.Windows.Forms.Label();
            this.lbNomEntregado = new System.Windows.Forms.Label();
            this.lbCambio = new System.Windows.Forms.Label();
            this.lbNomCambio = new System.Windows.Forms.Label();
            this.lbImporte = new System.Windows.Forms.Label();
            this.lbEntrega = new System.Windows.Forms.Label();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.numEntrega = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.lbEntregado);
            this.panel1.Controls.Add(this.lbNomEntregado);
            this.panel1.Controls.Add(this.lbCambio);
            this.panel1.Controls.Add(this.lbNomCambio);
            this.panel1.Location = new System.Drawing.Point(153, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 250);
            this.panel1.TabIndex = 1;
            // 
            // lbEntregado
            // 
            this.lbEntregado.AutoSize = true;
            this.lbEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEntregado.Location = new System.Drawing.Point(17, 44);
            this.lbEntregado.Name = "lbEntregado";
            this.lbEntregado.Size = new System.Drawing.Size(180, 63);
            this.lbEntregado.TabIndex = 18;
            this.lbEntregado.Text = "entreg";
            // 
            // lbNomEntregado
            // 
            this.lbNomEntregado.AutoSize = true;
            this.lbNomEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomEntregado.Location = new System.Drawing.Point(49, 10);
            this.lbNomEntregado.Name = "lbNomEntregado";
            this.lbNomEntregado.Size = new System.Drawing.Size(125, 20);
            this.lbNomEntregado.TabIndex = 17;
            this.lbNomEntregado.Text = "ENTREGADO:";
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCambio.Location = new System.Drawing.Point(17, 170);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(202, 63);
            this.lbCambio.TabIndex = 16;
            this.lbCambio.Text = "cambio";
            // 
            // lbNomCambio
            // 
            this.lbNomCambio.AutoSize = true;
            this.lbNomCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomCambio.Location = new System.Drawing.Point(72, 141);
            this.lbNomCambio.Name = "lbNomCambio";
            this.lbNomCambio.Size = new System.Drawing.Size(83, 20);
            this.lbNomCambio.TabIndex = 15;
            this.lbNomCambio.Text = "CAMBIO:";
            // 
            // lbImporte
            // 
            this.lbImporte.AutoSize = true;
            this.lbImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImporte.Location = new System.Drawing.Point(12, 25);
            this.lbImporte.Name = "lbImporte";
            this.lbImporte.Size = new System.Drawing.Size(137, 39);
            this.lbImporte.TabIndex = 2;
            this.lbImporte.Text = "importe";
            // 
            // lbEntrega
            // 
            this.lbEntrega.AutoSize = true;
            this.lbEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEntrega.Location = new System.Drawing.Point(15, 145);
            this.lbEntrega.Name = "lbEntrega";
            this.lbEntrega.Size = new System.Drawing.Size(99, 20);
            this.lbEntrega.TabIndex = 19;
            this.lbEntrega.Text = "ENTREGA:";
            // 
            // btFinalizar
            // 
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.Location = new System.Drawing.Point(153, 291);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(99, 38);
            this.btFinalizar.TabIndex = 20;
            this.btFinalizar.Text = "Introducir";
            this.btFinalizar.UseVisualStyleBackColor = true;
            // 
            // numEntrega
            // 
            this.numEntrega.DecimalPlaces = 2;
            this.numEntrega.Location = new System.Drawing.Point(12, 168);
            this.numEntrega.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numEntrega.Name = "numEntrega";
            this.numEntrega.Size = new System.Drawing.Size(120, 20);
            this.numEntrega.TabIndex = 21;
            // 
            // Finalizar_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.numEntrega);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.lbEntrega);
            this.Controls.Add(this.lbImporte);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Finalizar_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peso_UD";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEntregado;
        private System.Windows.Forms.Label lbNomEntregado;
        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.Label lbNomCambio;
        private System.Windows.Forms.Label lbImporte;
        private System.Windows.Forms.Label lbEntrega;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.NumericUpDown numEntrega;
    }
}