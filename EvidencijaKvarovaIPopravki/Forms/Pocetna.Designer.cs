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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TabPopravke = new MetroFramework.Controls.MetroTabPage();
            this.gridPopravke = new MetroFramework.Controls.MetroGrid();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPretragaPopravke = new MetroFramework.Controls.MetroTextBox();
            this.tabRadionice = new MetroFramework.Controls.MetroTabPage();
            this.gridRadionice = new MetroFramework.Controls.MetroGrid();
            this.txtPretragaRadionica = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRadionica = new MetroFramework.Controls.MetroButton();
            this.btnProfil = new MetroFramework.Controls.MetroButton();
            this.btnUlogujSe = new MetroFramework.Controls.MetroButton();
            this.btnKreirajNalog = new MetroFramework.Controls.MetroButton();
            this.btnPrijaviKvar = new MetroFramework.Controls.MetroButton();
            this.btnOdjaviSe = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1.SuspendLayout();
            this.TabPopravke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopravke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabRadionice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRadionice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.metroTabControl1.Controls.Add(this.tabRadionice);
            this.metroTabControl1.Location = new System.Drawing.Point(22, 93);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 500);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // TabPopravke
            // 
            this.TabPopravke.Controls.Add(this.gridPopravke);
            this.TabPopravke.Controls.Add(this.pictureBox2);
            this.TabPopravke.Controls.Add(this.txtPretragaPopravke);
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
            // gridPopravke
            // 
            this.gridPopravke.AllowUserToResizeRows = false;
            this.gridPopravke.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPopravke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPopravke.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPopravke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPopravke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridPopravke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPopravke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPopravke.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridPopravke.EnableHeadersVisualStyles = false;
            this.gridPopravke.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPopravke.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPopravke.Location = new System.Drawing.Point(3, 54);
            this.gridPopravke.Name = "gridPopravke";
            this.gridPopravke.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPopravke.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridPopravke.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPopravke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPopravke.Size = new System.Drawing.Size(737, 369);
            this.gridPopravke.TabIndex = 6;
            this.gridPopravke.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPopravke_CellContentDoubleClick);
            this.gridPopravke.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPopravke_CellDoubleClick);
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
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
            // tabRadionice
            // 
            this.tabRadionice.Controls.Add(this.gridRadionice);
            this.tabRadionice.Controls.Add(this.txtPretragaRadionica);
            this.tabRadionice.Controls.Add(this.pictureBox3);
            this.tabRadionice.HorizontalScrollbarBarColor = true;
            this.tabRadionice.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRadionice.HorizontalScrollbarSize = 10;
            this.tabRadionice.Location = new System.Drawing.Point(4, 38);
            this.tabRadionice.Name = "tabRadionice";
            this.tabRadionice.Size = new System.Drawing.Size(792, 458);
            this.tabRadionice.TabIndex = 1;
            this.tabRadionice.Text = "Radionice";
            this.tabRadionice.VerticalScrollbarBarColor = true;
            this.tabRadionice.VerticalScrollbarHighlightOnWheel = false;
            this.tabRadionice.VerticalScrollbarSize = 10;
            // 
            // gridRadionice
            // 
            this.gridRadionice.AllowUserToResizeRows = false;
            this.gridRadionice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRadionice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRadionice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridRadionice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRadionice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridRadionice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRadionice.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridRadionice.EnableHeadersVisualStyles = false;
            this.gridRadionice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridRadionice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRadionice.Location = new System.Drawing.Point(3, 54);
            this.gridRadionice.Name = "gridRadionice";
            this.gridRadionice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRadionice.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridRadionice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridRadionice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRadionice.Size = new System.Drawing.Size(737, 369);
            this.gridRadionice.TabIndex = 9;
            this.gridRadionice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRadionice_CellDoubleClick);
            // 
            // txtPretragaRadionica
            // 
            // 
            // 
            // 
            this.txtPretragaRadionica.CustomButton.Image = null;
            this.txtPretragaRadionica.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtPretragaRadionica.CustomButton.Name = "";
            this.txtPretragaRadionica.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPretragaRadionica.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPretragaRadionica.CustomButton.TabIndex = 1;
            this.txtPretragaRadionica.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPretragaRadionica.CustomButton.UseSelectable = true;
            this.txtPretragaRadionica.CustomButton.Visible = false;
            this.txtPretragaRadionica.Lines = new string[0];
            this.txtPretragaRadionica.Location = new System.Drawing.Point(594, 15);
            this.txtPretragaRadionica.MaxLength = 32767;
            this.txtPretragaRadionica.Name = "txtPretragaRadionica";
            this.txtPretragaRadionica.PasswordChar = '\0';
            this.txtPretragaRadionica.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPretragaRadionica.SelectedText = "";
            this.txtPretragaRadionica.SelectionLength = 0;
            this.txtPretragaRadionica.SelectionStart = 0;
            this.txtPretragaRadionica.ShortcutsEnabled = true;
            this.txtPretragaRadionica.Size = new System.Drawing.Size(146, 23);
            this.txtPretragaRadionica.TabIndex = 7;
            this.txtPretragaRadionica.UseSelectable = true;
            this.txtPretragaRadionica.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPretragaRadionica.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // btnRadionica
            // 
            this.btnRadionica.Location = new System.Drawing.Point(701, 599);
            this.btnRadionica.Name = "btnRadionica";
            this.btnRadionica.Size = new System.Drawing.Size(96, 23);
            this.btnRadionica.TabIndex = 9;
            this.btnRadionica.Text = "Radionica";
            this.btnRadionica.UseSelectable = true;
            this.btnRadionica.Click += new System.EventHandler(this.btnRadionica_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(574, 36);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(121, 23);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseSelectable = true;
            this.btnProfil.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnUlogujSe
            // 
            this.btnUlogujSe.Location = new System.Drawing.Point(574, 37);
            this.btnUlogujSe.Name = "btnUlogujSe";
            this.btnUlogujSe.Size = new System.Drawing.Size(121, 23);
            this.btnUlogujSe.TabIndex = 2;
            this.btnUlogujSe.Text = "Uloguj se";
            this.btnUlogujSe.UseSelectable = true;
            this.btnUlogujSe.Click += new System.EventHandler(this.btnUlogujSe_Click);
            // 
            // btnKreirajNalog
            // 
            this.btnKreirajNalog.Location = new System.Drawing.Point(701, 36);
            this.btnKreirajNalog.Name = "btnKreirajNalog";
            this.btnKreirajNalog.Size = new System.Drawing.Size(121, 23);
            this.btnKreirajNalog.TabIndex = 3;
            this.btnKreirajNalog.Text = "Kreiraj nalog";
            this.btnKreirajNalog.UseSelectable = true;
            this.btnKreirajNalog.Click += new System.EventHandler(this.btnKreirajNalog_Click);
            // 
            // btnPrijaviKvar
            // 
            this.btnPrijaviKvar.Location = new System.Drawing.Point(701, 66);
            this.btnPrijaviKvar.Name = "btnPrijaviKvar";
            this.btnPrijaviKvar.Size = new System.Drawing.Size(121, 23);
            this.btnPrijaviKvar.TabIndex = 10;
            this.btnPrijaviKvar.Text = "Prijavi kvar";
            this.btnPrijaviKvar.UseSelectable = true;
            this.btnPrijaviKvar.Click += new System.EventHandler(this.btnPrijaviKvar_Click);
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.Location = new System.Drawing.Point(701, 37);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(121, 23);
            this.btnOdjaviSe.TabIndex = 11;
            this.btnOdjaviSe.Text = "Odjavi se";
            this.btnOdjaviSe.UseSelectable = true;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
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
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 643);
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.btnPrijaviKvar);
            this.Controls.Add(this.btnRadionica);
            this.Controls.Add(this.btnKreirajNalog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnUlogujSe);
            this.Controls.Add(this.btnProfil);
            this.Name = "Pocetna";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.TabPopravke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPopravke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabRadionice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRadionice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TabPopravke;
        private MetroFramework.Controls.MetroTabPage tabRadionice;
        private MetroFramework.Controls.MetroButton btnUlogujSe;
        private MetroFramework.Controls.MetroButton btnKreirajNalog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnProfil;
        private MetroFramework.Controls.MetroGrid gridPopravke;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox txtPretragaPopravke;
        private MetroFramework.Controls.MetroGrid gridRadionice;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroTextBox txtPretragaRadionica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private MetroFramework.Controls.MetroButton btnRadionica;
        private MetroFramework.Controls.MetroButton btnPrijaviKvar;
        private MetroFramework.Controls.MetroButton btnOdjaviSe;
    }
}