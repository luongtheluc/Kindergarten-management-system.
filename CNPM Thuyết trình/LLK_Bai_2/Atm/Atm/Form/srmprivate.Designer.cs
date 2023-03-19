
namespace Atm
{
    partial class srmprivate
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
            this.txttentk = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnruttien = new System.Windows.Forms.Button();
            this.lbsodu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txttentk
            // 
            this.txttentk.Location = new System.Drawing.Point(176, 34);
            this.txttentk.Margin = new System.Windows.Forms.Padding(2);
            this.txttentk.Name = "txttentk";
            this.txttentk.Size = new System.Drawing.Size(225, 20);
            this.txttentk.TabIndex = 0;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(176, 68);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(225, 20);
            this.txtmatkhau.TabIndex = 0;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(178, 110);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(223, 36);
            this.btndangnhap.TabIndex = 1;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnruttien
            // 
            this.btnruttien.Enabled = false;
            this.btnruttien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnruttien.Location = new System.Drawing.Point(176, 221);
            this.btnruttien.Margin = new System.Windows.Forms.Padding(2);
            this.btnruttien.Name = "btnruttien";
            this.btnruttien.Size = new System.Drawing.Size(225, 43);
            this.btnruttien.TabIndex = 1;
            this.btnruttien.Text = "Rút Tiền";
            this.btnruttien.UseVisualStyleBackColor = true;
            this.btnruttien.Click += new System.EventHandler(this.btnruttien_Click);
            // 
            // lbsodu
            // 
            this.lbsodu.AutoSize = true;
            this.lbsodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsodu.Location = new System.Drawing.Point(260, 168);
            this.lbsodu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsodu.Name = "lbsodu";
            this.lbsodu.Size = new System.Drawing.Size(54, 20);
            this.lbsodu.TabIndex = 3;
            this.lbsodu.Text = "Số Dư";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Đăng Nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Dư";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // srmprivate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbsodu);
            this.Controls.Add(this.btnruttien);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttentk);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "srmprivate";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttentk;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnruttien;
        private System.Windows.Forms.Label lbsodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

