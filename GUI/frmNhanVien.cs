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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        //-----------Khai báo biến thuộc lớp BUS_CDBCustomer ở tầng BUS

        //
        BUS_CDBEmployee bus = new BUS_CDBEmployee();
        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTimNhanVien frm = new frmTimNhanVien();
            frm.Show();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            try
            {

                //----------2.Gọi hàm tạo mã số khách hàng
                SqlDataReader rd = bus.getDataStoredProcedure("pr_TAOMANV");
                if (rd.Read() == true)
                {
                    this.txtMaNV.Text = rd.GetSqlString(0).ToString();
                    rd.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!",

                MessageBoxButtons.OK);

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //----------1.Khởi tạo các thông tin khách hàng
            DTO_CDBEmployee cus = new DTO_CDBEmployee(this.txtMaNV.Text.Trim(),
            this.txtHoTen.Text.Trim(),
            this.cboPhai.Text,
            this.txtDiaChi.Text.Trim(),
            this.txtDienThoai.Text.Trim());
            //----------2.Gọi hàm thêm khách hàng mới
            bus.pr_THEMNV(cus);
        }
    }
}
