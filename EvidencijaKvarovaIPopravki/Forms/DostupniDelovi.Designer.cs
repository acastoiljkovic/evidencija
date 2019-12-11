namespace EvidencijaKvarovaIPopravki.Forms
{
    partial class DostupniDelovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DostupniDelovi));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabDostupni = new MetroFramework.Controls.MetroTabPage();
            this.tabNaruciti = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(169, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(254, 35);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Dostupni delovi";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel1.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 35);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabDostupni);
            this.metroTabControl1.Controls.Add(this.tabNaruciti);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 52);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(613, 362);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabDostupni
            // 
            this.tabDostupni.HorizontalScrollbarBarColor = true;
            this.tabDostupni.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDostupni.HorizontalScrollbarSize = 10;
            this.tabDostupni.Location = new System.Drawing.Point(4, 38);
            this.tabDostupni.Name = "tabDostupni";
            this.tabDostupni.Size = new System.Drawing.Size(605, 320);
            this.tabDostupni.TabIndex = 0;
            this.tabDostupni.Text = "Delovi u magacinu";
            this.tabDostupni.VerticalScrollbarBarColor = true;
            this.tabDostupni.VerticalScrollbarHighlightOnWheel = false;
            this.tabDostupni.VerticalScrollbarSize = 10;
            // 
            // tabNaruciti
            // 
            this.tabNaruciti.HorizontalScrollbarBarColor = true;
            this.tabNaruciti.HorizontalScrollbarHighlightOnWheel = false;
            this.tabNaruciti.HorizontalScrollbarSize = 10;
            this.tabNaruciti.Location = new System.Drawing.Point(4, 38);
            this.tabNaruciti.Name = "tabNaruciti";
            this.tabNaruciti.Size = new System.Drawing.Size(605, 320);
            this.tabNaruciti.TabIndex = 1;
            this.tabNaruciti.Text = "Delovi koje treba naruciti";
            this.tabNaruciti.VerticalScrollbarBarColor = true;
            this.tabNaruciti.VerticalScrollbarHighlightOnWheel = false;
            this.tabNaruciti.VerticalScrollbarSize = 10;
            // 
            // DostupniDelovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 437);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "DostupniDelovi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabDostupni;
        private MetroFramework.Controls.MetroTabPage tabNaruciti;
    }
}