namespace WFTartaGraphics
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFrattali = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAlberi = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnPoligoni = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.stsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuadrato = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerchio = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPoligono = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.btnPoligoni,
            this.btnFrattali,
            this.btnAlberi,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1284, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFrattali
            // 
            this.btnFrattali.Image = ((System.Drawing.Image)(resources.GetObject("btnFrattali.Image")));
            this.btnFrattali.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFrattali.Name = "btnFrattali";
            this.btnFrattali.Size = new System.Drawing.Size(72, 22);
            this.btnFrattali.Text = "Frattali";
            // 
            // btnFile
            // 
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(54, 22);
            this.btnFile.Text = "File";
            // 
            // btnAlberi
            // 
            this.btnAlberi.Image = ((System.Drawing.Image)(resources.GetObject("btnAlberi.Image")));
            this.btnAlberi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlberi.Name = "btnAlberi";
            this.btnAlberi.Size = new System.Drawing.Size(67, 22);
            this.btnAlberi.Text = "Alberi";
            // 
            // btnPoligoni
            // 
            this.btnPoligoni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuadrato,
            this.btnCerchio,
            this.btnPoligono});
            this.btnPoligoni.Image = ((System.Drawing.Image)(resources.GetObject("btnPoligoni.Image")));
            this.btnPoligoni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPoligoni.Name = "btnPoligoni";
            this.btnPoligoni.Size = new System.Drawing.Size(80, 22);
            this.btnPoligoni.Text = "Poligoni";
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.Text = "toolStripButton5";
            // 
            // stsLabel
            // 
            this.stsLabel.Name = "stsLabel";
            this.stsLabel.Size = new System.Drawing.Size(22, 17);
            this.stsLabel.Text = "---";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnQuadrato
            // 
            this.btnQuadrato.Name = "btnQuadrato";
            this.btnQuadrato.Size = new System.Drawing.Size(180, 22);
            this.btnQuadrato.Text = "Quadrato";
            // 
            // btnCerchio
            // 
            this.btnCerchio.Name = "btnCerchio";
            this.btnCerchio.Size = new System.Drawing.Size(180, 22);
            this.btnCerchio.Text = "Cerchio";
            // 
            // btnPoligono
            // 
            this.btnPoligono.Name = "btnPoligono";
            this.btnPoligono.Size = new System.Drawing.Size(180, 22);
            this.btnPoligono.Text = "Poligono";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "TartaGraphics V0.0.0.1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnFile;
        private System.Windows.Forms.ToolStripDropDownButton btnFrattali;
        private System.Windows.Forms.ToolStripDropDownButton btnAlberi;
        private System.Windows.Forms.ToolStripDropDownButton btnPoligoni;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripStatusLabel stsLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnQuadrato;
        private System.Windows.Forms.ToolStripMenuItem btnCerchio;
        private System.Windows.Forms.ToolStripMenuItem btnPoligono;
    }
}

