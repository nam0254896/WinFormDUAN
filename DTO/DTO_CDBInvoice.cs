using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CDBInvoice
    {
        string _MSHD;
        public string MSHD
        {
            get { return _MSHD; }
            set { _MSHD = value; }
        }
        string _NGAYHD;
        public string NGAYHD
        {
            get { return _NGAYHD; }
            set { _NGAYHD = value; }
        }
        //---------Viết hàm khởi tạo không có tham số
        public DTO_CDBInvoice() { }
        public DTO_CDBInvoice(string mshd, string ngayhd)
        {
            this.MSHD = mshd;
            this.NGAYHD = ngayhd;
        }
    }
}
