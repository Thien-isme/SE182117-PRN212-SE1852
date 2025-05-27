using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Employee
    {
        #region Nhom cac thuoc tinh
        private int _ID;
        private string _Name;
        private string _Email;
        private string _Phone;
        #endregion
        public Employee()
        {
        }

        public Employee(int _ID, string name, string email, string phone)
        {
            this._ID = _ID;
            _Name = name;
            _Email = email;
            _Phone = phone;
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        public void PrintInFor()
        {
            Console.WriteLine($"{_ID}\t{_Name}\t{_Email}\t{_Phone}");
        }
        public override string ToString()
        {
            string msg = $"{_ID}\t{_Name}\t{_Email}\t{_Phone}";
            return msg; ;
        }
    }
}
