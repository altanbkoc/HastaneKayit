namespace HastaneProjesi
{
    partial class FrmRandevuListesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuListesi));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.kapat = new Guna.UI2.WinForms.Guna2ControlBox();
            this.altaAl = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataRandevu = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // kapat
            // 
            this.kapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kapat.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.kapat, BunifuAnimatorNS.DecorationType.None);
            this.kapat.FillColor = System.Drawing.Color.Transparent;
            this.kapat.IconColor = System.Drawing.Color.White;
            this.kapat.Location = new System.Drawing.Point(671, 5);
            this.kapat.Margin = new System.Windows.Forms.Padding(5);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(25, 24);
            this.kapat.TabIndex = 75;
            this.kapat.UseTransparentBackground = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // altaAl
            // 
            this.altaAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.altaAl.BackColor = System.Drawing.Color.Transparent;
            this.altaAl.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.bunifuTransition1.SetDecoration(this.altaAl, BunifuAnimatorNS.DecorationType.None);
            this.altaAl.FillColor = System.Drawing.Color.Transparent;
            this.altaAl.IconColor = System.Drawing.Color.White;
            this.altaAl.Location = new System.Drawing.Point(637, 5);
            this.altaAl.Margin = new System.Windows.Forms.Padding(5);
            this.altaAl.Name = "altaAl";
            this.altaAl.Size = new System.Drawing.Size(25, 24);
            this.altaAl.TabIndex = 76;
            this.altaAl.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dataRandevu);
            this.bunifuTransition1.SetDecoration(this.guna2Panel1, BunifuAnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 37);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(710, 383);
            this.guna2Panel1.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 78;
            this.label1.Text = "Randevu Listesi";
            // 
            // dataRandevu
            // 
            this.dataRandevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition1.SetDecoration(this.dataRandevu, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRandevu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRandevu.Location = new System.Drawing.Point(0, 0);
            this.dataRandevu.Name = "dataRandevu";
            this.dataRandevu.Size = new System.Drawing.Size(710, 383);
            this.dataRandevu.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // FrmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(710, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.altaAl);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRandevuListesi";
            this.Text = "FrmRandevuListesi";
            this.Load += new System.EventHandler(this.FrmRandevuListesi_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRandevu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox kapat;
        private Guna.UI2.WinForms.Guna2ControlBox altaAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataRandevu;
        private System.Windows.Forms.Timer timer1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}