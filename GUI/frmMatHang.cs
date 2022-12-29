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
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }
        BUS_CDBProduct bus = new BUS_CDBProduct();
        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        private void frmMatHang_Load(object sender, EventArgs e)
        {
            try
            {

                //----------2.Gọi hàm tạo mã số khách hàng
                SqlDataReader rd = bus.getDataStoredProcedure("pr_TAOMSMH");
                if (rd.Read() == true)
                {
                    this.txtMaMH.Text = rd.GetSqlString(0).ToString();
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
            DTO_CDBProduct cus = new DTO_CDBProduct(this.txtMaMH.Text.Trim(),
            this.txtTenMH.Text.Trim(),
            this.txtSoLuong.Text,
            float.Parse(this.txtDonggia.Text.Trim()),
            this.txtDonViTinh.Text.Trim());
            //----------2.Gọi hàm thêm khách hàng mới
            bus.pr_THEMMH(cus);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTimMatHang frm = new frmTimMatHang();
            frm.ShowDialog();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
