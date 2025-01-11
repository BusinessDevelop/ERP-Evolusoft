namespace EvoluSoft
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ficharToolStripMenuItem = new ToolStripMenuItem();
            tablónDeAnunciosToolStripMenuItem = new ToolStripMenuItem();
            calendarioDeVacacionesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ficharToolStripMenuItem, tablónDeAnunciosToolStripMenuItem, calendarioDeVacacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ficharToolStripMenuItem
            // 
            ficharToolStripMenuItem.Name = "ficharToolStripMenuItem";
            ficharToolStripMenuItem.Size = new Size(62, 24);
            ficharToolStripMenuItem.Text = "Fichar";
            ficharToolStripMenuItem.Click += FicharToolStripMenuItem_Click;
            // 
            // tablónDeAnunciosToolStripMenuItem
            // 
            tablónDeAnunciosToolStripMenuItem.Name = "tablónDeAnunciosToolStripMenuItem";
            tablónDeAnunciosToolStripMenuItem.Size = new Size(152, 24);
            tablónDeAnunciosToolStripMenuItem.Text = "Tablón de Anuncios";
            tablónDeAnunciosToolStripMenuItem.Click += TablónDeAnunciosToolStripMenuItem_Click;
            // 
            // calendarioDeVacacionesToolStripMenuItem
            // 
            calendarioDeVacacionesToolStripMenuItem.Name = "calendarioDeVacacionesToolStripMenuItem";
            calendarioDeVacacionesToolStripMenuItem.Size = new Size(193, 24);
            calendarioDeVacacionesToolStripMenuItem.Text = "Calendario de Vacaciones";
            calendarioDeVacacionesToolStripMenuItem.Click += CalendarioDeVacacionesToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "EvoluSoft";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablónDeAnunciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioDeVacacionesToolStripMenuItem;
    }
}
