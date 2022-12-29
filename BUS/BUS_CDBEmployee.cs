﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CDBEmployee
    {
        //-----------Khai báo biến thuộc lớp DAL_CDBCustomer
        DAL_CDBEmployee c = new DAL_CDBEmployee();
        //-----------1.Viết hàm gọi Stored Procedure không có tham số và trả ra  SqlDataReader

        public SqlDataReader getDataStoredProcedure(string sql)
        {
            return c.getDataStoredProcedure(sql);
        }
        //-----------2.Viết hàm gọi Stored Procedure thêm khách hàng
        public void pr_THEMNV(DTO_CDBEmployee cteo)
        {
            c.pr_THEMNV(cteo);
        }
        public SqlDataReader pr_TIMNV(string sql, DTO_CDBEmployee cus)
        {
            return c.pr_TIMNV(sql, cus);
        }
    }
}
