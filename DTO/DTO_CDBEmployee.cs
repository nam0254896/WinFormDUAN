using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CDBEmployee
    {
        private string _MANV;
        public string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }
        private string _TENNV;

        public string TENNV
        {
            get { return _TENNV; }
            set { _TENNV = value; }
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
        //--------Viết constructors không có tham số
        public DTO_CDBEmployee() { }
        //--------Viết constructors có tham số
        public DTO_CDBEmployee(string ms, string ht, string p, string dc, string dt)
        {
            this.MANV = ms;
            this.TENNV = ht;
            this.PHAI = p;
            this.DIACHI = dc;
            this.DIENTHOAI = dt;
        }
        public DTO_CDBEmployee(string ht, string dc, string dt)
        {
            this.TENNV = ht;
            this.DIACHI = dc;
            this.DIENTHOAI = dt;
        }
    }
}
