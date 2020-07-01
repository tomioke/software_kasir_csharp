namespace JualTunai
{
    partial class FrmTambahUser
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
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckFrmBrg = new System.Windows.Forms.CheckBox();
            this.ckFrmKat = new System.Windows.Forms.CheckBox();
            this.ckFrmSat = new System.Windows.Forms.CheckBox();
            this.ckFrmJual = new System.Windows.Forms.CheckBox();
            this.ckFrmLap = new System.Windows.Forms.CheckBox();
            this.ckFrmPass = new System.Windows.Forms.CheckBox();
            this.ckFrmSet = new System.Windows.Forms.CheckBox();
            this.ckAktif = new System.Windows.Forms.CheckBox();
            this.ckFrmKas = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnKeluar
            // 
            this.btnKeluar.AutoSize = true;
            this.btnKeluar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.Location = new System.Drawing.Point(185, 192);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(88, 25);
            this.btnKeluar.TabIndex = 38;
            this.btnKeluar.Text = "Keluar (ESC)";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.AutoSize = true;
            this.btnSimpan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(18, 192);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(85, 25);
            this.btnSimpan.TabIndex = 36;
            this.btnSimpan.Text = "Simpan (F3)";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(95, 38);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(121, 21);
            this.txtPass.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pass";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(95, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(121, 21);
            this.txtUser.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "User";
            // 
            // ckFrmBrg
            // 
            this.ckFrmBrg.AutoSize = true;
            this.ckFrmBrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFrmBrg.Location = new System.Drawing.Point(18, 98);
            this.ckFrmBrg.Name = "ckFrmBrg";
            this.ckFrmBrg.Size = new System.Drawing.Size(98, 19);
            this.ckFrmBrg.TabIndex = 39;
            this.ckFrmBrg.Text = "Form Barang";
            this.ckFrmBrg.UseVisualStyleBackColor = true;
            // 
            // ckFrmKat
            // 
            this.ckFrmKat.AutoSize = true;
            this.ckFrmKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFrmKat.Location = new System.Drawing.Point(18, 121);
            this.ckFrmKat.Name = "ckFrmKat";
            this.ckFrmKat.Size = new System.Drawing.Size(104, 19);
            this.ckFrmKat.TabIndex = 40;
            this.ckFrmKat.Text = "Form Kategori";
            this.ckFrmKat.UseVisualStyleBackColor = true;
            // 
            // ckFrmSat
            // 
            this.ckFrmSat.AutoSize = true;
            this.ckFrmSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFrmSat.Location = new System.Drawing.Point(18, 144);
            this.ckFrmSat.Name = "ckFrmSat";
            this.ckFrmSat.Size = new System.Drawing.Size(97, 19);
            this.ckFrmSat.TabIndex = 41;
            this.ckFrmSat.Text = "Form Satuan";
            this.ckFrmSat.UseVisualStyleBackColor = true;
            // 
            // ckFrmJual
            // 
            this.ckFrmJual.AutoSize = true;
            this.ckFrmJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFrmJual.Location = new System.Drawing.Point(18, 167);
            this.ckFrmJual.Name = "ckFrmJual";
            this.ckFrmJual.Size = new System.Drawing.Size(114, 19);
            this.ckFrmJual.TabIndex = 42;
            this.ckFrmJual.Text = "Form Penjualan";
            this.ckFrmJual.UseVisualStyleBackColor = true;
            // 
            // ckFrmLap
            // 
            this.ckFrmLap.AutoSize = true;
            this.ckFrmLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFrmLap.Location = new System.Drawing.Point(169, 98);
            this.ckFrmLap.Name = "ckFrmLap";
            this.ckFrmLap.Size = new System.Drawing.Size(104, 19);
            this.ckFrmLap.TabIndex = 43;
            this.ckFrmLap.Text = "Form Laporan";
            this.ckFrmLap.UseVisualStyleBackColor = true;
            // 
            // ckFrmPass
            // 
            this.ckFrmPass.AutoSize = true;
            this.ckFrmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFrmPass.Location = new System.Drawing.Point(169, 144);
            this.ckFrmPass.Name = "ckFrmPass";
            this.ckFrmPass.Size = new System.Drawing.Size(112, 19);
            this.ckFrmPass.TabIndex = 44;
            this.ckFrmPass.Text = "Form Password";
            this.ckFrmPass.UseVisualStyleBackColor = true;
            // 
            // ckFrmSet
            // 
            this.ckFrmSet.AutoSize = true;
            this.ckFrmSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFrmSet.Location = new System.Drawing.Point(169, 167);
            this.ckFrmSet.Name = "ckFrmSet";
            this.ckFrmSet.Size = new System.Drawing.Size(96, 19);
            this.ckFrmSet.TabIndex = 45;
            this.ckFrmSet.Text = "Form Setting";
            this.ckFrmSet.UseVisualStyleBackColor = true;
            // 
            // ckAktif
            // 
            this.ckAktif.AutoSize = true;
            this.ckAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckAktif.Location = new System.Drawing.Point(95, 65);
            this.ckAktif.Name = "ckAktif";
            this.ckAktif.Size = new System.Drawing.Size(48, 19);
            this.ckAktif.TabIndex = 46;
            this.ckAktif.Text = "Aktif";
            this.ckAktif.UseVisualStyleBackColor = true;
            // 
            // ckFrmKas
            // 
            this.ckFrmKas.AutoSize = true;
            this.ckFrmKas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckFrmKas.Location = new System.Drawing.Point(169, 121);
            this.ckFrmKas.Name = "ckFrmKas";
            this.ckFrmKas.Size = new System.Drawing.Size(79, 19);
            this.ckFrmKas.TabIndex = 47;
            this.ckFrmKas.Text = "Form Kas";
            this.ckFrmKas.UseVisualStyleBackColor = true;
            // 
            // FrmTambahUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(289, 226);
            this.Controls.Add(this.ckFrmKas);
            this.Controls.Add(this.ckAktif);
            this.Controls.Add(this.ckFrmSet);
            this.Controls.Add(this.ckFrmPass);
            this.Controls.Add(this.ckFrmLap);
            this.Controls.Add(this.ckFrmJual);
            this.Controls.Add(this.ckFrmSat);
            this.Controls.Add(this.ckFrmKat);
            this.Controls.Add(this.ckFrmBrg);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTambahUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Data";
            this.Load += new System.EventHandler(this.FrmTambahUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTmbhUsr_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckFrmBrg;
        private System.Windows.Forms.CheckBox ckFrmKat;
        private System.Windows.Forms.CheckBox ckFrmSat;
        private System.Windows.Forms.CheckBox ckFrmJual;
        private System.Windows.Forms.CheckBox ckFrmLap;
        private System.Windows.Forms.CheckBox ckFrmPass;
        private System.Windows.Forms.CheckBox ckFrmSet;
        private System.Windows.Forms.CheckBox ckAktif;
        private System.Windows.Forms.CheckBox ckFrmKas;
    }
}