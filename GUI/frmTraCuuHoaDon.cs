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
    public partial class frmTraCuuHoaDon : Form
    {
        public frmTraCuuHoaDon()
        {
            InitializeComponent();
        }
        BUS_CDBInvoice ct = new BUS_CDBInvoice();
        //---------Khai báo biến thuộc lớp DataTable
        DataTable myTable = new DataTable();
        DataRow myRow = null;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btTraCuu_Click(object sender, EventArgs e)
        {
            try
            {
                //-----------1.Gọi hàm khởi tạo thông tin NHÂN VIÊN để tìm kiếm

                DTO_CDBInvoice cus = new DTO_CDBInvoice(this.txtMSHD.Text.Trim(), this.dateTimePickerHD.Value.ToString());
                //-----------2.Gọi hàm tìm kiếm NHÂN VIÊN
                SqlDataReader rd = ct.pr_TIMHD("pr_TIMHD", cus);
                myTable.Clear();
                myTable = this.dataSet1.Tables[0];
                int STT = 1;
                while (rd.Read() == true)
                {
                    myRow = myTable.NewRow();
                    myRow[0] = STT;
                    myRow[1] = rd.GetString(0).ToString();
                    myRow[2] = rd.GetString(1).ToString();
                    myRow[3] = rd.GetString(2).ToString();
                    myRow[4] = rd.GetDateTime(3).ToString();
                    myRow[5] = rd.GetString(4).ToString();
                    myTable.Rows.Add(myRow);
                    STT += 1;
                }
                rd.Close();
                this.DGrid.DataSource = myTable;

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void frmTraCuuHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
