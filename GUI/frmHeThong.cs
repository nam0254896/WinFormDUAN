using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHeThong : Form
    {
        //---------Khai báo lớp GUI_CEnableMenu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();
        //---------Khai báo lớp:
        BUS_CDBConnect cn = new BUS_CDBConnect();
        public frmHeThong()
        {
            InitializeComponent();
        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {
            mnu.CEnableMenu(true, false);
            frmDangnhap frm = new frmDangnhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDN_Click(object sender, EventArgs e)
        {
            frmDangnhap frm = new frmDangnhap();
            frm.Show();
        }




        private void mnuKH_Click(object sender, EventArgs e)
        {
            frmCapnhatKH frm = new frmCapnhatKH();
            frm.ShowDialog();
        }

        private void mnuLHD_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.ShowDialog();
        }

        private void tHoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuHuyKN_Click(object sender, EventArgs e)
        {
            if (cn.DisDBConnect() == true)
            {
                mnu.CEnableMenu(true, false);
            }
            else
            {
                MessageBox.Show("Hủy kết nối CSDL không thành công!");
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }


        private void xToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolMatHang_Click(object sender, EventArgs e)
        {
            frmMatHang frm = new frmMatHang();
            frm.ShowDialog();
        }


    }
}
