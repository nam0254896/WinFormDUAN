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
    public partial class frmTimNhanVien : Form
    {
        public frmTimNhanVien()
        {
            InitializeComponent();
        }
        //----------Khai báo biến thuộc lớp BUS_CDBCustomer của tầng BUS
        BUS_CDBEmployee ct = new BUS_CDBEmployee();
        //---------Khai báo biến thuộc lớp DataTable
        DataTable myTable = new DataTable();
        DataRow myRow = null;
        private void frmTimNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //-----------1.Gọi hàm khởi tạo thông tin NHÂN VIÊN để tìm kiếm
            DTO_CDBEmployee cus = new DTO_CDBEmployee(this.txtHoTenNV.Text.Trim(),
            this.txtDiaChi.Text.Trim(),
            this.txtDienThoai.Text.Trim());
            //-----------2.Gọi hàm tìm kiếm NHÂN VIÊN
            SqlDataReader rd = ct.pr_TIMNV("pr_TIMNV", cus);
            myTable.Clear();
            myTable = this.dataSetNV.Tables[0];
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
            this.dataGridViewNV.DataSource = myTable;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
