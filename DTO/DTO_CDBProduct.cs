using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CDBProduct
    {

        private string _MSMH;
        public string MSMH
        {
            get { return _MSMH; }
            set { _MSMH = value; }
        }
        private string _TENMH;

        public string TENMH
        {
            get { return _TENMH; }
            set { _TENMH = value; }
        }
        private string _SL_TON;
        public string SL_TON
        {
            get { return _SL_TON; }
            set { _SL_TON = value; }
        }
        private float _DONGIA;
        public float DONGIA
        {
            get { return _DONGIA; }
            set { _DONGIA = value; }
        }
        private string _DONVITINH;
        public string DONVITINH
        {
            get { return _DONVITINH; }
            set { _DONVITINH = value; }
        }
        //--------Viết constructors không có tham số
        public DTO_CDBProduct() { }
        //--------Viết constructors có tham số
        public DTO_CDBProduct(string ms, string ht, string p, float dc, string dt)
        {
            this.MSMH = ms;
            this.TENMH = ht;
            this.SL_TON = p;
            this.DONGIA = dc;
            this.DONVITINH = dt;
        }
        public DTO_CDBProduct(string ht, float dc, string dt)
        {
            this.MSMH = dt;
            this.TENMH = ht;
            this.DONGIA = dc;
        }
    }
}
