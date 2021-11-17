
namespace ParaKafe
{
    partial class SiparisForm
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
            this.cboMasaNo = new System.Windows.Forms.ComboBox();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAnasayfayaDon = new System.Windows.Forms.Button();
            this.btnSiparisIptal = new System.Windows.Forms.Button();
            this.dgvSiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMasaTasi = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMasaNo
            // 
            this.cboMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMasaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboMasaNo.FormattingEnabled = true;
            this.cboMasaNo.Location = new System.Drawing.Point(660, 40);
            this.cboMasaNo.Margin = new System.Windows.Forms.Padding(4);
            this.cboMasaNo.Name = "cboMasaNo";
            this.cboMasaNo.Size = new System.Drawing.Size(126, 28);
            this.cboMasaNo.TabIndex = 7;
            // 
            // cboUrun
            // 
            this.cboUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(17, 39);
            this.cboUrun.Margin = new System.Windows.Forms.Padding(4);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(180, 28);
            this.cboUrun.TabIndex = 2;
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAdet.Location = new System.Drawing.Point(205, 39);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(4);
            this.nudAdet.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(98, 29);
            this.nudAdet.TabIndex = 3;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(311, 39);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 32);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnAnasayfayaDon
            // 
            this.btnAnasayfayaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnasayfayaDon.BackColor = System.Drawing.Color.Gold;
            this.btnAnasayfayaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfayaDon.ForeColor = System.Drawing.Color.Chocolate;
            this.btnAnasayfayaDon.Location = new System.Drawing.Point(619, 480);
            this.btnAnasayfayaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            this.btnAnasayfayaDon.Size = new System.Drawing.Size(312, 75);
            this.btnAnasayfayaDon.TabIndex = 14;
            this.btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            this.btnAnasayfayaDon.UseVisualStyleBackColor = false;
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisIptal.BackColor = System.Drawing.Color.Firebrick;
            this.btnSiparisIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisIptal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSiparisIptal.Location = new System.Drawing.Point(619, 386);
            this.btnSiparisIptal.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(140, 77);
            this.btnSiparisIptal.TabIndex = 12;
            this.btnSiparisIptal.Text = "SİPARİŞ İPTAL";
            this.btnSiparisIptal.UseVisualStyleBackColor = false;
            // 
            // dgvSiparisDetaylar
            // 
            this.dgvSiparisDetaylar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylar.Location = new System.Drawing.Point(17, 78);
            this.dgvSiparisDetaylar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            this.dgvSiparisDetaylar.Size = new System.Drawing.Size(594, 477);
            this.dgvSiparisDetaylar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(201, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(656, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Masa No:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMasaTasi
            // 
            this.btnMasaTasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasaTasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaTasi.Location = new System.Drawing.Point(819, 36);
            this.btnMasaTasi.Margin = new System.Windows.Forms.Padding(4);
            this.btnMasaTasi.Name = "btnMasaTasi";
            this.btnMasaTasi.Size = new System.Drawing.Size(112, 32);
            this.btnMasaTasi.TabIndex = 8;
            this.btnMasaTasi.Text = "TAŞI";
            this.btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaNo.BackColor = System.Drawing.Color.Tomato;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMasaNo.Location = new System.Drawing.Point(619, 78);
            this.lblMasaNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(312, 242);
            this.lblMasaNo.TabIndex = 9;
            this.lblMasaNo.Text = "00";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(645, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ödeme Tutarı:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdemeAl.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOdemeAl.Location = new System.Drawing.Point(791, 386);
            this.btnOdemeAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(140, 77);
            this.btnOdemeAl.TabIndex = 13;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTutari.Location = new System.Drawing.Point(803, 343);
            this.lblOdemeTutari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(66, 26);
            this.lblOdemeTutari.TabIndex = 11;
            this.lblOdemeTutari.Text = "0.00₺";
            this.lblOdemeTutari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 572);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnMasaTasi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSiparisDetaylar);
            this.Controls.Add(this.btnSiparisIptal);
            this.Controls.Add(this.btnAnasayfayaDon);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.cboMasaNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SiparisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMasaNo;
        private System.Windows.Forms.ComboBox cboUrun;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAnasayfayaDon;
        private System.Windows.Forms.Button btnSiparisIptal;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMasaTasi;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Label lblOdemeTutari;
    }
}