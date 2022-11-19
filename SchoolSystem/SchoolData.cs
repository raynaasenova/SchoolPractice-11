using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SchoolSystem
{
    public class SchoolData
    {
        public string name { get; set; } //име
        public string patron { get; set; } //патрон
        public string city { get; set; } //град
        public string district { get; set; } //област
        public string address { get; set; } //адрес
        public string web_site { get; set; } //уеб страница
        public string telephone { get; set; } //телефон
        public string logotype { get; set; } //
        public string patron_day { get; set; } //
    }
}
