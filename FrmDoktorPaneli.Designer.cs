namespace HastaneProjesi
{
    partial class FrmDoktorPaneli
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnDoktorEkle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDoktorGuncelle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDoktorSil = new Guna.UI2.WinForms.Guna2GradientButton();
            this.kapat = new Guna.UI2.WinForms.Guna2ControlBox();
            this.altaAl = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtDoktorPanelSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBrans = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDoktorPanelSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDoktorPanelTc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDoktorPanelAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDoktor = new System.Windows.Forms.DataGridView();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoktor)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.lbid);
            this.guna2GradientPanel1.Controls.Add(this.label7);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientButton1);
            this.guna2GradientPanel1.Controls.Add(this.dataDoktor);
            this.guna2GradientPanel1.Controls.Add(this.btnDoktorEkle);
            this.guna2GradientPanel1.Controls.Add(this.btnDoktorGuncelle);
            this.guna2GradientPanel1.Controls.Add(this.btnDoktorSil);
            this.guna2GradientPanel1.Controls.Add(this.kapat);
            this.guna2GradientPanel1.Controls.Add(this.altaAl);
            this.guna2GradientPanel1.Controls.Add(this.txtDoktorPanelSoyad);
            this.guna2GradientPanel1.Controls.Add(this.comboBrans);
            this.guna2GradientPanel1.Controls.Add(this.txtDoktorPanelSifre);
            this.guna2GradientPanel1.Controls.Add(this.txtDoktorPanelTc);
            this.guna2GradientPanel1.Controls.Add(this.txtDoktorPanelAd);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.guna2GradientPanel1.TabIndex = 0;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Animated = true;
            this.btnDoktorEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnDoktorEkle.BorderRadius = 2;
            this.btnDoktorEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoktorEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoktorEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoktorEkle.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoktorEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoktorEkle.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDoktorEkle.FillColor2 = System.Drawing.Color.DarkCyan;
            this.btnDoktorEkle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDoktorEkle.ForeColor = System.Drawing.Color.White;
            this.btnDoktorEkle.Location = new System.Drawing.Point(122, 354);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(88, 41);
            this.btnDoktorEkle.TabIndex = 56;
            this.btnDoktorEkle.Text = "Ekle";
            this.btnDoktorEkle.UseTransparentBackground = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.Animated = true;
            this.btnDoktorGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnDoktorGuncelle.BorderRadius = 2;
            this.btnDoktorGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoktorGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoktorGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoktorGuncelle.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoktorGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoktorGuncelle.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDoktorGuncelle.FillColor2 = System.Drawing.Color.DarkCyan;
            this.btnDoktorGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDoktorGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(122, 401);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(208, 41);
            this.btnDoktorGuncelle.TabIndex = 66;
            this.btnDoktorGuncelle.Text = "Güncelle";
            this.btnDoktorGuncelle.UseTransparentBackground = true;
            this.btnDoktorGuncelle.Click += new System.EventHandler(this.btnDoktorGuncelle_Click);
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.Animated = true;
            this.btnDoktorSil.BackColor = System.Drawing.Color.Transparent;
            this.btnDoktorSil.BorderRadius = 2;
            this.btnDoktorSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoktorSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoktorSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoktorSil.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoktorSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoktorSil.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDoktorSil.FillColor2 = System.Drawing.Color.DarkCyan;
            this.btnDoktorSil.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDoktorSil.ForeColor = System.Drawing.Color.White;
            this.btnDoktorSil.Location = new System.Drawing.Point(245, 354);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(85, 41);
            this.btnDoktorSil.TabIndex = 65;
            this.btnDoktorSil.Text = "Sil";
            this.btnDoktorSil.UseTransparentBackground = true;
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // kapat
            // 
            this.kapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kapat.BackColor = System.Drawing.Color.Transparent;
            this.kapat.FillColor = System.Drawing.Color.Transparent;
            this.kapat.IconColor = System.Drawing.Color.White;
            this.kapat.Location = new System.Drawing.Point(768, 9);
            this.kapat.Margin = new System.Windows.Forms.Padding(5);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(25, 24);
            this.kapat.TabIndex = 62;
            this.kapat.UseTransparentBackground = true;
            // 
            // altaAl
            // 
            this.altaAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.altaAl.BackColor = System.Drawing.Color.Transparent;
            this.altaAl.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.altaAl.FillColor = System.Drawing.Color.Transparent;
            this.altaAl.IconColor = System.Drawing.Color.White;
            this.altaAl.Location = new System.Drawing.Point(734, 9);
            this.altaAl.Margin = new System.Windows.Forms.Padding(5);
            this.altaAl.Name = "altaAl";
            this.altaAl.Size = new System.Drawing.Size(25, 24);
            this.altaAl.TabIndex = 63;
            this.altaAl.UseTransparentBackground = true;
            // 
            // txtDoktorPanelSoyad
            // 
            this.txtDoktorPanelSoyad.Animated = true;
            this.txtDoktorPanelSoyad.BackColor = System.Drawing.Color.Transparent;
            this.txtDoktorPanelSoyad.BorderRadius = 6;
            this.txtDoktorPanelSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoktorPanelSoyad.DefaultText = "";
            this.txtDoktorPanelSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoktorPanelSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoktorPanelSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorPanelSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorPanelSoyad.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDoktorPanelSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorPanelSoyad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDoktorPanelSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtDoktorPanelSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorPanelSoyad.Location = new System.Drawing.Point(160, 120);
            this.txtDoktorPanelSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoktorPanelSoyad.MaxLength = 10;
            this.txtDoktorPanelSoyad.Name = "txtDoktorPanelSoyad";
            this.txtDoktorPanelSoyad.PasswordChar = '\0';
            this.txtDoktorPanelSoyad.PlaceholderText = "";
            this.txtDoktorPanelSoyad.SelectedText = "";
            this.txtDoktorPanelSoyad.Size = new System.Drawing.Size(170, 41);
            this.txtDoktorPanelSoyad.TabIndex = 52;
            this.txtDoktorPanelSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoktorPanelSoyad_KeyPress);
            // 
            // comboBrans
            // 
            this.comboBrans.BackColor = System.Drawing.Color.Transparent;
            this.comboBrans.BorderRadius = 6;
            this.comboBrans.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBrans.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comboBrans.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBrans.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBrans.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboBrans.ForeColor = System.Drawing.Color.Black;
            this.comboBrans.ItemHeight = 30;
            this.comboBrans.Location = new System.Drawing.Point(160, 300);
            this.comboBrans.Name = "comboBrans";
            this.comboBrans.Size = new System.Drawing.Size(170, 36);
            this.comboBrans.TabIndex = 55;
            // 
            // txtDoktorPanelSifre
            // 
            this.txtDoktorPanelSifre.Animated = true;
            this.txtDoktorPanelSifre.BackColor = System.Drawing.Color.Transparent;
            this.txtDoktorPanelSifre.BorderRadius = 6;
            this.txtDoktorPanelSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoktorPanelSifre.DefaultText = "";
            this.txtDoktorPanelSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoktorPanelSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoktorPanelSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorPanelSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorPanelSifre.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDoktorPanelSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorPanelSifre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorPanelSifre.ForeColor = System.Drawing.Color.Black;
            this.txtDoktorPanelSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorPanelSifre.Location = new System.Drawing.Point(160, 239);
            this.txtDoktorPanelSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoktorPanelSifre.MaxLength = 5;
            this.txtDoktorPanelSifre.Name = "txtDoktorPanelSifre";
            this.txtDoktorPanelSifre.PasswordChar = '\0';
            this.txtDoktorPanelSifre.PlaceholderText = "";
            this.txtDoktorPanelSifre.SelectedText = "";
            this.txtDoktorPanelSifre.Size = new System.Drawing.Size(170, 41);
            this.txtDoktorPanelSifre.TabIndex = 54;
            // 
            // txtDoktorPanelTc
            // 
            this.txtDoktorPanelTc.Animated = true;
            this.txtDoktorPanelTc.BackColor = System.Drawing.Color.Transparent;
            this.txtDoktorPanelTc.BorderRadius = 6;
            this.txtDoktorPanelTc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoktorPanelTc.DefaultText = "";
            this.txtDoktorPanelTc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoktorPanelTc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoktorPanelTc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorPanelTc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorPanelTc.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDoktorPanelTc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorPanelTc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDoktorPanelTc.ForeColor = System.Drawing.Color.Black;
            this.txtDoktorPanelTc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorPanelTc.Location = new System.Drawing.Point(160, 179);
            this.txtDoktorPanelTc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoktorPanelTc.MaxLength = 11;
            this.txtDoktorPanelTc.Name = "txtDoktorPanelTc";
            this.txtDoktorPanelTc.PasswordChar = '\0';
            this.txtDoktorPanelTc.PlaceholderText = "";
            this.txtDoktorPanelTc.SelectedText = "";
            this.txtDoktorPanelTc.Size = new System.Drawing.Size(170, 41);
            this.txtDoktorPanelTc.TabIndex = 53;
            this.txtDoktorPanelTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoktorPanelTc_KeyPress);
            // 
            // txtDoktorPanelAd
            // 
            this.txtDoktorPanelAd.Animated = true;
            this.txtDoktorPanelAd.BackColor = System.Drawing.Color.Transparent;
            this.txtDoktorPanelAd.BorderRadius = 6;
            this.txtDoktorPanelAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoktorPanelAd.DefaultText = "";
            this.txtDoktorPanelAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoktorPanelAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoktorPanelAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorPanelAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorPanelAd.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDoktorPanelAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorPanelAd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDoktorPanelAd.ForeColor = System.Drawing.Color.Black;
            this.txtDoktorPanelAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorPanelAd.Location = new System.Drawing.Point(160, 59);
            this.txtDoktorPanelAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoktorPanelAd.MaxLength = 10;
            this.txtDoktorPanelAd.Name = "txtDoktorPanelAd";
            this.txtDoktorPanelAd.PasswordChar = '\0';
            this.txtDoktorPanelAd.PlaceholderText = "";
            this.txtDoktorPanelAd.SelectedText = "";
            this.txtDoktorPanelAd.Size = new System.Drawing.Size(170, 41);
            this.txtDoktorPanelAd.TabIndex = 51;
            this.txtDoktorPanelAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoktorPanelAd_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(80, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 61;
            this.label5.Text = "Branş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(93, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 60;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(14, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 59;
            this.label3.Text = "T.C. Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(72, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 58;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(104, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 57;
            this.label1.Text = "Ad";
            // 
            // dataDoktor
            // 
            this.dataDoktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDoktor.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataDoktor.Location = new System.Drawing.Point(357, 59);
            this.dataDoktor.Name = "dataDoktor";
            this.dataDoktor.Size = new System.Drawing.Size(431, 336);
            this.dataDoktor.TabIndex = 67;
            this.dataDoktor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDoktor_CellDoubleClick);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 2;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.DarkCyan;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(357, 18);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(88, 41);
            this.guna2GradientButton1.TabIndex = 68;
            this.guna2GradientButton1.Text = "Yenile";
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(362, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 22);
            this.label7.TabIndex = 70;
            this.label7.Text = "ID:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.BackColor = System.Drawing.Color.Transparent;
            this.lbid.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbid.ForeColor = System.Drawing.Color.Snow;
            this.lbid.Location = new System.Drawing.Point(402, 401);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(0, 22);
            this.lbid.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoktorPaneli";
            this.Text = "FrmDoktorPaneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoktor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnDoktorGuncelle;
        private Guna.UI2.WinForms.Guna2GradientButton btnDoktorSil;
        private Guna.UI2.WinForms.Guna2ControlBox kapat;
        private Guna.UI2.WinForms.Guna2ControlBox altaAl;
        private Guna.UI2.WinForms.Guna2TextBox txtDoktorPanelSoyad;
        private Guna.UI2.WinForms.Guna2GradientButton btnDoktorEkle;
        private Guna.UI2.WinForms.Guna2ComboBox comboBrans;
        private Guna.UI2.WinForms.Guna2TextBox txtDoktorPanelSifre;
        private Guna.UI2.WinForms.Guna2TextBox txtDoktorPanelTc;
        private Guna.UI2.WinForms.Guna2TextBox txtDoktorPanelAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataDoktor;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label label6;
    }
}