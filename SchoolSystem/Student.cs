using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    public class Student
    {
        public int idStudent { get; set; } //уникален номер
        public string name { get; set; } //име
        public string surname { get; set; } //презиме
        public string family { get; set; } //фамилия
        public string egn { get; set; } //ЕГН
        public DateTime birt_day { get; set; } //дата на раждане
        public string birt_place { get; set; } //място на раждане
        public string district { get; set; } //област
        public string e_mail { get; set; } //имейл
        public string mobile { get; set; } //телефон
    }
}
