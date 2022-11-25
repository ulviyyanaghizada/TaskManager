using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Employee
    {
        private string _name;
        private bool _isSuccesfull;
        private decimal _salary;

        public string Name

        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();
                if (value.Length >= 3 && value.Length<=25)
                {
                    _name = value;
                }
            }
        }

        public bool Issuccesfull
        {
            get
            {
                return _isSuccesfull;
            }
            set
            {
                _isSuccesfull = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value>1)
                {
                    _salary = value;
                }
            }
        }
    }
    

}
