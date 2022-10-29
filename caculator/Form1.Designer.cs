namespace caculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập b:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(120, 46);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 26);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(119, 89);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 26);
            this.txtB.TabIndex = 1;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // btnCong
            // 
            this.btnCong.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCong.ForeColor = System.Drawing.Color.White;
            this.btnCong.Location = new System.Drawing.Point(12, 197);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(78, 39);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = false;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(31, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(119, 136);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(100, 26);
            this.txtRes.TabIndex = 1;
            this.txtRes.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "CHƯƠNG TRÌNH PHÉP TÍNH CƠ BẢN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkRed;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(12, 284);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 35);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnTru
            // 
            this.btnTru.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTru.ForeColor = System.Drawing.Color.White;
            this.btnTru.Location = new System.Drawing.Point(102, 197);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(78, 39);
            this.btnTru.TabIndex = 2;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = false;
            this.btnTru.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhan.ForeColor = System.Drawing.Color.White;
            this.btnNhan.Location = new System.Drawing.Point(195, 197);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(78, 39);
            this.btnNhan.TabIndex = 2;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = false;
            this.btnNhan.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnChia
            // 
            this.btnChia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChia.ForeColor = System.Drawing.Color.White;
            this.btnChia.Location = new System.Drawing.Point(289, 197);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(78, 39);
            this.btnChia.TabIndex = 2;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = false;
            this.btnChia.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
    }
}

