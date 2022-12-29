using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CDBProduct
    {
        //-----------Khai báo biến thuộc lớp DAL_CDBCustomer
        DAL_CDBProduct c = new DAL_CDBProduct();
        //-----------1.Viết hàm gọi Stored Procedure không có tham số và trả ra  SqlDataReader

        public SqlDataReader getDataStoredProcedure(string sql)
        {
            return c.getDataStoredProcedure(sql);
        }
        //-----------2.Viết hàm gọi Stored Procedure thêm khách hàng
        public void pr_THEMMH(DTO_CDBProduct cteo)
        {
            c.pr_THEMMH(cteo);
        }
        public SqlDataReader pr_TIMMH(string sql, DTO_CDBProduct cus)
        {
            return c.pr_TIMMH(sql, cus);
        }
    }
}
