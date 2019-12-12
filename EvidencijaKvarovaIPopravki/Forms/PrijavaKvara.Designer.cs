namespace EvidencijaKvarovaIPopravki.Forms
{
    partial class PrijavaKvara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaKvara));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtPrijavaKvara = new MetroFramework.Controls.MetroTextBox();
            this.btnPosalji = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(124, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(254, 35);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Prijava kvara";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroLabel3.Location = new System.Drawing.Point(57, 63);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(209, 21);
            this.metroLabel3.TabIndex = 38;
            this.metroLabel3.Text = "Prijavite kvar koji se desio:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 58);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 31);
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // txtPrijavaKvara
            // 
            // 
            // 
            // 
            this.txtPrijavaKvara.CustomButton.Image = null;
            this.txtPrijavaKvara.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.txtPrijavaKvara.CustomButton.Name = "";
            this.txtPrijavaKvara.CustomButton.Size = new System.Drawing.Size(195, 195);
            this.txtPrijavaKvara.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrijavaKvara.CustomButton.TabIndex = 1;
            this.txtPrijavaKvara.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrijavaKvara.CustomButton.UseSelectable = true;
            this.txtPrijavaKvara.CustomButton.Visible = false;
            this.txtPrijavaKvara.Lines = new string[0];
            this.txtPrijavaKvara.Location = new System.Drawing.Point(57, 89);
            this.txtPrijavaKvara.MaxLength = 32767;
            this.txtPrijavaKvara.Multiline = true;
            this.txtPrijavaKvara.Name = "txtPrijavaKvara";
            this.txtPrijavaKvara.PasswordChar = '\0';
            this.txtPrijavaKvara.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrijavaKvara.SelectedText = "";
            this.txtPrijavaKvara.SelectionLength = 0;
            this.txtPrijavaKvara.SelectionStart = 0;
            this.txtPrijavaKvara.ShortcutsEnabled = true;
            this.txtPrijavaKvara.Size = new System.Drawing.Size(400, 200);
            this.txtPrijavaKvara.TabIndex = 39;
            this.txtPrijavaKvara.UseSelectable = true;
            this.txtPrijavaKvara.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrijavaKvara.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(336, 300);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(121, 23);
            this.btnPosalji.TabIndex = 40;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseSelectable = true;
            // 
            // PrijavaKvara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 335);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtPrijavaKvara);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.metroLabel1);
            this.Name = "PrijavaKvara";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroTextBox txtPrijavaKvara;
        private MetroFramework.Controls.MetroButton btnPosalji;
    }
}