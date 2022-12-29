using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCapnhatKH : Form
    {
        public frmCapnhatKH()
        {
            InitializeComponent();
        }
        //-----------Khai báo biến thuộc lớp BUS_CDBCustomer ở tầng BUS
        BUS_CDBCustomer cm = new BUS_CDBCustomer();


        private void frmCapnhatKH_Load(object sender, EventArgs e)
        {

            //---------Mặc định cho ComboBox hiển thị giới tính là "Nữ"
            this.cboPhai.SelectedIndex = 1;
            //---------Gọi hàm ẩn/hiện
            AnHien(false, true, true, true, true, false, false);
        }
        //-----------Viết hàm ẩn/hiện TextBox, Button, DateTimePicker, ...
        public void AnHien(bool txt_bt, bool them, bool xoa, bool sua, bool tim, bool luu, bool khongluu)
        {
            //----------Ẩn/Hiện TextBox và ComboBox
            this.txtHoten.Enabled = txt_bt;
            this.txtDienthoai.Enabled = txt_bt;
            this.txtDiachi.Enabled = txt_bt;
            this.cboPhai.Enabled = txt_bt;

            //----------Ẩn/Hiện Button
            this.btnThem.Enabled = them;
            this.btnXoa.Enabled = xoa;
            this.btnSua.Enabled = sua;
            this.btnTim.Enabled = tim;
            this.btnLuu.Enabled = luu;
            this.btnKhongluu.Enabled = khongluu;
        }

        //-----------Viết hàm ẩn/hiện TextBox, Button, DateTimePicker, ...
        public void Xoatrang()
        {
            //----------Ẩn/Hiện TextBox và ComboBox
            this.txtHoten.Text = "";
            this.txtDienthoai.Text = "";
            this.txtDiachi.Text = "";
            this.cboPhai.Text = "";
            this.txtMaKH.Text = "";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //----------1.Khởi tạo các thông tin khách hàng
            DTO_CDBCustomer cus = new DTO_CDBCustomer(this.txtMaKH.Text.Trim(),
                this.txtHoten.Text.Trim(),
            this.cboPhai.Text,
            this.txtDiachi.Text.Trim

            (),
            this.txtDienthoai.Text.Trim());
            //----------2.Gọi hàm thêm khách hàng mới
            cm.pr_THEMKH(cus);

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTimKhachHang frm = new frmTimKhachHang();
            frm.Show();
        }
        // -------Viết hàm ẩn hiện/ Text Box, Combobox, Button


        private void btnThem_Click(object sender, EventArgs e)
        {

            //---------Gọi hàm ẩn/hiện
            AnHien(true, false, false, false, true, true, true);

            //---------Gọi hàm hàm tạo mã số khách hàng
            SqlDataReader dr = cm.getDataStoredProcedure("pr_TAOMSKH");
            //---------Kiểm tra xem có đọc được mã số khách hàng không?
            if (dr.Read() == true)
            {
                this.txtMaKH.Text = dr.GetString(0).ToString();
            }
            //---------Đóng lớp SqlDataReader
            dr.Close();
        }

        private void btnKhongluu_Click(object sender, EventArgs e)
        {
            //---------Gọi hàm ẩn/hiện
            AnHien(false, true, true, true, true, false, false);

            //---------Gọi hàm xóa trắng
            Xoatrang();
        }

        private void frmCapnhatKH_Load_1(object sender, EventArgs e)
        {

        }
    }
}
