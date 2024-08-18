namespace HastaneProjesi
{
    partial class FrmGirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSekreter = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHasta = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDoktor = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.guna2CustomGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.guna2CustomGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSekreter);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnHasta);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnDoktor);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ControlBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Violet;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.WindowFrame;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.SystemColors.WindowFrame;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.AntiqueWhite;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(675, 357);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(487, 246);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(84, 22);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "Sekreter";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(283, 246);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(63, 22);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Hasta";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(92, 246);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(71, 22);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Doktor";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(294, 44);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Aeneis Medical";
            // 
            // btnSekreter
            // 
            this.btnSekreter.BackColor = System.Drawing.Color.Transparent;
            this.btnSekreter.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSekreter.HoverState.ImageSize = new System.Drawing.Size(125, 125);
            this.btnSekreter.Image = ((System.Drawing.Image)(resources.GetObject("btnSekreter.Image")));
            this.btnSekreter.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSekreter.ImageRotate = 0F;
            this.btnSekreter.ImageSize = new System.Drawing.Size(105, 105);
            this.btnSekreter.Location = new System.Drawing.Point(439, 91);
            this.btnSekreter.Name = "btnSekreter";
            this.btnSekreter.PressedState.ImageSize = new System.Drawing.Size(110, 110);
            this.btnSekreter.Size = new System.Drawing.Size(169, 138);
            this.btnSekreter.TabIndex = 5;
            this.btnSekreter.UseTransparentBackground = true;
            this.btnSekreter.Click += new System.EventHandler(this.btnSekreter_Click);
            // 
            // btnHasta
            // 
            this.btnHasta.BackColor = System.Drawing.Color.Transparent;
            this.btnHasta.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHasta.HoverState.ImageSize = new System.Drawing.Size(125, 125);
            this.btnHasta.Image = ((System.Drawing.Image)(resources.GetObject("btnHasta.Image")));
            this.btnHasta.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnHasta.ImageRotate = 0F;
            this.btnHasta.ImageSize = new System.Drawing.Size(110, 110);
            this.btnHasta.Location = new System.Drawing.Point(241, 95);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.PressedState.ImageSize = new System.Drawing.Size(110, 110);
            this.btnHasta.Size = new System.Drawing.Size(169, 124);
            this.btnHasta.TabIndex = 4;
            this.btnHasta.UseTransparentBackground = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackColor = System.Drawing.Color.Transparent;
            this.btnDoktor.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDoktor.HoverState.ImageSize = new System.Drawing.Size(120, 120);
            this.btnDoktor.Image = ((System.Drawing.Image)(resources.GetObject("btnDoktor.Image")));
            this.btnDoktor.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDoktor.ImageRotate = 0F;
            this.btnDoktor.ImageSize = new System.Drawing.Size(100, 100);
            this.btnDoktor.Location = new System.Drawing.Point(41, 91);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.PressedState.ImageSize = new System.Drawing.Size(110, 110);
            this.btnDoktor.Size = new System.Drawing.Size(169, 138);
            this.btnDoktor.TabIndex = 3;
            this.btnDoktor.UseTransparentBackground = true;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(570, 6);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 2;
            this.guna2ControlBox2.UseTransparentBackground = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(621, 6);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 1;
            this.guna2ControlBox1.UseTransparentBackground = true;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2CustomGradientPanel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.bunifuCustomLabel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 357);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Form1";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ImageButton btnDoktor;
        private Guna.UI2.WinForms.Guna2ImageButton btnSekreter;
        private Guna.UI2.WinForms.Guna2ImageButton btnHasta;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}

