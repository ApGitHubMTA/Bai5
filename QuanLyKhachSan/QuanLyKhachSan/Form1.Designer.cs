﻿namespace QuanLyKhachSan
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDodung = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Khaki;
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.btnDodung);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtTenphong);
            this.groupBox5.Controls.Add(this.txtMaphong);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1126, 419);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Khaki;
            this.groupBox4.Controls.Add(this.btnHuy);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.btnLuu);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(598, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(524, 396);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(251, 5);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 43);
            this.btnLuu.TabIndex = 56;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(116, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 43);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnDodung
            // 
            this.btnDodung.Location = new System.Drawing.Point(316, 128);
            this.btnDodung.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodung.Name = "btnDodung";
            this.btnDodung.Size = new System.Drawing.Size(181, 28);
            this.btnDodung.TabIndex = 61;
            this.btnDodung.Text = "Đồ dùng trong phòng";
            this.btnDodung.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "Loại phòng";
            // 
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(316, 53);
            this.txtTenphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(180, 22);
            this.txtTenphong.TabIndex = 58;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Enabled = false;
            this.txtMaphong.Location = new System.Drawing.Point(316, 12);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(180, 22);
            this.txtMaphong.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Tên phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Mã phòng";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(116, 79);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 43);
            this.btnSua.TabIndex = 57;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(251, 79);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 43);
            this.btnHuy.TabIndex = 58;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 419);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form1";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodung;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
    }
}