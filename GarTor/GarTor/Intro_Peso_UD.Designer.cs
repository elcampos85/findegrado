namespace GarTor
{
    partial class Intro_Peso_UD
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
            this.tbPeso_UD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbPeso_UD)).BeginInit();
            this.SuspendLayout();
            // 
            // bIntro
            // 
            this.bIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIntro.Location = new System.Drawing.Point(43, 111);
            this.bIntro.Name = "bIntro";
            this.bIntro.Size = new System.Drawing.Size(99, 38);
            this.bIntro.TabIndex = 0;
            this.bIntro.Text = "Introducir";
            this.bIntro.UseVisualStyleBackColor = true;
            this.bIntro.Click += new System.EventHandler(this.intro_Peso_UD);
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Location = new System.Drawing.Point(51, 23);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(91, 13);
            this.lPass.TabIndex = 4;
            this.lPass.Text = "Peso o Unidades:";
            // 
            // tbPeso_UD
            // 
            this.tbPeso_UD.DecimalPlaces = 3;
            this.tbPeso_UD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPeso_UD.Location = new System.Drawing.Point(50, 39);
            this.tbPeso_UD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.tbPeso_UD.Name = "tbPeso_UD";
            this.tbPeso_UD.Size = new System.Drawing.Size(92, 24);
            this.tbPeso_UD.TabIndex = 0;
            this.tbPeso_UD.ThousandsSeparator = true;
            // 
            // Intro_Peso_UD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.tbPeso_UD);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.bIntro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Intro_Peso_UD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peso_UD";
            ((System.ComponentModel.ISupportInitialize)(this.tbPeso_UD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bIntro;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.NumericUpDown tbPeso_UD;
    }
}