namespace GarTor
{
    partial class VentanaGastos
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
            this.bIntro = new System.Windows.Forms.Button();
            this.lPass = new System.Windows.Forms.Label();
            this.tbGasto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bIntro
            // 
            this.bIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIntro.Location = new System.Drawing.Point(444, 51);
            this.bIntro.Name = "bIntro";
            this.bIntro.Size = new System.Drawing.Size(99, 38);
            this.bIntro.TabIndex = 0;
            this.bIntro.Text = "Introducir";
            this.bIntro.UseVisualStyleBackColor = true;
            this.bIntro.Click += new System.EventHandler(this.intro_Gasto);
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPass.Location = new System.Drawing.Point(22, 60);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(212, 18);
            this.lPass.TabIndex = 4;
            this.lPass.Text = "Cantidad de Gasto a introducir:";
            // 
            // tbGasto
            // 
            this.tbGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGasto.Location = new System.Drawing.Point(240, 57);
            this.tbGasto.Name = "tbGasto";
            this.tbGasto.Size = new System.Drawing.Size(182, 24);
            this.tbGasto.TabIndex = 0;
            this.tbGasto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbGasto_KeyDown);
            this.tbGasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // VentanaGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.tbGasto);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.bIntro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VentanaGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bIntro;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.TextBox tbGasto;
    }
}