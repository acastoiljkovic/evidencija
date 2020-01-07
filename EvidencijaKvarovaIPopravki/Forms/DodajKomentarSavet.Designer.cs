namespace EvidencijaKvarovaIPopravki.Forms
{
    partial class DodajKomentarSavet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajKomentarSavet));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNaziv = new MetroFramework.Controls.MetroLabel();
            this.txtNazivKvara = new MetroFramework.Controls.MetroTextBox();
            this.btnPosalji = new MetroFramework.Controls.MetroButton();
            this.txtKomentarSavet = new MetroFramework.Controls.MetroTextBox();
            this.lblKomentarSavet = new MetroFramework.Controls.MetroLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblNaslov = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 31);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNaziv.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNaziv.Location = new System.Drawing.Point(55, 53);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(96, 21);
            this.lblNaziv.TabIndex = 50;
            this.lblNaziv.Text = "Naziv kvara :";
            this.lblNaziv.UseStyleColors = true;
            // 
            // txtNazivKvara
            // 
            // 
            // 
            // 
            this.txtNazivKvara.CustomButton.Image = null;
            this.txtNazivKvara.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtNazivKvara.CustomButton.Name = "";
            this.txtNazivKvara.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNazivKvara.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNazivKvara.CustomButton.TabIndex = 1;
            this.txtNazivKvara.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNazivKvara.CustomButton.UseSelectable = true;
            this.txtNazivKvara.CustomButton.Visible = false;
            this.txtNazivKvara.Enabled = false;
            this.txtNazivKvara.Lines = new string[0];
            this.txtNazivKvara.Location = new System.Drawing.Point(157, 52);
            this.txtNazivKvara.MaxLength = 32767;
            this.txtNazivKvara.Name = "txtNazivKvara";
            this.txtNazivKvara.PasswordChar = '\0';
            this.txtNazivKvara.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNazivKvara.SelectedText = "";
            this.txtNazivKvara.SelectionLength = 0;
            this.txtNazivKvara.SelectionStart = 0;
            this.txtNazivKvara.ShortcutsEnabled = true;
            this.txtNazivKvara.Size = new System.Drawing.Size(191, 23);
            this.txtNazivKvara.TabIndex = 44;
            this.txtNazivKvara.UseSelectable = true;
            this.txtNazivKvara.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNazivKvara.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(334, 192);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(121, 23);
            this.btnPosalji.TabIndex = 47;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseSelectable = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // txtKomentarSavet
            // 
            // 
            // 
            // 
            this.txtKomentarSavet.CustomButton.Image = null;
            this.txtKomentarSavet.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txtKomentarSavet.CustomButton.Name = "";
            this.txtKomentarSavet.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.txtKomentarSavet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKomentarSavet.CustomButton.TabIndex = 1;
            this.txtKomentarSavet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKomentarSavet.CustomButton.UseSelectable = true;
            this.txtKomentarSavet.CustomButton.Visible = false;
            this.txtKomentarSavet.Lines = new string[0];
            this.txtKomentarSavet.Location = new System.Drawing.Point(157, 87);
            this.txtKomentarSavet.MaxLength = 32767;
            this.txtKomentarSavet.Multiline = true;
            this.txtKomentarSavet.Name = "txtKomentarSavet";
            this.txtKomentarSavet.PasswordChar = '\0';
            this.txtKomentarSavet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKomentarSavet.SelectedText = "";
            this.txtKomentarSavet.SelectionLength = 0;
            this.txtKomentarSavet.SelectionStart = 0;
            this.txtKomentarSavet.ShortcutsEnabled = true;
            this.txtKomentarSavet.Size = new System.Drawing.Size(298, 86);
            this.txtKomentarSavet.TabIndex = 46;
            this.txtKomentarSavet.UseSelectable = true;
            this.txtKomentarSavet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKomentarSavet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblKomentarSavet
            // 
            this.lblKomentarSavet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKomentarSavet.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKomentarSavet.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKomentarSavet.Location = new System.Drawing.Point(55, 86);
            this.lblKomentarSavet.Name = "lblKomentarSavet";
            this.lblKomentarSavet.Size = new System.Drawing.Size(96, 21);
            this.lblKomentarSavet.TabIndex = 49;
            this.lblKomentarSavet.Text = "Kom/sav:";
            this.lblKomentarSavet.UseStyleColors = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 31);
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // lblNaslov
            // 
            this.lblNaslov.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNaslov.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNaslov.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNaslov.Location = new System.Drawing.Point(122, 14);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(254, 35);
            this.lblNaslov.TabIndex = 45;
            this.lblNaslov.Text = "Komentar/savet";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNaslov.UseStyleColors = true;
            // 
            // DodajKomentarSavet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 245);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNazivKvara);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtKomentarSavet);
            this.Controls.Add(this.lblKomentarSavet);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblNaslov);
            this.Name = "DodajKomentarSavet";
            this.Activated += new System.EventHandler(this.DodajKomentarSavet_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblNaziv;
        private MetroFramework.Controls.MetroTextBox txtNazivKvara;
        private MetroFramework.Controls.MetroButton btnPosalji;
        private MetroFramework.Controls.MetroTextBox txtKomentarSavet;
        private MetroFramework.Controls.MetroLabel lblKomentarSavet;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroLabel lblNaslov;
    }
}