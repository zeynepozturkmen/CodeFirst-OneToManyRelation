namespace CodeFirst_StudentClassroom
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sınıflarıTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencileriTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sınıflarıTanımlamaToolStripMenuItem,
            this.öğrencileriTanımlaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sınıflarıTanımlamaToolStripMenuItem
            // 
            this.sınıflarıTanımlamaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sınıflarıTanımlamaToolStripMenuItem.Image")));
            this.sınıflarıTanımlamaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sınıflarıTanımlamaToolStripMenuItem.Name = "sınıflarıTanımlamaToolStripMenuItem";
            this.sınıflarıTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.sınıflarıTanımlamaToolStripMenuItem.Text = "Sınıfları tanımlama";
            this.sınıflarıTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.sınıflarıTanımlamaToolStripMenuItem_Click);
            // 
            // öğrencileriTanımlaToolStripMenuItem
            // 
            this.öğrencileriTanımlaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrencileriTanımlaToolStripMenuItem.Image")));
            this.öğrencileriTanımlaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.öğrencileriTanımlaToolStripMenuItem.Name = "öğrencileriTanımlaToolStripMenuItem";
            this.öğrencileriTanımlaToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.öğrencileriTanımlaToolStripMenuItem.Text = "Öğrencileri Tanımla";
            this.öğrencileriTanımlaToolStripMenuItem.Click += new System.EventHandler(this.öğrencileriTanımlaToolStripMenuItem_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGiris";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sınıflarıTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencileriTanımlaToolStripMenuItem;
    }
}

