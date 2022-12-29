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
    public partial class frmTimMatHang : Form
    {
        public frmTimMatHang()
        {
            InitializeComponent();
        }
        BUS_CDBProduct ct = new BUS_CDBProduct();
        //---------Khai báo biến thuộc lớp DataTable
        DataTable myTable = new DataTable();
        DataRow myRow = null;
        private void frmTimMatHang_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                //-----------1.Gọi hàm khởi tạo thông tin NHÂN VIÊN để tìm kiếm
                int gia = 0;
                if (string.IsNullOrEmpty(this.txtDongia.Text.Trim()))
                    gia = 0;
                else
                    gia = int.Parse(this.txtDongia.Text.Trim());
                DTO_CDBProduct cus = new DTO_CDBProduct(this.txtTenMH.Text.Trim(),
            gia,
            this.txtMaMH.Text.Trim());
                //-----------2.Gọi hàm tìm kiếm NHÂN VIÊN
                SqlDataReader rd = ct.pr_TIMMH("pr_TIMMH", cus);
                myTable.Clear();
                myTable = this.dataSetMH.Tables[0];
                int STT = 1;
                while (rd.Read() == true)
                {
                    myRow = myTable.NewRow();
                    myRow[0] = STT;
                    myRow[1] = rd.GetString(0).ToString();

                    myRow[2] = rd.GetString(1).ToString();

                    myRow[3] = rd.GetString(2).ToString();

                    myRow[4] = rd.GetDouble(3).ToString(); // date

                    myRow[5] = rd.GetString(4).ToString();
                    myTable.Rows.Add(myRow);
                    STT += 1;
                }
                rd.Close();
                this.dataGridViewMH.DataSource = myTable;

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
