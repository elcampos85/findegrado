namespace GarTor
{
    partial class LogIn
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
            this.bEntrar = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lUser = new System.Windows.Forms.Label();
            this.lPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bEntrar
            // 
            this.bEntrar.Location = new System.Drawing.Point(75, 177);
            this.bEntrar.Name = "bEntrar";
            this.bEntrar.Size = new System.Drawing.Size(99, 38);
            this.bEntrar.TabIndex = 0;
            this.bEntrar.Text = "Acceder";
            this.bEntrar.UseVisualStyleBackColor = true;
            this.bEntrar.Click += new System.EventHandler(this.logIn);
            // 
            // tbUser
            // 
            this.tbUser.AcceptsTab = true;
            this.tbUser.BackColor = System.Drawing.SystemColors.Window;
            this.tbUser.Location = new System.Drawing.Point(107, 57);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(119, 20);
            this.tbUser.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.AcceptsTab = true;
            this.tbPass.Location = new System.Drawing.Point(107, 95);
            this.tbPass.MaxLength = 16;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '★';
            this.tbPass.Size = new System.Drawing.Size(119, 20);
            this.tbPass.TabIndex = 2;
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(27, 60);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(46, 13);
            this.lUser.TabIndex = 3;
            this.lUser.Text = "Usuario:";
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Location = new System.Drawing.Point(27, 98);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(64, 13);
            this.lPass.TabIndex = 4;
            this.lPass.Text = "Contraseña:";
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(250, 241);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.bEntrar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEntrar;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Label lPass;
    }
}