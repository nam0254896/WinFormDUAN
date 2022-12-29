using BUS;
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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        //---------------Khai báo biến thuộc lớp BUS_CDBInvoice của tầng BUS
        BUS_CDBCustomer cm = new BUS_CDBCustomer();

        //---------------Khai báo biến thuộc lớp BUS_CDBConnect của tầng BUS
        BUS_CDBConnect cn = new BUS_CDBConnect();
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                //---------Gọi hàm đưa dữ liệu lên ComboBox Nhân Viên
                DataTable myDT = new DataTable();
                cn.getDataTable(myDT, "SELECT MANV, TENNV FROM NHANVIEN");
                this.cboNhanvien.DataSource = myDT;
                this.cboNhanvien.ValueMember = "MANV";
                this.cboNhanvien.DisplayMember = "TENNV";
                this.cboNhanvien.DropDownStyle = ComboBoxStyle.DropDownList;

                //---------Gọi hàm đưa dữ liệu lên ComboBox Khách Hàng
                myDT = new DataTable();
                cn.getDataTable(myDT, "SELECT MSKH, TENKH FROM KHACHHANG");
                this.cboKhachhang.DataSource = myDT;
                this.cboKhachhang.ValueMember = "MSKH";
                this.cboKhachhang.DisplayMember = "TENKH";
                this.cboKhachhang.DropDownStyle = ComboBoxStyle.DropDownList;

                //---------Gọi hàm đưa dữ liệu lên ComboBox Mặt Hàng
                myDT = new DataTable();
                cn.getDataTable(myDT, "SELECT MSMH, TENMH FROM MATHANG");
                this.cboMathang.DataSource = myDT;
                this.cboMathang.ValueMember = "MSMH";
                this.cboMathang.DisplayMember = "TENMH";
                this.cboMathang.DropDownStyle = ComboBoxStyle.DropDownList;

                //---------Load thông tin khách hàng
                myDT = new DataTable();
                cn.getDataTable(myDT, "SELECT DIACHI, PHAI, DIENTHOAI FROM KHACHHANG WHERE MsKH = '" + this.cboKhachhang.SelectedValue.ToString() + "'");
                this.txtDiachi.Text = myDT.Rows[0][0].ToString();
                this.cboPhai.Text = myDT.Rows[0][1].ToString();
                this.txtDienthoai.Text = myDT.Rows[0][2].ToString();

                //---------Gọi hàm ẩn/hiện
                AnHien(false, true, false, false, true, true, true);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!", MessageBoxButtons.OK);
            }
        }

        private void btnLaphoadon_Click(object sender, EventArgs e)
        {
            //---------Gọi hàm ẩn/hiện
            AnHien(true, false, true, true, false, false, false);

            //---------Gọi hàm hàm tạo mã số hóa đơn
            SqlDataReader dr = cm.getDataStoredProcedure("pr_TAOMSHD");
            //---------Kiểm tra xem có đọc được mã số hóa đơn không?
            if (dr.Read() == true)
            {
                this.txtMSHD.Text = dr.GetString(0).ToString();
            }
            //---------Đóng lớp SqlDataReader
            dr.Close();
        }

        //---------------Viết hàm ẩn/hiện chức năng, textbox, combobox, etc.
        public void AnHien(bool txt_cbo_datetime_button, bool laphd,
                            bool luu, bool khongluu, bool tim, bool inhd, bool thoat)
        {
            //---------Ẩn/Hiện TextBox
            this.txtSoluong.Enabled = txt_cbo_datetime_button;


            //---------Ẩn/Hiện Button
            this.btKhachhang.Enabled = txt_cbo_datetime_button;
            this.btNhanvien.Enabled = txt_cbo_datetime_button;
            this.btMathang.Enabled = txt_cbo_datetime_button;

            //---------Ẩn/Hiện ComboBox
            this.cboKhachhang.Enabled = txt_cbo_datetime_button;
            this.cboMathang.Enabled = txt_cbo_datetime_button;
            this.cboNhanvien.Enabled = txt_cbo_datetime_button;

            //---------Ẩn/Hiện Button
            this.btnLaphoadon.Enabled = laphd;
            this.btnLuu.Enabled = luu;
            this.btnKhongluu.Enabled = khongluu;
            this.btnTim.Enabled = tim;
            this.btnIn.Enabled = inhd;
            this.btnThoat.Enabled = thoat;
        }

        private void btnKhongluu_Click(object sender, EventArgs e)
        {
            //---------Gọi hàm ẩn/hiện
            AnHien(false, true, false, false, true, true, true);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            frmTraCuuHoaDon frm = new frmTraCuuHoaDon();
            frm.Show();
        }

        private void btKhachhang_Click(object sender, EventArgs e)
        {
            frmCapnhatKH frm = new frmCapnhatKH();
            frm.Show();
        }
        //-------Khai báo biến thuộc lớp DataTable và DataRow
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        private void btnThem_Click(object sender, EventArgs e)
        {
            //------------Lấy Đơn giá và Đơn vị tính
            DataTable myDT = new DataTable();
            cn.getDataTable(myDT, "SELECT DONGIA, DONVITINH FROM MATHANG WHERE MSMH = '" + this.cboMathang.SelectedValue.ToString() + "'");

            //------------Thêm dữ liệu vào DataGridView
            myTable = this.dataSetHD.Tables[0];
            myRow = myTable.NewRow();
            myRow[1] = this.cboMathang.SelectedValue.ToString();
            myRow[2] = this.cboMathang.Text.ToString();
            myRow[3] = myDT.Rows[0][1].ToString();
            myRow[4] = int.Parse(this.txtSoluong.Text.Trim());
            myRow[5] = double.Parse(myDT.Rows[0][0].ToString());
            myRow[6] = int.Parse(this.txtSoluong.Text.Trim()) * double.Parse(myDT.Rows[0][0].ToString());
            myTable.Rows.Add(myRow);
            this.dataGridViewCTHD.DataSource = myTable;

            //------------Tính tổng tiền
            double tong = 0.0;
            for (int i = 0; i < myTable.Rows.Count; i++)
            {
                tong += double.Parse(myTable.Rows[i][6].ToString());
            }
            this.txtTongtien.Text = tong.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNhanvien_Click(object sender, EventArgs e)
        {

            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }

        private void btMathang_Click(object sender, EventArgs e)
        {

            frmMatHang frm = new frmMatHang();
            frm.Show();
        }
    }
}
