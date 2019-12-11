namespace EvidencijaKvarovaIPopravki.Forms
{
    partial class Pocetna
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TabPopravke = new MetroFramework.Controls.MetroTabPage();
            this.btnDelovi = new MetroFramework.Controls.MetroButton();
            this.btnPopravka = new MetroFramework.Controls.MetroButton();
            this.gridPopravke = new MetroFramework.Controls.MetroGrid();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPretragaPopravke = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnDodajKvar = new MetroFramework.Controls.MetroButton();
            this.tabZaposleni = new MetroFramework.Controls.MetroTabPage();
            this.gridZaposleni = new MetroFramework.Controls.MetroGrid();
            this.txtPretragaZaposleni = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabModeli = new MetroFramework.Controls.MetroTabPage();
            this.gridModeli = new MetroFramework.Controls.MetroGrid();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtPretragaModeli = new MetroFramework.Controls.MetroTextBox();
            this.btnUlogujSe = new MetroFramework.Controls.MetroButton();
            this.btnKreirajNalog = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.TabPopravke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopravke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabZaposleni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZaposleni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabModeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridModeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(300, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(254, 35);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Evidencija kvarova i popravki";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.TabPopravke);
            this.metroTabControl1.Controls.Add(this.tabZaposleni);
            this.metroTabControl1.Controls.Add(this.tabModeli);
            this.metroTabControl1.Location = new System.Drawing.Point(22, 93);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 500);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // TabPopravke
            // 
            this.TabPopravke.Controls.Add(this.btnDelovi);
            this.TabPopravke.Controls.Add(this.btnPopravka);
            this.TabPopravke.Controls.Add(this.gridPopravke);
            this.TabPopravke.Controls.Add(this.pictureBox2);
            this.TabPopravke.Controls.Add(this.txtPretragaPopravke);
            this.TabPopravke.Controls.Add(this.metroButton1);
            this.TabPopravke.Controls.Add(this.btnDodajKvar);
            this.TabPopravke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPopravke.HorizontalScrollbarBarColor = true;
            this.TabPopravke.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPopravke.HorizontalScrollbarSize = 10;
            this.TabPopravke.Location = new System.Drawing.Point(4, 38);
            this.TabPopravke.Name = "TabPopravke";
            this.TabPopravke.Size = new System.Drawing.Size(792, 458);
            this.TabPopravke.TabIndex = 0;
            this.TabPopravke.Text = "Popravke";
            this.TabPopravke.VerticalScrollbarBarColor = true;
            this.TabPopravke.VerticalScrollbarHighlightOnWheel = false;
            this.TabPopravke.VerticalScrollbarSize = 10;
            // 
            // btnDelovi
            // 
            this.btnDelovi.Location = new System.Drawing.Point(384, 429);
            this.btnDelovi.Name = "btnDelovi";
            this.btnDelovi.Size = new System.Drawing.Size(96, 23);
            this.btnDelovi.TabIndex = 8;
            this.btnDelovi.Text = "Delovi";
            this.btnDelovi.UseSelectable = true;
            this.btnDelovi.Click += new System.EventHandler(this.btnDelovi_Click);
            // 
            // btnPopravka
            // 
            this.btnPopravka.Location = new System.Drawing.Point(486, 429);
            this.btnPopravka.Name = "btnPopravka";
            this.btnPopravka.Size = new System.Drawing.Size(96, 23);
            this.btnPopravka.TabIndex = 7;
            this.btnPopravka.Text = "Popravka";
            this.btnPopravka.UseSelectable = true;
            this.btnPopravka.Click += new System.EventHandler(this.btnPopravka_Click);
            // 
            // gridPopravke
            // 
            this.gridPopravke.AllowUserToResizeRows = false;
            this.gridPopravke.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPopravke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPopravke.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPopravke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPopravke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPopravke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPopravke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPopravke.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPopravke.EnableHeadersVisualStyles = false;
            this.gridPopravke.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPopravke.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPopravke.Location = new System.Drawing.Point(3, 54);
            this.gridPopravke.Name = "gridPopravke";
            this.gridPopravke.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPopravke.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPopravke.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPopravke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPopravke.Size = new System.Drawing.Size(786, 369);
            this.gridPopravke.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(746, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtPretragaPopravke
            // 
            // 
            // 
            // 
            this.txtPretragaPopravke.CustomButton.Image = null;
            this.txtPretragaPopravke.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtPretragaPopravke.CustomButton.Name = "";
            this.txtPretragaPopravke.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPretragaPopravke.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPretragaPopravke.CustomButton.TabIndex = 1;
            this.txtPretragaPopravke.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPretragaPopravke.CustomButton.UseSelectable = true;
            this.txtPretragaPopravke.CustomButton.Visible = false;
            this.txtPretragaPopravke.Lines = new string[0];
            this.txtPretragaPopravke.Location = new System.Drawing.Point(594, 15);
            this.txtPretragaPopravke.MaxLength = 32767;
            this.txtPretragaPopravke.Name = "txtPretragaPopravke";
            this.txtPretragaPopravke.PasswordChar = '\0';
            this.txtPretragaPopravke.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPretragaPopravke.SelectedText = "";
            this.txtPretragaPopravke.SelectionLength = 0;
            this.txtPretragaPopravke.SelectionStart = 0;
            this.txtPretragaPopravke.ShortcutsEnabled = true;
            this.txtPretragaPopravke.Size = new System.Drawing.Size(146, 23);
            this.txtPretragaPopravke.TabIndex = 4;
            this.txtPretragaPopravke.UseSelectable = true;
            this.txtPretragaPopravke.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPretragaPopravke.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(591, 429);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Profil";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnDodajKvar
            // 
            this.btnDodajKvar.Location = new System.Drawing.Point(693, 429);
            this.btnDodajKvar.Name = "btnDodajKvar";
            this.btnDodajKvar.Size = new System.Drawing.Size(96, 23);
            this.btnDodajKvar.TabIndex = 2;
            this.btnDodajKvar.Text = "Dodaj kvar";
            this.btnDodajKvar.UseSelectable = true;
            this.btnDodajKvar.Click += new System.EventHandler(this.btnDodajKvar_Click);
            // 
            // tabZaposleni
            // 
            this.tabZaposleni.Controls.Add(this.gridZaposleni);
            this.tabZaposleni.Controls.Add(this.txtPretragaZaposleni);
            this.tabZaposleni.Controls.Add(this.pictureBox3);
            this.tabZaposleni.HorizontalScrollbarBarColor = true;
            this.tabZaposleni.HorizontalScrollbarHighlightOnWheel = false;
            this.tabZaposleni.HorizontalScrollbarSize = 10;
            this.tabZaposleni.Location = new System.Drawing.Point(4, 38);
            this.tabZaposleni.Name = "tabZaposleni";
            this.tabZaposleni.Size = new System.Drawing.Size(792, 458);
            this.tabZaposleni.TabIndex = 1;
            this.tabZaposleni.Text = "Zaposleni";
            this.tabZaposleni.VerticalScrollbarBarColor = true;
            this.tabZaposleni.VerticalScrollbarHighlightOnWheel = false;
            this.tabZaposleni.VerticalScrollbarSize = 10;
            // 
            // gridZaposleni
            // 
            this.gridZaposleni.AllowUserToResizeRows = false;
            this.gridZaposleni.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridZaposleni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridZaposleni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridZaposleni.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridZaposleni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridZaposleni.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridZaposleni.EnableHeadersVisualStyles = false;
            this.gridZaposleni.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridZaposleni.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridZaposleni.Location = new System.Drawing.Point(3, 54);
            this.gridZaposleni.Name = "gridZaposleni";
            this.gridZaposleni.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridZaposleni.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridZaposleni.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridZaposleni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridZaposleni.Size = new System.Drawing.Size(786, 369);
            this.gridZaposleni.TabIndex = 9;
            // 
            // txtPretragaZaposleni
            // 
            // 
            // 
            // 
            this.txtPretragaZaposleni.CustomButton.Image = null;
            this.txtPretragaZaposleni.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtPretragaZaposleni.CustomButton.Name = "";
            this.txtPretragaZaposleni.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPretragaZaposleni.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPretragaZaposleni.CustomButton.TabIndex = 1;
            this.txtPretragaZaposleni.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPretragaZaposleni.CustomButton.UseSelectable = true;
            this.txtPretragaZaposleni.CustomButton.Visible = false;
            this.txtPretragaZaposleni.Lines = new string[0];
            this.txtPretragaZaposleni.Location = new System.Drawing.Point(594, 15);
            this.txtPretragaZaposleni.MaxLength = 32767;
            this.txtPretragaZaposleni.Name = "txtPretragaZaposleni";
            this.txtPretragaZaposleni.PasswordChar = '\0';
            this.txtPretragaZaposleni.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPretragaZaposleni.SelectedText = "";
            this.txtPretragaZaposleni.SelectionLength = 0;
            this.txtPretragaZaposleni.SelectionStart = 0;
            this.txtPretragaZaposleni.ShortcutsEnabled = true;
            this.txtPretragaZaposleni.Size = new System.Drawing.Size(146, 23);
            this.txtPretragaZaposleni.TabIndex = 7;
            this.txtPretragaZaposleni.UseSelectable = true;
            this.txtPretragaZaposleni.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPretragaZaposleni.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(746, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 33);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // tabModeli
            // 
            this.tabModeli.Controls.Add(this.gridModeli);
            this.tabModeli.Controls.Add(this.pictureBox4);
            this.tabModeli.Controls.Add(this.txtPretragaModeli);
            this.tabModeli.HorizontalScrollbarBarColor = true;
            this.tabModeli.HorizontalScrollbarHighlightOnWheel = false;
            this.tabModeli.HorizontalScrollbarSize = 10;
            this.tabModeli.Location = new System.Drawing.Point(4, 38);
            this.tabModeli.Name = "tabModeli";
            this.tabModeli.Size = new System.Drawing.Size(792, 458);
            this.tabModeli.TabIndex = 2;
            this.tabModeli.Text = "Modeli vozila";
            this.tabModeli.VerticalScrollbarBarColor = true;
            this.tabModeli.VerticalScrollbarHighlightOnWheel = false;
            this.tabModeli.VerticalScrollbarSize = 10;
            // 
            // gridModeli
            // 
            this.gridModeli.AllowUserToResizeRows = false;
            this.gridModeli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridModeli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridModeli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridModeli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridModeli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridModeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridModeli.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridModeli.EnableHeadersVisualStyles = false;
            this.gridModeli.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridModeli.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridModeli.Location = new System.Drawing.Point(3, 53);
            this.gridModeli.Name = "gridModeli";
            this.gridModeli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridModeli.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridModeli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridModeli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridModeli.Size = new System.Drawing.Size(786, 369);
            this.gridModeli.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(746, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 33);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // txtPretragaModeli
            // 
            // 
            // 
            // 
            this.txtPretragaModeli.CustomButton.Image = null;
            this.txtPretragaModeli.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtPretragaModeli.CustomButton.Name = "";
            this.txtPretragaModeli.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPretragaModeli.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPretragaModeli.CustomButton.TabIndex = 1;
            this.txtPretragaModeli.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPretragaModeli.CustomButton.UseSelectable = true;
            this.txtPretragaModeli.CustomButton.Visible = false;
            this.txtPretragaModeli.Lines = new string[0];
            this.txtPretragaModeli.Location = new System.Drawing.Point(594, 14);
            this.txtPretragaModeli.MaxLength = 32767;
            this.txtPretragaModeli.Name = "txtPretragaModeli";
            this.txtPretragaModeli.PasswordChar = '\0';
            this.txtPretragaModeli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPretragaModeli.SelectedText = "";
            this.txtPretragaModeli.SelectionLength = 0;
            this.txtPretragaModeli.SelectionStart = 0;
            this.txtPretragaModeli.ShortcutsEnabled = true;
            this.txtPretragaModeli.Size = new System.Drawing.Size(146, 23);
            this.txtPretragaModeli.TabIndex = 7;
            this.txtPretragaModeli.UseSelectable = true;
            this.txtPretragaModeli.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPretragaModeli.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUlogujSe
            // 
            this.btnUlogujSe.Location = new System.Drawing.Point(557, 63);
            this.btnUlogujSe.Name = "btnUlogujSe";
            this.btnUlogujSe.Size = new System.Drawing.Size(121, 23);
            this.btnUlogujSe.TabIndex = 2;
            this.btnUlogujSe.Text = "Uloguj se";
            this.btnUlogujSe.UseSelectable = true;
            this.btnUlogujSe.Click += new System.EventHandler(this.btnUlogujSe_Click);
            // 
            // btnKreirajNalog
            // 
            this.btnKreirajNalog.Location = new System.Drawing.Point(684, 64);
            this.btnKreirajNalog.Name = "btnKreirajNalog";
            this.btnKreirajNalog.Size = new System.Drawing.Size(121, 23);
            this.btnKreirajNalog.TabIndex = 3;
            this.btnKreirajNalog.Text = "Kreiraj nalog";
            this.btnKreirajNalog.UseSelectable = true;
            this.btnKreirajNalog.Click += new System.EventHandler(this.btnKreirajNalog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 53);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 595);
            this.Controls.Add(this.btnKreirajNalog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnUlogujSe);
            this.Name = "Pocetna";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.TabPopravke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPopravke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabZaposleni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridZaposleni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabModeli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridModeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TabPopravke;
        private MetroFramework.Controls.MetroTabPage tabZaposleni;
        private MetroFramework.Controls.MetroTabPage tabModeli;
        private MetroFramework.Controls.MetroButton btnDodajKvar;
        private MetroFramework.Controls.MetroButton btnUlogujSe;
        private MetroFramework.Controls.MetroButton btnKreirajNalog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid gridPopravke;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox txtPretragaPopravke;
        private MetroFramework.Controls.MetroGrid gridZaposleni;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroTextBox txtPretragaZaposleni;
        private MetroFramework.Controls.MetroGrid gridModeli;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroTextBox txtPretragaModeli;
        private MetroFramework.Controls.MetroButton btnDelovi;
        private MetroFramework.Controls.MetroButton btnPopravka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}