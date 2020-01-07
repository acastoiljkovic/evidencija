namespace EvidencijaKvarovaIPopravki.Forms
{
    partial class IzmeniSifru
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnPotvrdi = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPostojeca = new MetroFramework.Controls.MetroTextBox();
            this.txtNova = new MetroFramework.Controls.MetroTextBox();
            this.txtPotvrdaNove = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(8, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(400, 35);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Izmena sifre";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel1.UseStyleColors = true;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(289, 175);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(104, 23);
            this.btnPotvrdi.TabIndex = 31;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseSelectable = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(142, 19);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Unesite postojecu sifru:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 89);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Nova sifra:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 120);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Potvrdite sifru:";
            // 
            // txtPostojeca
            // 
            // 
            // 
            // 
            this.txtPostojeca.CustomButton.Image = null;
            this.txtPostojeca.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtPostojeca.CustomButton.Name = "";
            this.txtPostojeca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPostojeca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPostojeca.CustomButton.TabIndex = 1;
            this.txtPostojeca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPostojeca.CustomButton.UseSelectable = true;
            this.txtPostojeca.CustomButton.Visible = false;
            this.txtPostojeca.Lines = new string[0];
            this.txtPostojeca.Location = new System.Drawing.Point(215, 60);
            this.txtPostojeca.MaxLength = 32767;
            this.txtPostojeca.Name = "txtPostojeca";
            this.txtPostojeca.PasswordChar = '*';
            this.txtPostojeca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPostojeca.SelectedText = "";
            this.txtPostojeca.SelectionLength = 0;
            this.txtPostojeca.SelectionStart = 0;
            this.txtPostojeca.ShortcutsEnabled = true;
            this.txtPostojeca.Size = new System.Drawing.Size(178, 23);
            this.txtPostojeca.TabIndex = 35;
            this.txtPostojeca.UseSelectable = true;
            this.txtPostojeca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPostojeca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNova
            // 
            // 
            // 
            // 
            this.txtNova.CustomButton.Image = null;
            this.txtNova.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtNova.CustomButton.Name = "";
            this.txtNova.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNova.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNova.CustomButton.TabIndex = 1;
            this.txtNova.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNova.CustomButton.UseSelectable = true;
            this.txtNova.CustomButton.Visible = false;
            this.txtNova.Lines = new string[0];
            this.txtNova.Location = new System.Drawing.Point(215, 89);
            this.txtNova.MaxLength = 32767;
            this.txtNova.Name = "txtNova";
            this.txtNova.PasswordChar = '*';
            this.txtNova.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNova.SelectedText = "";
            this.txtNova.SelectionLength = 0;
            this.txtNova.SelectionStart = 0;
            this.txtNova.ShortcutsEnabled = true;
            this.txtNova.Size = new System.Drawing.Size(178, 23);
            this.txtNova.TabIndex = 36;
            this.txtNova.UseSelectable = true;
            this.txtNova.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNova.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPotvrdaNove
            // 
            // 
            // 
            // 
            this.txtPotvrdaNove.CustomButton.Image = null;
            this.txtPotvrdaNove.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtPotvrdaNove.CustomButton.Name = "";
            this.txtPotvrdaNove.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPotvrdaNove.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPotvrdaNove.CustomButton.TabIndex = 1;
            this.txtPotvrdaNove.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPotvrdaNove.CustomButton.UseSelectable = true;
            this.txtPotvrdaNove.CustomButton.Visible = false;
            this.txtPotvrdaNove.Lines = new string[0];
            this.txtPotvrdaNove.Location = new System.Drawing.Point(215, 120);
            this.txtPotvrdaNove.MaxLength = 32767;
            this.txtPotvrdaNove.Name = "txtPotvrdaNove";
            this.txtPotvrdaNove.PasswordChar = '*';
            this.txtPotvrdaNove.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPotvrdaNove.SelectedText = "";
            this.txtPotvrdaNove.SelectionLength = 0;
            this.txtPotvrdaNove.SelectionStart = 0;
            this.txtPotvrdaNove.ShortcutsEnabled = true;
            this.txtPotvrdaNove.Size = new System.Drawing.Size(178, 23);
            this.txtPotvrdaNove.TabIndex = 37;
            this.txtPotvrdaNove.UseSelectable = true;
            this.txtPotvrdaNove.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPotvrdaNove.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // IzmeniSifru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 230);
            this.Controls.Add(this.txtPotvrdaNove);
            this.Controls.Add(this.txtNova);
            this.Controls.Add(this.txtPostojeca);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.metroLabel1);
            this.Name = "IzmeniSifru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnPotvrdi;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPostojeca;
        private MetroFramework.Controls.MetroTextBox txtNova;
        private MetroFramework.Controls.MetroTextBox txtPotvrdaNove;
    }
}