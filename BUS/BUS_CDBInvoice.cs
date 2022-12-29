using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CDBInvoice
    {
        //--------------Khai báo biến thuộc lớp DAL_CDBInvoice của tầng DAL
        DAL_CDBInvoice iv = new DAL_CDBInvoice();
        public DataSet getDataStoredProcedure(DataSet DSet, string sql, string

        tablename)

        {
            return iv.getDataStoredProcedure(DSet, sql, tablename);
        }
        public void pr_THEMHD(DTO_CDBInvoice cteo)
        {
            //iv.pr_THEM(cteo);
        }
        public SqlDataReader pr_TIMHD(string sql, DTO_CDBInvoice cus)
        {
            return iv.pr_TIMHD(sql, cus);
        }
    }
}
