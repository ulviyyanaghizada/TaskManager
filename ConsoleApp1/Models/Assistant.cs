using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Assistant:Employee
    {
        public void GetFeedBack(Employee employee)
        {
            if (Issuccesfull==true)
            {
                GetPromotion();
            }
        }
    }
}
