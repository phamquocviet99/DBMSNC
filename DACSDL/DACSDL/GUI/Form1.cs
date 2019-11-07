using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {
            FormSP SP = new FormSP();
            SP.ShowDialog();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            FormKH KH = new FormKH();
               KH.ShowDialog();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            FormNV NV = new FormNV();
            NV.ShowDialog();
        }

        private void btndoanhthu_Click(object sender, EventArgs e)
        {
            FormDT DT = new FormDT();
            DT.ShowDialog();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            FormCN CN = new FormCN();
            CN.ShowDialog();
        }

        private void btnbaohanh_Click(object sender, EventArgs e)
        {
            FormBH BH = new FormBH();
            BH.ShowDialog();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            FormTK TK = new FormTK();
            TK.ShowDialog();
        }
    }
}
