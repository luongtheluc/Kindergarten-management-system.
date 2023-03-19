using Atm.datanuser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm
{
    
    public partial class srmprivate : Form
    {
        public srmprivate()
        {
            InitializeComponent();
            lbsodu.Text = "";
            


        }

        public taikhoan TaiKhoan { get; private set; }

        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string ttentaikhoan = txttentk.Text.Trim();
            string mmatkhau = MD5Hash(txtmatkhau.Text.Trim());
            using( var dbContext = new appatm())
            {
                TaiKhoan = dbContext.taikhoans.Where(s => s.tentaikhoan == ttentaikhoan && s.matkhau == mmatkhau).FirstOrDefault();

                if (TaiKhoan!=null)
                {
                    //dang nhap dc
                    lbsodu.Text = TaiKhoan.SoDu.ToString();
                    btnruttien.Enabled = true;
                }
                else
                {
                    MessageBox.Show(" vcl");
                }
            }
        }

        private void btnruttien_Click(object sender, EventArgs e)
        {
            srmruttien smrrut = new srmruttien(TaiKhoan);
            smrrut.Ruttienthanhcong += smrrut_Ruttienthanhcong;
            smrrut.Show();
        }
        private void smrrut_Ruttienthanhcong(double soduhientai)
        {
            lbsodu.Text = soduhientai.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
