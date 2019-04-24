namespace ParcialNumero3
{
    partial class Formulario2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formulario2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulario4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulario2ToolStripMenuItem,
            this.formulario4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulario2ToolStripMenuItem
            // 
            this.formulario2ToolStripMenuItem.Name = "formulario2ToolStripMenuItem";
            this.formulario2ToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.formulario2ToolStripMenuItem.Text = "Formulario 3";
            this.formulario2ToolStripMenuItem.Click += new System.EventHandler(this.formulario2ToolStripMenuItem_Click);
            // 
            // formulario4ToolStripMenuItem
            // 
            this.formulario4ToolStripMenuItem.Name = "formulario4ToolStripMenuItem";
            this.formulario4ToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.formulario4ToolStripMenuItem.Text = "Formulario 4";
            this.formulario4ToolStripMenuItem.Click += new System.EventHandler(this.formulario4ToolStripMenuItem_Click);
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(689, 459);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formulario2";
            this.Text = "Formulario2";
            this.Load += new System.EventHandler(this.Formulario2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulario2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulario4ToolStripMenuItem;
    }
}