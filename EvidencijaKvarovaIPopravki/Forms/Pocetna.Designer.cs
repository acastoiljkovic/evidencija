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
            this.tabKvarovi = new MetroFramework.Controls.MetroTabControl();
            this.tabPopravke = new MetroFramework.Controls.MetroTabPage();
            this.gridPopravke = new MetroFramework.Controls.MetroGrid();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPretragaPopravke = new MetroFramework.Controls.MetroTextBox();
            this.tabRadionice = new MetroFramework.Controls.MetroTabPage();
            this.gridRadionice = new MetroFramework.Controls.MetroGrid();
            this.txtPretragaRadionica = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabNoviKvarovi = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gridNoviKvarovi = new MetroFramework.Controls.MetroGrid();
            this.btnRadionica = new MetroFramework.Controls.MetroButton();
            this.btnProfil = new MetroFramework.Controls.MetroButton();
            this.btnUlogujSe = new MetroFramework.Controls.MetroButton();
            this.btnKreirajNalog = new MetroFramework.Controls.MetroButton();
            this.btnPrijaviKvar = new MetroFramework.Controls.MetroButton();
            this.btnOdjaviSe = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabKvarovi.SuspendLayout();
            this.tabPopravke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopravke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabRadionice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRadionice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabNoviKvarovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoviKvarovi)).BeginInit();
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
            // tabKvarovi
            // 
            this.tabKvarovi.Controls.Add(this.tabPopravke);
            this.tabKvarovi.Controls.Add(this.tabRadionice);
            this.tabKvarovi.Controls.Add(this.tabNoviKvarovi);
            this.tabKvarovi.Location = new System.Drawing.Point(22, 93);
            this.tabKvarovi.Name = "tabKvarovi";
            this.tabKvarovi.SelectedIndex = 1;
            this.tabKvarovi.Size = new System.Drawing.Size(800, 500);
            this.tabKvarovi.TabIndex = 1;
            this.tabKvarovi.UseSelectable = true;
            // 
            // tabPopravke
            // 
            this.tabPopravke.Controls.Add(this.gridPopravke);
            this.tabPopravke.Controls.Add(this.pictureBox2);
            this.tabPopravke.Controls.Add(this.txtPretragaPopravke);
            this.tabPopravke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPopravke.HorizontalScrollbarBarColor = true;
            this.tabPopravke.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPopravke.HorizontalScrollbarSize = 10;
            this.tabPopravke.Location = new System.Drawing.Point(4, 38);
            this.tabPopravke.Name = "tabPopravke";
            this.tabPopravke.Size = new System.Drawing.Size(792, 458);
            this.tabPopravke.TabIndex = 0;
            this.tabPopravke.Text = "Popravke";
            this.tabPopravke.VerticalScrollbarBarColor = true;
            this.tabPopravke.VerticalScrollbarHighlightOnWheel = false;
            this.tabPopravke.VerticalScrollbarSize = 10;
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
            this.txtPretragaPopravke.TextChanged += new System.EventHandler(this.txtPretragaPopravke_TextChanged);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRadionice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridRadionice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRadionice.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridRadionice.EnableHeadersVisualStyles = false;
            this.gridRadionice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridRadionice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRadionice.Location = new System.Drawing.Point(3, 54);
            this.gridRadionice.Name = "gridRadionice";
            this.gridRadionice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRadionice.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.txtPretragaRadionica.TextChanged += new System.EventHandler(this.txtPretragaRadionica_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(746, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 33);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // tabNoviKvarovi
            // 
            this.tabNoviKvarovi.Controls.Add(this.metroTextBox1);
            this.tabNoviKvarovi.Controls.Add(this.pictureBox4);
            this.tabNoviKvarovi.Controls.Add(this.gridNoviKvarovi);
            this.tabNoviKvarovi.HorizontalScrollbarBarColor = true;
            this.tabNoviKvarovi.HorizontalScrollbarHighlightOnWheel = false;
            this.tabNoviKvarovi.HorizontalScrollbarSize = 10;
            this.tabNoviKvarovi.Location = new System.Drawing.Point(4, 38);
            this.tabNoviKvarovi.Name = "tabNoviKvarovi";
            this.tabNoviKvarovi.Size = new System.Drawing.Size(792, 458);
            this.tabNoviKvarovi.TabIndex = 2;
            this.tabNoviKvarovi.Text = "Novi Kvarovi";
            this.tabNoviKvarovi.VerticalScrollbarBarColor = true;
            this.tabNoviKvarovi.VerticalScrollbarHighlightOnWheel = false;
            this.tabNoviKvarovi.VerticalScrollbarSize = 10;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(594, 19);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(146, 23);
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(746, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 33);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // gridNoviKvarovi
            // 
            this.gridNoviKvarovi.AllowUserToResizeRows = false;
            this.gridNoviKvarovi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridNoviKvarovi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridNoviKvarovi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridNoviKvarovi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNoviKvarovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridNoviKvarovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNoviKvarovi.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridNoviKvarovi.EnableHeadersVisualStyles = false;
            this.gridNoviKvarovi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridNoviKvarovi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridNoviKvarovi.Location = new System.Drawing.Point(15, 60);
            this.gridNoviKvarovi.Name = "gridNoviKvarovi";
            this.gridNoviKvarovi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNoviKvarovi.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridNoviKvarovi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridNoviKvarovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNoviKvarovi.Size = new System.Drawing.Size(725, 351);
            this.gridNoviKvarovi.TabIndex = 2;
            this.gridNoviKvarovi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNoviKvarovi_CellDoubleClick);
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
            this.Controls.Add(this.tabKvarovi);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnUlogujSe);
            this.Controls.Add(this.btnProfil);
            this.Name = "Pocetna";
            this.Activated += new System.EventHandler(this.Pocetna_Activated);
            this.Load += new System.EventHandler(this.Pocetna_Load);
            this.tabKvarovi.ResumeLayout(false);
            this.tabPopravke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPopravke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabRadionice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRadionice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabNoviKvarovi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoviKvarovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl tabKvarovi;
        private MetroFramework.Controls.MetroTabPage tabPopravke;
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
        private MetroFramework.Controls.MetroTabPage tabNoviKvarovi;
        private MetroFramework.Controls.MetroGrid gridNoviKvarovi;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}