namespace JualTunai
{
    partial class FrmKas
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.txtAwal = new System.Windows.Forms.DateTimePicker();
            this.txtAkhir = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOperator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbArah = new System.Windows.Forms.ComboBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PENGELUARAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KETERANGAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPemasukan = new System.Windows.Forms.Label();
            this.lblPengeluaran = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSelisih = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.PENGELUARAN,
            this.KETERANGAN,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(12, 66);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(821, 233);
            this.dgv.TabIndex = 1;
            // 
            // btnCetak
            // 
            this.btnCetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCetak.AutoSize = true;
            this.btnCetak.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Location = new System.Drawing.Point(266, 307);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(73, 25);
            this.btnCetak.TabIndex = 2;
            this.btnCetak.Text = "Cetak (F6)";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKeluar.AutoSize = true;
            this.btnKeluar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.Location = new System.Drawing.Point(345, 307);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(88, 25);
            this.btnKeluar.TabIndex = 3;
            this.btnKeluar.Text = "Keluar (ESC)";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // txtAwal
            // 
            this.txtAwal.CustomFormat = "dd-MMM-yyyy";
            this.txtAwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtAwal.Location = new System.Drawing.Point(216, 10);
            this.txtAwal.Name = "txtAwal";
            this.txtAwal.Size = new System.Drawing.Size(119, 21);
            this.txtAwal.TabIndex = 4;
            this.txtAwal.ValueChanged += new System.EventHandler(this.txtAwal_ValueChanged);
            // 
            // txtAkhir
            // 
            this.txtAkhir.CustomFormat = "dd-MMM-yyyy";
            this.txtAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtAkhir.Location = new System.Drawing.Point(216, 39);
            this.txtAkhir.Name = "txtAkhir";
            this.txtAkhir.Size = new System.Drawing.Size(119, 21);
            this.txtAkhir.TabIndex = 5;
            this.txtAkhir.ValueChanged += new System.EventHandler(this.txtAkhir_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mulai Tangal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "S/D Tanggal";
            // 
            // txtOperator
            // 
            this.txtOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperator.FormattingEnabled = true;
            this.txtOperator.Location = new System.Drawing.Point(403, 9);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(103, 23);
            this.txtOperator.TabIndex = 8;
            this.txtOperator.SelectedIndexChanged += new System.EventHandler(this.txtOperator_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Operator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(521, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pemasukan";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 51);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cash Flow";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = " Arah";
            // 
            // cmbArah
            // 
            this.cmbArah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArah.FormattingEnabled = true;
            this.cmbArah.Location = new System.Drawing.Point(403, 37);
            this.cmbArah.Name = "cmbArah";
            this.cmbArah.Size = new System.Drawing.Size(103, 23);
            this.cmbArah.TabIndex = 15;
            this.cmbArah.SelectedIndexChanged += new System.EventHandler(this.cmbArah_SelectedIndexChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHapus.AutoSize = true;
            this.btnHapus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(182, 307);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(78, 25);
            this.btnHapus.TabIndex = 19;
            this.btnHapus.Text = "Hapus (F8)";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUbah.AutoSize = true;
            this.btnUbah.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.Location = new System.Drawing.Point(104, 307);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(72, 25);
            this.btnUbah.TabIndex = 18;
            this.btnUbah.Text = "Ubah (F7)";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTambah.AutoSize = true;
            this.btnTambah.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(10, 307);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(88, 25);
            this.btnTambah.TabIndex = 17;
            this.btnTambah.Text = "Tambah (F2)";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NO";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FAKTUR";
            this.Column2.Name = "Column2";
            this.Column2.Width = 79;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TANGGAL";
            this.Column3.Name = "Column3";
            this.Column3.Width = 87;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "JENIS";
            this.Column5.Name = "Column5";
            this.Column5.Width = 66;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "KATEGORI";
            this.Column6.Name = "Column6";
            this.Column6.Width = 92;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "PEMASUKAN";
            this.Column7.Name = "Column7";
            this.Column7.Width = 107;
            // 
            // PENGELUARAN
            // 
            this.PENGELUARAN.HeaderText = "PENGELUARAN";
            this.PENGELUARAN.Name = "PENGELUARAN";
            this.PENGELUARAN.Width = 122;
            // 
            // KETERANGAN
            // 
            this.KETERANGAN.HeaderText = "KETERANGAN";
            this.KETERANGAN.Name = "KETERANGAN";
            this.KETERANGAN.Width = 113;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "OPERATOR";
            this.Column4.Name = "Column4";
            this.Column4.Width = 98;
            // 
            // lblPemasukan
            // 
            this.lblPemasukan.AutoSize = true;
            this.lblPemasukan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPemasukan.ForeColor = System.Drawing.Color.Blue;
            this.lblPemasukan.Location = new System.Drawing.Point(600, 9);
            this.lblPemasukan.Name = "lblPemasukan";
            this.lblPemasukan.Size = new System.Drawing.Size(56, 13);
            this.lblPemasukan.TabIndex = 20;
            this.lblPemasukan.Text = "Grandtotal";
            // 
            // lblPengeluaran
            // 
            this.lblPengeluaran.AutoSize = true;
            this.lblPengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPengeluaran.ForeColor = System.Drawing.Color.Blue;
            this.lblPengeluaran.Location = new System.Drawing.Point(600, 24);
            this.lblPengeluaran.Name = "lblPengeluaran";
            this.lblPengeluaran.Size = new System.Drawing.Size(56, 13);
            this.lblPengeluaran.TabIndex = 22;
            this.lblPengeluaran.Text = "Grandtotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(521, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Pengeluaran";
            // 
            // lblSelisih
            // 
            this.lblSelisih.AutoSize = true;
            this.lblSelisih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelisih.ForeColor = System.Drawing.Color.Blue;
            this.lblSelisih.Location = new System.Drawing.Point(600, 39);
            this.lblSelisih.Name = "lblSelisih";
            this.lblSelisih.Size = new System.Drawing.Size(56, 13);
            this.lblSelisih.TabIndex = 24;
            this.lblSelisih.Text = "Grandtotal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(521, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Selisih";
            // 
            // FrmKas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(845, 344);
            this.Controls.Add(this.lblSelisih);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPengeluaran);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPemasukan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbArah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAkhir);
            this.Controls.Add(this.txtAwal);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.dgv);
            this.KeyPreview = true;
            this.Name = "FrmKas";
            this.Text = "Form Kas";
            this.Load += new System.EventHandler(this.FrmLaporan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLap_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.DateTimePicker txtAwal;
        private System.Windows.Forms.DateTimePicker txtAkhir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtOperator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbArah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn PENGELUARAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KETERANGAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblPemasukan;
        private System.Windows.Forms.Label lblPengeluaran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSelisih;
        private System.Windows.Forms.Label label10;
    }
}