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
    public partial class frmTimKhachHang : Form
    {
        public frmTimKhachHang()
        {
            InitializeComponent();
        }

        //----------Khai báo biến thuộc lớp BUS_CDBCustomer của tầng BUS
        BUS_CDBCustomer ct = new BUS_CDBCustomer();
        //---------Khai báo biến thuộc lớp DataTable
        DataTable myTable = new DataTable();
        DataRow myRow = null;





        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            //-----------1.Gọi hàm khởi tạo thông tin khách hàng để tìm kiếm
            DTO_CDBCustomer cus = new DTO_CDBCustomer(this.txtHoTenKH.Text.Trim(),
            this.txtDiaChi.Text.Trim

            (),
            this.txtDienThoai.Text.Trim());
            //-----------2.Gọi hàm tìm kiếm khách hàng
            SqlDataReader rd = ct.pr_TIMKH("pr_TIMKH", cus);
            myTable.Clear();
            myTable = this.dataSetKH.Tables[0];
            int STT = 1;
            while (rd.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = STT;
                myRow[1] = rd.GetString(0).ToString();
                myRow[2] = rd.GetString(1).ToString();
                myRow[3] = rd.GetString(2).ToString();
                myRow[4] = rd.GetString(3).ToString();
                myRow[5] = rd.GetString(4).ToString();
                myTable.Rows.Add(myRow);
                STT += 1;
            }
            rd.Close();
            this.dataGridViewKH.DataSource = myTable;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
