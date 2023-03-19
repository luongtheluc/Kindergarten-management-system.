using Atm.datanuser;
using Atm.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm
{

    public partial class srmruttien : Form
    {
        taikhoan TaiKhoan;
        public event RutTiendelegate Ruttienthanhcong;
        public srmruttien()
        {
            InitializeComponent();
        }

        public srmruttien(taikhoan TaiKhoan)
        {
            InitializeComponent();
            this.TaiKhoan = TaiKhoan;
        }

        private void btnruttien_Click(object sender, EventArgs e)
        {
            
            int soTienRut = int.Parse(txttienrut.Text);
            
            using (var dbContext = new appatm())
            {
                taikhoan tk = dbContext.taikhoans.Find(this.TaiKhoan.id);
                tk.SoDu -= soTienRut;

                  
                dbContext.SaveChanges();
                Ruttienthanhcong((double)tk.SoDu);
                MessageBox.Show("Rút Thành Công");

            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
