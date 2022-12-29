using DTO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_CDBProduct
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
        public void pr_THEMMH(DTO_CDBProduct c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_THEMMH",
                DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MSMH", System.Data.SqlDbType.Char,
                10).Value = c.MSMH.ToString();
                cmd.Parameters.Add("@TENMH", System.Data.SqlDbType.NVarChar,
                100).Value = c.TENMH.ToString();
                cmd.Parameters.Add("@SL_TON", System.Data.SqlDbType.Int
                ).Value = c.SL_TON.ToString();
                cmd.Parameters.Add("@DONGIA", System.Data.SqlDbType.Float
                ).Value = c.DONGIA.ToString();
                cmd.Parameters.Add("@DONVITINH", System.Data.SqlDbType.NChar,
                                    20).Value = c.DONVITINH.ToString();

                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo!",
                MessageBoxButtons.OK);
            }
        }


        public SqlDataReader pr_TIMMH(string sql, DTO_CDBProduct c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSMH", System.Data.SqlDbType.VarChar,
                15).Value = c.MSMH.ToString();
                cmd.Parameters.Add("@TENMH", System.Data.SqlDbType.NVarChar,
                50).Value = c.TENMH.ToString();
                cmd.Parameters.Add("@DONGIA", System.Data.SqlDbType.Float
                ).Value = c.DONGIA.ToString();
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