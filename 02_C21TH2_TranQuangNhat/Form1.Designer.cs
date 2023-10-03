
namespace _02_C21TH2_TranQuangNhat
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
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsomon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbomakh = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnkhong = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.btndau = new System.Windows.Forms.Button();
            this.btntruoc = new System.Windows.Forms.Button();
            this.btncuoi = new System.Windows.Forms.Button();
            this.btnsau = new System.Windows.Forms.Button();
            this.btnthongtin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 61);
            this.label1.TabIndex = 16;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã SV";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(112, 86);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.ReadOnly = true;
            this.txtmasv.Size = new System.Drawing.Size(344, 28);
            this.txtmasv.TabIndex = 0;
            this.txtmasv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmasv_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số Môn";
            // 
            // txtsomon
            // 
            this.txtsomon.Location = new System.Drawing.Point(112, 175);
            this.txtsomon.Name = "txtsomon";
            this.txtsomon.Size = new System.Drawing.Size(344, 28);
            this.txtsomon.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Khoa";
            // 
            // cbomakh
            // 
            this.cbomakh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomakh.FormattingEnabled = true;
            this.cbomakh.Location = new System.Drawing.Point(112, 226);
            this.cbomakh.Name = "cbomakh";
            this.cbomakh.Size = new System.Drawing.Size(344, 29);
            this.cbomakh.TabIndex = 3;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(29, 357);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(90, 41);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(144, 357);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(90, 41);
            this.btnhuy.TabIndex = 9;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnkhong
            // 
            this.btnkhong.Location = new System.Drawing.Point(366, 357);
            this.btnkhong.Name = "btnkhong";
            this.btnkhong.Size = new System.Drawing.Size(90, 41);
            this.btnkhong.TabIndex = 11;
            this.btnkhong.Text = "Không";
            this.btnkhong.UseVisualStyleBackColor = true;
            this.btnkhong.Click += new System.EventHandler(this.btnkhong_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(255, 357);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(90, 41);
            this.btnghi.TabIndex = 10;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Họ Tên";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(112, 134);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(344, 28);
            this.txthoten.TabIndex = 1;
            // 
            // btndau
            // 
            this.btndau.Location = new System.Drawing.Point(29, 296);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(90, 41);
            this.btndau.TabIndex = 4;
            this.btndau.Text = "Đầu";
            this.btndau.UseVisualStyleBackColor = true;
            this.btndau.Click += new System.EventHandler(this.btndau_Click);
            // 
            // btntruoc
            // 
            this.btntruoc.Location = new System.Drawing.Point(144, 296);
            this.btntruoc.Name = "btntruoc";
            this.btntruoc.Size = new System.Drawing.Size(90, 41);
            this.btntruoc.TabIndex = 5;
            this.btntruoc.Text = "Trước";
            this.btntruoc.UseVisualStyleBackColor = true;
            this.btntruoc.Click += new System.EventHandler(this.btntruoc_Click);
            // 
            // btncuoi
            // 
            this.btncuoi.Location = new System.Drawing.Point(366, 296);
            this.btncuoi.Name = "btncuoi";
            this.btncuoi.Size = new System.Drawing.Size(90, 41);
            this.btncuoi.TabIndex = 7;
            this.btncuoi.Text = "Cuối";
            this.btncuoi.UseVisualStyleBackColor = true;
            this.btncuoi.Click += new System.EventHandler(this.btncuoi_Click);
            // 
            // btnsau
            // 
            this.btnsau.Location = new System.Drawing.Point(255, 296);
            this.btnsau.Name = "btnsau";
            this.btnsau.Size = new System.Drawing.Size(90, 41);
            this.btnsau.TabIndex = 6;
            this.btnsau.Text = "Sau";
            this.btnsau.UseVisualStyleBackColor = true;
            this.btnsau.Click += new System.EventHandler(this.btnsau_Click);
            // 
            // btnthongtin
            // 
            this.btnthongtin.Location = new System.Drawing.Point(270, 411);
            this.btnthongtin.Name = "btnthongtin";
            this.btnthongtin.Size = new System.Drawing.Size(177, 41);
            this.btnthongtin.TabIndex = 7;
            this.btnthongtin.Text = "Thông Tin Chi Tiết";
            this.btnthongtin.UseVisualStyleBackColor = true;
            this.btnthongtin.Click += new System.EventHandler(this.btnthongtin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 464);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btnsau);
            this.Controls.Add(this.btnkhong);
            this.Controls.Add(this.btnthongtin);
            this.Controls.Add(this.btncuoi);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btntruoc);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btndau);
            this.Controls.Add(this.cbomakh);
            this.Controls.Add(this.txtsomon);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsomon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbomakh;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnkhong;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Button btndau;
        private System.Windows.Forms.Button btntruoc;
        private System.Windows.Forms.Button btncuoi;
        private System.Windows.Forms.Button btnsau;
        private System.Windows.Forms.Button btnthongtin;
    }
}

