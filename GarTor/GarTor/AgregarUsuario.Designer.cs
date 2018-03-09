namespace GarTor
{
    partial class AgregarUsuario
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
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.luser = new System.Windows.Forms.Label();
            this.lpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(192, 109);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 0;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(192, 187);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 1;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(270, 272);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(97, 26);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.AgregarUsuarioNuevo);
            // 
            // luser
            // 
            this.luser.AutoSize = true;
            this.luser.BackColor = System.Drawing.Color.Transparent;
            this.luser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luser.Location = new System.Drawing.Point(122, 108);
            this.luser.Name = "luser";
            this.luser.Size = new System.Drawing.Size(64, 18);
            this.luser.TabIndex = 3;
            this.luser.Text = "Usuario:";
            // 
            // lpass
            // 
            this.lpass.AutoSize = true;
            this.lpass.BackColor = System.Drawing.Color.Transparent;
            this.lpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpass.Location = new System.Drawing.Point(97, 189);
            this.lpass.Name = "lpass";
            this.lpass.Size = new System.Drawing.Size(89, 18);
            this.lpass.TabIndex = 4;
            this.lpass.Text = "Contraseña:";
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GarTor.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1019, 506);
            this.Controls.Add(this.lpass);
            this.Controls.Add(this.luser);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUsuario);
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label luser;
        private System.Windows.Forms.Label lpass;
    }
}