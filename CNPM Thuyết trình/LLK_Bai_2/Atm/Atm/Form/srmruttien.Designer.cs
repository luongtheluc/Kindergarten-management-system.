
namespace Atm
{
    partial class srmruttien
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
            this.btnruttien = new System.Windows.Forms.Button();
            this.txttienrut = new System.Windows.Forms.TextBox();
            this.btndong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnruttien
            // 
            this.btnruttien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnruttien.Location = new System.Drawing.Point(121, 109);
            this.btnruttien.Margin = new System.Windows.Forms.Padding(2);
            this.btnruttien.Name = "btnruttien";
            this.btnruttien.Size = new System.Drawing.Size(129, 33);
            this.btnruttien.TabIndex = 0;
            this.btnruttien.Text = "Rút ";
            this.btnruttien.UseVisualStyleBackColor = true;
            this.btnruttien.Click += new System.EventHandler(this.btnruttien_Click);
            // 
            // txttienrut
            // 
            this.txttienrut.Location = new System.Drawing.Point(121, 46);
            this.txttienrut.Margin = new System.Windows.Forms.Padding(2);
            this.txttienrut.Name = "txttienrut";
            this.txttienrut.Size = new System.Drawing.Size(290, 20);
            this.txttienrut.TabIndex = 1;
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(282, 109);
            this.btndong.Margin = new System.Windows.Forms.Padding(2);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(129, 33);
            this.btndong.TabIndex = 0;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số Tiền";
            // 
            // srmruttien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttienrut);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnruttien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "srmruttien";
            this.Text = "srmruttien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnruttien;
        private System.Windows.Forms.TextBox txttienrut;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Label label1;
    }
}