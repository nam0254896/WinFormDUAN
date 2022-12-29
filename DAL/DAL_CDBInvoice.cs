using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_CDBInvoice
    {
        public DataSet getDataStoredProcedure(DataSet DSet, string sql, string

        tablename)

        {
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter(sql,

                DAL_CDBConnect.myconn);
                sqlDA.Fill(DSet, tablename);
                return DSet;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!",

                MessageBoxButtons.OK);

                return null;
            }
        }
        public SqlDataReader pr_TIMHD(string sql, DTO_CDBInvoice c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSHD", System.Data.SqlDbType.Char, 15).Value = c.MSHD.ToString();
                cmd.Parameters.Add("@NGAYHD", System.Data.SqlDbType.DateTime).Value = c.NGAYHD.ToString();
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
