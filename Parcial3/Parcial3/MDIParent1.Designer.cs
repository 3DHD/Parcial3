namespace Parcial3
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parcialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parcialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parcialToolStripMenuItem
            // 
            this.parcialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.example1ToolStripMenuItem,
            this.example2ToolStripMenuItem,
            this.example3ToolStripMenuItem});
            this.parcialToolStripMenuItem.Name = "parcialToolStripMenuItem";
            this.parcialToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.parcialToolStripMenuItem.Text = "parcial";
            // 
            // example1ToolStripMenuItem
            // 
            this.example1ToolStripMenuItem.Name = "example1ToolStripMenuItem";
            this.example1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.example1ToolStripMenuItem.Text = "example 1";
            this.example1ToolStripMenuItem.Click += new System.EventHandler(this.example1ToolStripMenuItem_Click);
            // 
            // example2ToolStripMenuItem
            // 
            this.example2ToolStripMenuItem.Name = "example2ToolStripMenuItem";
            this.example2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.example2ToolStripMenuItem.Text = "Example 2";
            this.example2ToolStripMenuItem.Click += new System.EventHandler(this.example2ToolStripMenuItem_Click);
            // 
            // example3ToolStripMenuItem
            // 
            this.example3ToolStripMenuItem.Name = "example3ToolStripMenuItem";
            this.example3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.example3ToolStripMenuItem.Text = "Example 3";
            this.example3ToolStripMenuItem.Click += new System.EventHandler(this.example3ToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIParent1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parcialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem example1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem example2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem example3ToolStripMenuItem;
    }
}



