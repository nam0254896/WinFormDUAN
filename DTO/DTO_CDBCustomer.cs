using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CDBCustomer
    {
        private string _MSKH;
        public string MSKH
        {
            get { return _MSKH; }
            set { _MSKH = value; }
        }
        private string _TENKH;
        public string TENKH
        {
            get { return _TENKH; }
            set { _TENKH = value; }
        }
        private string _PHAI;
        public string PHAI
        {
            get { return _PHAI; }
            set { _PHAI = value; }
        }
        private string _DIACHI;
        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }
        private string _DIENTHOAI;
        public string DIENTHOAI
        {
            get { return _DIENTHOAI; }
            set { _DIENTHOAI = value; }
        }
        /// <summary>
        /// /
        /// </summary>







        //--------Viết constructors không có tham số
        public DTO_CDBCustomer() { }
        //--------Viết constructors có tham số
        public DTO_CDBCustomer(string ms, string ht, string p, string dc, string

        dt)
        {
            this.MSKH = ms;
            this.TENKH = ht;
            this.PHAI = p;
            this.DIACHI = dc;
            this.DIENTHOAI = dt;
        }
        //--------Viết constructors có 3 tham số
        public DTO_CDBCustomer(string ht, string dc, string dt)
        {
            this.TENKH = ht;
            this.DIACHI = dc;
            this.DIENTHOAI = dt;
        }

    }
}
