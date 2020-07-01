namespace JualTunai
{
    partial class FrmUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUtama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBarang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKategori = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSatuan = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnJual = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKas = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sb1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sb2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbBarang = new System.Windows.Forms.ToolStripButton();
            this.tbKategori = new System.Windows.Forms.ToolStripButton();
            this.tbSatuan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbJual = new System.Windows.Forms.ToolStripButton();
            this.tbLap = new System.Windows.Forms.ToolStripButton();
            this.tbKas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbPassword = new System.Windows.Forms.ToolStripButton();
            this.tbKalkulator = new System.Windows.Forms.ToolStripButton();
            this.tbSetting = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterDataToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBarang,
            this.mnKategori,
            this.mnSatuan});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // mnBarang
            // 
            this.mnBarang.Name = "mnBarang";
            this.mnBarang.Size = new System.Drawing.Size(152, 22);
            this.mnBarang.Text = "Barang";
            this.mnBarang.Click += new System.EventHandler(this.mnBarang_Click);
            // 
            // mnKategori
            // 
            this.mnKategori.Name = "mnKategori";
            this.mnKategori.Size = new System.Drawing.Size(152, 22);
            this.mnKategori.Text = "Kategori";
            this.mnKategori.Click += new System.EventHandler(this.mnKategori_Click);
            // 
            // mnSatuan
            // 
            this.mnSatuan.Name = "mnSatuan";
            this.mnSatuan.Size = new System.Drawing.Size(152, 22);
            this.mnSatuan.Text = "Satuan";
            this.mnSatuan.Click += new System.EventHandler(this.mnSatuan_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnJual,
            this.mnLap,
            this.mnKas});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // mnJual
            // 
            this.mnJual.Name = "mnJual";
            this.mnJual.Size = new System.Drawing.Size(126, 22);
            this.mnJual.Text = "Penjualan";
            this.mnJual.Click += new System.EventHandler(this.mnJual_Click);
            // 
            // mnLap
            // 
            this.mnLap.Name = "mnLap";
            this.mnLap.Size = new System.Drawing.Size(126, 22);
            this.mnLap.Text = "Laporan";
            this.mnLap.Click += new System.EventHandler(this.mnLap_Click);
            // 
            // mnKas
            // 
            this.mnKas.Name = "mnKas";
            this.mnKas.Size = new System.Drawing.Size(126, 22);
            this.mnKas.Text = "Kas";
            this.mnKas.Click += new System.EventHandler(this.mnKas_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSetting,
            this.mnPassword,
            this.keluarToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // mnSetting
            // 
            this.mnSetting.Name = "mnSetting";
            this.mnSetting.Size = new System.Drawing.Size(155, 22);
            this.mnSetting.Text = "Pengaturan";
            this.mnSetting.Click += new System.EventHandler(this.mnSetting_Click);
            // 
            // mnPassword
            // 
            this.mnPassword.Name = "mnPassword";
            this.mnPassword.Size = new System.Drawing.Size(155, 22);
            this.mnPassword.Text = "Ganti Password";
            this.mnPassword.Click += new System.EventHandler(this.mnPassword_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sb1,
            this.sb2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(656, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sb2
            // 
            this.sb2.Name = "sb2";
            this.sb2.Size = new System.Drawing.Size(52, 17);
            this.sb2.Text = "operator";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbBarang,
            this.tbKategori,
            this.tbSatuan,
            this.toolStripSeparator2,
            this.tbJual,
            this.tbLap,
            this.tbKas,
            this.toolStripSeparator1,
            this.tbPassword,
            this.tbKalkulator,
            this.tbSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(656, 38);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbBarang
            // 
            this.tbBarang.Image = ((System.Drawing.Image)(resources.GetObject("tbBarang.Image")));
            this.tbBarang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBarang.Name = "tbBarang";
            this.tbBarang.Size = new System.Drawing.Size(48, 35);
            this.tbBarang.Text = "Barang";
            this.tbBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbBarang.Click += new System.EventHandler(this.tbBarang_Click);
            // 
            // tbKategori
            // 
            this.tbKategori.Image = ((System.Drawing.Image)(resources.GetObject("tbKategori.Image")));
            this.tbKategori.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(55, 35);
            this.tbKategori.Text = "Kategori";
            this.tbKategori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbKategori.Click += new System.EventHandler(this.tbKategori_Click);
            // 
            // tbSatuan
            // 
            this.tbSatuan.Image = ((System.Drawing.Image)(resources.GetObject("tbSatuan.Image")));
            this.tbSatuan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSatuan.Name = "tbSatuan";
            this.tbSatuan.Size = new System.Drawing.Size(47, 35);
            this.tbSatuan.Text = "Satuan";
            this.tbSatuan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbSatuan.Click += new System.EventHandler(this.tbSatuan_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tbJual
            // 
            this.tbJual.Image = ((System.Drawing.Image)(resources.GetObject("tbJual.Image")));
            this.tbJual.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbJual.Name = "tbJual";
            this.tbJual.Size = new System.Drawing.Size(63, 35);
            this.tbJual.Text = "Penjualan";
            this.tbJual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbJual.Click += new System.EventHandler(this.tbJual_Click);
            // 
            // tbLap
            // 
            this.tbLap.Image = ((System.Drawing.Image)(resources.GetObject("tbLap.Image")));
            this.tbLap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbLap.Name = "tbLap";
            this.tbLap.Size = new System.Drawing.Size(54, 35);
            this.tbLap.Text = "Laporan";
            this.tbLap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbLap.Click += new System.EventHandler(this.tbLap_Click);
            // 
            // tbKas
            // 
            this.tbKas.Image = ((System.Drawing.Image)(resources.GetObject("tbKas.Image")));
            this.tbKas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbKas.Name = "tbKas";
            this.tbKas.Size = new System.Drawing.Size(29, 35);
            this.tbKas.Text = "Kas";
            this.tbKas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbKas.Click += new System.EventHandler(this.tbKas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tbPassword
            // 
            this.tbPassword.Image = ((System.Drawing.Image)(resources.GetObject("tbPassword.Image")));
            this.tbPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(61, 35);
            this.tbPassword.Text = "Password";
            this.tbPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // tbKalkulator
            // 
            this.tbKalkulator.Image = ((System.Drawing.Image)(resources.GetObject("tbKalkulator.Image")));
            this.tbKalkulator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbKalkulator.Name = "tbKalkulator";
            this.tbKalkulator.Size = new System.Drawing.Size(64, 35);
            this.tbKalkulator.Text = "Kalkulator";
            this.tbKalkulator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbKalkulator.Click += new System.EventHandler(this.tbKalkulator_Click);
            // 
            // tbSetting
            // 
            this.tbSetting.Image = ((System.Drawing.Image)(resources.GetObject("tbSetting.Image")));
            this.tbSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSetting.Name = "tbSetting";
            this.tbSetting.Size = new System.Drawing.Size(48, 35);
            this.tbSetting.Text = "Setting";
            this.tbSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbSetting.Click += new System.EventHandler(this.tbSetting_Click);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(656, 376);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JualTunai";
            this.Load += new System.EventHandler(this.FrmUtm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnBarang;
        private System.Windows.Forms.ToolStripMenuItem mnKategori;
        private System.Windows.Forms.ToolStripMenuItem mnSatuan;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnJual;
        private System.Windows.Forms.ToolStripMenuItem mnLap;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSetting;
        private System.Windows.Forms.ToolStripMenuItem mnPassword;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sb1;
        private System.Windows.Forms.ToolStripStatusLabel sb2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbBarang;
        private System.Windows.Forms.ToolStripButton tbKategori;
        private System.Windows.Forms.ToolStripButton tbSatuan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbJual;
        private System.Windows.Forms.ToolStripButton tbSetting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbLap;
        private System.Windows.Forms.ToolStripButton tbPassword;
        private System.Windows.Forms.ToolStripButton tbKalkulator;
        private System.Windows.Forms.ToolStripButton tbKas;
        private System.Windows.Forms.ToolStripMenuItem mnKas;
    }
}