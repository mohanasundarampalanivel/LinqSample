using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    internal class ResultData
    {
        public string department
        {
            get;
            set;
        }
        public decimal totalExpenses
        {
            get;
            set;
        }

        public Employee maxSalary
        {
            get;
            set;
        }

        public Employee minSalary
        {
            get;
            set;
        }
    }
}
