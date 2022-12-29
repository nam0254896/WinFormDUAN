using BUS;
using DTO;
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
    public partial class frmDangnhap : Form
    {
        //------------Khai báo lớp: BUS_CDBConnect
        BUS_CDBConnect conn = new BUS_CDBConnect();
        //-----------Khai báo lớp GUI_CEnableMenu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();
        public frmDangnhap()
        {
            InitializeComponent();
        }
        //------Khai báo các biến lưu lại thông tin đăng nhập (để dùng cho Crytal reports)

        public static string SV = string.Empty;
        public static string DB = string.Empty;
        public static string UI = string.Empty;
        public static string Pass = string.Empty;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // gán thông tin đăng nhập từ formDangnhap vào các biến)
            SV = txtSvName.Text.Trim();
            DB = txtDataBase.Text.Trim();
            UI = txtLoginName.Text.Trim();
            Pass = txtPassword.Text.Trim();
            // Khởi tạo thông tin đăng nhập từ lớp DTO
            DTO_DBConnect lg = new DTO_DBConnect(txtSvName.Text.Trim(),
            txtDataBase.Text.Trim(),
            txtLoginName.Text.Trim(),
            txtPassword.Text.Trim());
            // Gọi hàm kết nối CSDL
            if (conn.DBConnect(lg) == true)
            {
                mnu.CEnableMenu(false, true);
                this.Close();
            }
        }

        private void txtSvName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
