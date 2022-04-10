
namespace RSA__team_MH4_
{
    partial class FormRSA
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
            this.grpSinhKhoa = new System.Windows.Forms.GroupBox();
            this.btnSinhKhoa = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.lbQ = new System.Windows.Forms.Label();
            this.lbP = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtKeyPrivate = new System.Windows.Forms.TextBox();
            this.lbKeyPulbic = new System.Windows.Forms.Label();
            this.lbKeyPrivate = new System.Windows.Forms.Label();
            this.lbRamdom = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpEncryp = new System.Windows.Forms.GroupBox();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.btnXuatKq1 = new System.Windows.Forms.Button();
            this.btnKyVanBan = new System.Windows.Forms.Button();
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbPlainText = new System.Windows.Forms.Label();
            this.grpDecryp = new System.Windows.Forms.GroupBox();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnXuatKQ2 = new System.Windows.Forms.Button();
            this.btnXacThuc = new System.Windows.Forms.Button();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.txtPlainText2 = new System.Windows.Forms.TextBox();
            this.lbPlaint = new System.Windows.Forms.Label();
            this.lbResult1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset3 = new System.Windows.Forms.Button();
            this.grpSinhKhoa.SuspendLayout();
            this.grpEncryp.SuspendLayout();
            this.grpDecryp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSinhKhoa
            // 
            this.grpSinhKhoa.Controls.Add(this.btnReset3);
            this.grpSinhKhoa.Controls.Add(this.pictureBox2);
            this.grpSinhKhoa.Controls.Add(this.pictureBox1);
            this.grpSinhKhoa.Controls.Add(this.btnSinhKhoa);
            this.grpSinhKhoa.Controls.Add(this.btnRandom);
            this.grpSinhKhoa.Controls.Add(this.txtQ);
            this.grpSinhKhoa.Controls.Add(this.txtP);
            this.grpSinhKhoa.Controls.Add(this.lbQ);
            this.grpSinhKhoa.Controls.Add(this.lbP);
            this.grpSinhKhoa.Controls.Add(this.txtPublicKey);
            this.grpSinhKhoa.Controls.Add(this.txtKeyPrivate);
            this.grpSinhKhoa.Controls.Add(this.lbKeyPulbic);
            this.grpSinhKhoa.Controls.Add(this.lbKeyPrivate);
            this.grpSinhKhoa.Controls.Add(this.lbRamdom);
            this.grpSinhKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSinhKhoa.Location = new System.Drawing.Point(0, 0);
            this.grpSinhKhoa.Name = "grpSinhKhoa";
            this.grpSinhKhoa.Size = new System.Drawing.Size(938, 242);
            this.grpSinhKhoa.TabIndex = 0;
            this.grpSinhKhoa.TabStop = false;
            this.grpSinhKhoa.Text = "Sinh khóa";
            // 
            // btnSinhKhoa
            // 
            this.btnSinhKhoa.Location = new System.Drawing.Point(788, 182);
            this.btnSinhKhoa.Name = "btnSinhKhoa";
            this.btnSinhKhoa.Size = new System.Drawing.Size(122, 32);
            this.btnSinhKhoa.TabIndex = 10;
            this.btnSinhKhoa.Text = "Sinh Khóa";
            this.btnSinhKhoa.UseVisualStyleBackColor = true;
            this.btnSinhKhoa.Click += new System.EventHandler(this.btnSinhKhoa_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(634, 182);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(134, 32);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.Text = "Ngẫu nhiên";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(867, 48);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(43, 27);
            this.txtQ.TabIndex = 8;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(659, 48);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(43, 27);
            this.txtP.TabIndex = 7;
            // 
            // lbQ
            // 
            this.lbQ.AutoSize = true;
            this.lbQ.Location = new System.Drawing.Point(824, 51);
            this.lbQ.Name = "lbQ";
            this.lbQ.Size = new System.Drawing.Size(18, 20);
            this.lbQ.TabIndex = 6;
            this.lbQ.Text = "q";
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Location = new System.Drawing.Point(620, 55);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(20, 20);
            this.lbP.TabIndex = 5;
            this.lbP.Text = "P";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(659, 131);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(251, 30);
            this.txtPublicKey.TabIndex = 4;
            // 
            // txtKeyPrivate
            // 
            this.txtKeyPrivate.Location = new System.Drawing.Point(156, 131);
            this.txtKeyPrivate.Multiline = true;
            this.txtKeyPrivate.Name = "txtKeyPrivate";
            this.txtKeyPrivate.Size = new System.Drawing.Size(229, 30);
            this.txtKeyPrivate.TabIndex = 3;
            // 
            // lbKeyPulbic
            // 
            this.lbKeyPulbic.AutoSize = true;
            this.lbKeyPulbic.Location = new System.Drawing.Point(517, 134);
            this.lbKeyPulbic.Name = "lbKeyPulbic";
            this.lbKeyPulbic.Size = new System.Drawing.Size(123, 20);
            this.lbKeyPulbic.TabIndex = 2;
            this.lbKeyPulbic.Text = "Khóa công khai";
            // 
            // lbKeyPrivate
            // 
            this.lbKeyPrivate.AutoSize = true;
            this.lbKeyPrivate.Location = new System.Drawing.Point(24, 134);
            this.lbKeyPrivate.Name = "lbKeyPrivate";
            this.lbKeyPrivate.Size = new System.Drawing.Size(116, 20);
            this.lbKeyPrivate.TabIndex = 1;
            this.lbKeyPrivate.Text = "2. Khóa bí mật";
            // 
            // lbRamdom
            // 
            this.lbRamdom.AutoSize = true;
            this.lbRamdom.Location = new System.Drawing.Point(24, 48);
            this.lbRamdom.Name = "lbRamdom";
            this.lbRamdom.Size = new System.Drawing.Size(266, 20);
            this.lbRamdom.TabIndex = 0;
            this.lbRamdom.Text = "1. Chọn 2 số nguyên tố ngẫu nhiên";
            // 
            // grpEncryp
            // 
            this.grpEncryp.Controls.Add(this.btnReset1);
            this.grpEncryp.Controls.Add(this.btnXuatKq1);
            this.grpEncryp.Controls.Add(this.btnKyVanBan);
            this.grpEncryp.Controls.Add(this.btnSelect1);
            this.grpEncryp.Controls.Add(this.txtResult1);
            this.grpEncryp.Controls.Add(this.txtPlaintext);
            this.grpEncryp.Controls.Add(this.lbResult);
            this.grpEncryp.Controls.Add(this.lbPlainText);
            this.grpEncryp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEncryp.Location = new System.Drawing.Point(0, 244);
            this.grpEncryp.Name = "grpEncryp";
            this.grpEncryp.Size = new System.Drawing.Size(484, 401);
            this.grpEncryp.TabIndex = 1;
            this.grpEncryp.TabStop = false;
            this.grpEncryp.Text = "Mã hóa";
            // 
            // btnReset1
            // 
            this.btnReset1.Location = new System.Drawing.Point(336, 348);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(122, 29);
            this.btnReset1.TabIndex = 19;
            this.btnReset1.Text = "Reset";
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // btnXuatKq1
            // 
            this.btnXuatKq1.Location = new System.Drawing.Point(170, 271);
            this.btnXuatKq1.Name = "btnXuatKq1";
            this.btnXuatKq1.Size = new System.Drawing.Size(134, 29);
            this.btnXuatKq1.TabIndex = 18;
            this.btnXuatKq1.Text = "Xuất kết quả";
            this.btnXuatKq1.UseVisualStyleBackColor = true;
            this.btnXuatKq1.Click += new System.EventHandler(this.btnXuatKq1_Click);
            // 
            // btnKyVanBan
            // 
            this.btnKyVanBan.Location = new System.Drawing.Point(327, 271);
            this.btnKyVanBan.Name = "btnKyVanBan";
            this.btnKyVanBan.Size = new System.Drawing.Size(131, 29);
            this.btnKyVanBan.TabIndex = 17;
            this.btnKyVanBan.Text = "Ký văn bản";
            this.btnKyVanBan.UseVisualStyleBackColor = true;
            this.btnKyVanBan.Click += new System.EventHandler(this.btnKyVanBan_Click);
            // 
            // btnSelect1
            // 
            this.btnSelect1.Location = new System.Drawing.Point(383, 99);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(75, 29);
            this.btnSelect1.TabIndex = 16;
            this.btnSelect1.Text = "Chọn";
            this.btnSelect1.UseVisualStyleBackColor = true;
            this.btnSelect1.Click += new System.EventHandler(this.btnSelect1_Click);
            // 
            // txtResult1
            // 
            this.txtResult1.Location = new System.Drawing.Point(100, 181);
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.Size = new System.Drawing.Size(358, 27);
            this.txtResult1.TabIndex = 14;
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Location = new System.Drawing.Point(100, 100);
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(268, 27);
            this.txtPlaintext.TabIndex = 13;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(24, 184);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(66, 20);
            this.lbResult.TabIndex = 12;
            this.lbResult.Text = "Kết quả";
            // 
            // lbPlainText
            // 
            this.lbPlainText.AutoSize = true;
            this.lbPlainText.Location = new System.Drawing.Point(24, 103);
            this.lbPlainText.Name = "lbPlainText";
            this.lbPlainText.Size = new System.Drawing.Size(70, 20);
            this.lbPlainText.TabIndex = 11;
            this.lbPlainText.Text = "Văn bản";
            // 
            // grpDecryp
            // 
            this.grpDecryp.Controls.Add(this.btnReset2);
            this.grpDecryp.Controls.Add(this.btnXuatKQ2);
            this.grpDecryp.Controls.Add(this.btnXacThuc);
            this.grpDecryp.Controls.Add(this.btnSelect2);
            this.grpDecryp.Controls.Add(this.txtResult2);
            this.grpDecryp.Controls.Add(this.txtPlainText2);
            this.grpDecryp.Controls.Add(this.lbPlaint);
            this.grpDecryp.Controls.Add(this.lbResult1);
            this.grpDecryp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDecryp.Location = new System.Drawing.Point(490, 244);
            this.grpDecryp.Name = "grpDecryp";
            this.grpDecryp.Size = new System.Drawing.Size(448, 401);
            this.grpDecryp.TabIndex = 2;
            this.grpDecryp.TabStop = false;
            this.grpDecryp.Text = "Giải mã";
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(298, 348);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(122, 29);
            this.btnReset2.TabIndex = 20;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnXuatKQ2
            // 
            this.btnXuatKQ2.Location = new System.Drawing.Point(103, 271);
            this.btnXuatKQ2.Name = "btnXuatKQ2";
            this.btnXuatKQ2.Size = new System.Drawing.Size(154, 29);
            this.btnXuatKQ2.TabIndex = 20;
            this.btnXuatKQ2.Text = "Xuất kết quả";
            this.btnXuatKQ2.UseVisualStyleBackColor = true;
            this.btnXuatKQ2.Click += new System.EventHandler(this.btnXuatKQ2_Click);
            // 
            // btnXacThuc
            // 
            this.btnXacThuc.Location = new System.Drawing.Point(285, 271);
            this.btnXacThuc.Name = "btnXacThuc";
            this.btnXacThuc.Size = new System.Drawing.Size(135, 29);
            this.btnXacThuc.TabIndex = 19;
            this.btnXacThuc.Text = "Xác thực";
            this.btnXacThuc.UseVisualStyleBackColor = true;
            this.btnXacThuc.Click += new System.EventHandler(this.btnXacThuc_Click);
            // 
            // btnSelect2
            // 
            this.btnSelect2.Location = new System.Drawing.Point(345, 98);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(75, 29);
            this.btnSelect2.TabIndex = 17;
            this.btnSelect2.Text = "Chọn";
            this.btnSelect2.UseVisualStyleBackColor = true;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(103, 181);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(317, 27);
            this.txtResult2.TabIndex = 15;
            // 
            // txtPlainText2
            // 
            this.txtPlainText2.Location = new System.Drawing.Point(103, 100);
            this.txtPlainText2.Name = "txtPlainText2";
            this.txtPlainText2.Size = new System.Drawing.Size(222, 27);
            this.txtPlainText2.TabIndex = 14;
            // 
            // lbPlaint
            // 
            this.lbPlaint.AutoSize = true;
            this.lbPlaint.Location = new System.Drawing.Point(27, 103);
            this.lbPlaint.Name = "lbPlaint";
            this.lbPlaint.Size = new System.Drawing.Size(70, 20);
            this.lbPlaint.TabIndex = 13;
            this.lbPlaint.Text = "Văn bản";
            // 
            // lbResult1
            // 
            this.lbResult1.AutoSize = true;
            this.lbResult1.Location = new System.Drawing.Point(27, 184);
            this.lbResult1.Name = "lbResult1";
            this.lbResult1.Size = new System.Drawing.Size(66, 20);
            this.lbResult1.TabIndex = 14;
            this.lbResult1.Text = "Kết quả";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::RSA__team_MH4_.Properties.Resources.pngtree_vector_eye_icon_png_image_326752;
            this.pictureBox2.Image = global::RSA__team_MH4_.Properties.Resources.pngtree_vector_eye_icon_png_image_326752;
            this.pictureBox2.Location = new System.Drawing.Point(439, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RSA__team_MH4_.Properties.Resources.pngtree_eyes_icon_for_your_project_png_image_4853490;
            this.pictureBox1.Image = global::RSA__team_MH4_.Properties.Resources.pngtree_eyes_icon_for_your_project_png_image_4853490;
            this.pictureBox1.Location = new System.Drawing.Point(399, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnReset3
            // 
            this.btnReset3.Location = new System.Drawing.Point(490, 182);
            this.btnReset3.Name = "btnReset3";
            this.btnReset3.Size = new System.Drawing.Size(122, 32);
            this.btnReset3.TabIndex = 20;
            this.btnReset3.Text = "Reset";
            this.btnReset3.UseVisualStyleBackColor = true;
            this.btnReset3.Click += new System.EventHandler(this.btnReset3_Click);
            // 
            // FormRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 649);
            this.Controls.Add(this.grpDecryp);
            this.Controls.Add(this.grpEncryp);
            this.Controls.Add(this.grpSinhKhoa);
            this.Name = "FormRSA";
            this.Text = "FormRSA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRSA_FormClosing);
            this.grpSinhKhoa.ResumeLayout(false);
            this.grpSinhKhoa.PerformLayout();
            this.grpEncryp.ResumeLayout(false);
            this.grpEncryp.PerformLayout();
            this.grpDecryp.ResumeLayout(false);
            this.grpDecryp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSinhKhoa;
        private System.Windows.Forms.TextBox txtKeyPrivate;
        private System.Windows.Forms.Label lbKeyPulbic;
        private System.Windows.Forms.Label lbKeyPrivate;
        private System.Windows.Forms.Label lbRamdom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpEncryp;
        private System.Windows.Forms.GroupBox grpDecryp;
        private System.Windows.Forms.Button btnSinhKhoa;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label lbQ;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button btnXuatKq1;
        private System.Windows.Forms.Button btnKyVanBan;
        private System.Windows.Forms.Button btnSelect1;
        private System.Windows.Forms.TextBox txtResult1;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbPlainText;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnXuatKQ2;
        private System.Windows.Forms.Button btnXacThuc;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.TextBox txtPlainText2;
        private System.Windows.Forms.Label lbPlaint;
        private System.Windows.Forms.Label lbResult1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReset3;
    }
}