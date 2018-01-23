namespace GarTor
{
    partial class PantallaGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaGestion));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preciosProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosMenorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.cierre = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.ssEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preciosProveedoresToolStripMenuItem,
            this.preciosMayorToolStripMenuItem,
            this.preciosMenorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preciosProveedoresToolStripMenuItem
            // 
            this.preciosProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.preciosProveedoresToolStripMenuItem.Name = "preciosProveedoresToolStripMenuItem";
            this.preciosProveedoresToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.preciosProveedoresToolStripMenuItem.Text = "Precios Proveedores";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.añadirToolStripMenuItem.Text = "Añadir";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // preciosMayorToolStripMenuItem
            // 
            this.preciosMayorToolStripMenuItem.Name = "preciosMayorToolStripMenuItem";
            this.preciosMayorToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.preciosMayorToolStripMenuItem.Text = "Precios Mayor";
            // 
            // preciosMenorToolStripMenuItem
            // 
            this.preciosMenorToolStripMenuItem.Name = "preciosMenorToolStripMenuItem";
            this.preciosMenorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.preciosMenorToolStripMenuItem.Text = "Precios Menor";
            // 
            // ssEstado
            // 
            this.ssEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cierre});
            this.ssEstado.Location = new System.Drawing.Point(0, 475);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(955, 22);
            this.ssEstado.TabIndex = 1;
            this.ssEstado.Text = "statusStrip1";
            // 
            // cierre
            // 
            this.cierre.BackColor = System.Drawing.Color.Red;
            this.cierre.Name = "cierre";
            this.cierre.Size = new System.Drawing.Size(332, 17);
            this.cierre.Text = "Recuerde cerrar esta pantalla si no va a modificar ningún dato";
            // 
            // PantallaGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(955, 497);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaGestion";
            this.Text = "PantallaGestion";
            this.Move += new System.EventHandler(this.Mantener);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssEstado.ResumeLayout(false);
            this.ssEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preciosProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preciosMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preciosMenorToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssEstado;
        private System.Windows.Forms.ToolStripStatusLabel cierre;
    }
}