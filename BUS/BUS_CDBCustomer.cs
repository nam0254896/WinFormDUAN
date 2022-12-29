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
    public class BUS_CDBCustomer
    {
        //-----------Khai báo biến thuộc lớp DAL_CDBCustomer
        DAL_CDBCustomer c = new DAL_CDBCustomer();
        //-----------1.Viết hàm gọi Stored Procedure không có tham số và trả raSqlDataReader

        public SqlDataReader getDataStoredProcedure(string sql)
        {
            return c.getDataStoredProcedure(sql);
        }
        //-----------2.Viết hàm gọi Stored Procedure thêm khách hàng
        public void Pr_THEMKH(DTO_CDBCustomer cteo)
        {
            c.pr_THEMKH(cteo);
        }

        public void pr_THEMKH(global::DTO.DTO_CDBCustomer cus)
        {
            throw new NotImplementedException();
        }

        //-----------3.Viết hàm gọi Stoted Procedure tìm khách hàng theo nhiều tiêu chí(Họ tên, Địa chỉ, Điện thoại, etc) và trả ra SqlDataReader
        public SqlDataReader pr_TIMKH(string sql, DTO_CDBCustomer cus)
        {
            return c.pr_TIMKH(sql, cus);
        }
        //-----------3.Viết hàm gọi Stoted Procedure tìm nhân viên theo nhiều tiêu chí(Họ tên, Địa chỉ, Điện thoại, etc) và trả ra SqlDataReader



    }
}
