using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_CDBEmployee
    {
        //-----------1.Viết hàm gọi Stored Procedure không có tham số và trả ra SqlDataReader
        public SqlDataReader getDataStoredProcedure(string sql)
        {
            try
            {
                SqlCommand myCM = new SqlCommand(sql, DAL_CDBConnect.myconn);
                SqlDataReader myDR = myCM.ExecuteReader();
                return myDR;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!",
                MessageBoxButtons.OK);
                return null;
            }
        }
        //-----------2.Viết hàm gọi Stored Procedure thêm khách hàng
        public void pr_THEMNV(DTO_CDBEmployee c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_THEMNV",
                DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char,
                10).Value = c.MANV.ToString();
                cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar,
                50).Value = c.TENNV.ToString();
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NChar,
                10).Value = c.PHAI.ToString();
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar,
                50).Value = c.DIACHI.ToString();
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.VarChar,
                                    10).Value = c.DIENTHOAI.ToString();

                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo!",
                MessageBoxButtons.OK);
            }
        }


        public SqlDataReader pr_TIMNV(string sql, DTO_CDBEmployee c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar,

                50).Value = c.TENNV.ToString();

                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar,

                50).Value = c.DIACHI.ToString();

                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar,

                10).Value = c.DIENTHOAI.ToString();
                SqlDataReader rd = cmd.ExecuteReader();
                return rd;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!",

                MessageBoxButtons.OK);

                return null;
            }
        }
    }
}
