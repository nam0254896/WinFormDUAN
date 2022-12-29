using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DBConnect
    {

        private string _Servername;

        public string Servername { get => _Servername; set => _Servername = value; }
        public string Database { get => _Database; set => _Database = value; }
        public string UserID { get => _UserID; set => _UserID = value; }
        public string Password { get => _Password; set => _Password = value; }

        private string _Database;

        private string _UserID;

        private string _Password;

        //----------Hàm khởi tạo: Constructor, không tham số
        public DTO_DBConnect()
        {
        }
        // Hàm khởi tạo có tham số
        public DTO_DBConnect(string servername,
        string database,
        string userid,
        string password)
        {
            this.Servername = servername;
            this.Database = database;
            this.UserID = userid;
            this.Password = password;
        }
    }
    }
