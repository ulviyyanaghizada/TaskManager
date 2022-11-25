using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Manager:Assistant
    {
        private Employee _employee;


        public Employee Employee { get; set; }
        protected string GetPromotion(Employee employee)
        {
            if (Issuccesfull==true)
            {
                Employee.Salary += 100;
            }
            else
            {
                Console.WriteLine("wrong input!");
            }

            return  employee;
            
        }
    }
}
