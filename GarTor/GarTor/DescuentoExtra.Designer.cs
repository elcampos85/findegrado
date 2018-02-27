namespace GarTor
{
    partial class DescuentoExtra
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
            this.lPrecio = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bIntro
            // 
            this.bIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIntro.Location = new System.Drawing.Point(88, 101);
            this.bIntro.Name = "bIntro";
            this.bIntro.Size = new System.Drawing.Size(99, 38);
            this.bIntro.TabIndex = 0;
            this.bIntro.Text = "Introducir";
            this.bIntro.UseVisualStyleBackColor = true;
            this.bIntro.Click += new System.EventHandler(this.intro);
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(9, 23);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(243, 18);
            this.lPrecio.TabIndex = 4;
            this.lPrecio.Text = "Descuento o Extra a Introducir:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.Location = new System.Drawing.Point(12, 44);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 24);
            this.tbPrecio.TabIndex = 0;
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(1, 71);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(271, 13);
            this.lInfo.TabIndex = 7;
            this.lInfo.Text = "Para DESCUENTO introduzca menos ( - ) delante del nº";
            // 
            // DescuentoExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.bIntro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DescuentoExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Descuento o Extra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bIntro;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lInfo;
    }
}