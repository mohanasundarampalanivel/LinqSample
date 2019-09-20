using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    internal class ProcessData: SalaryCalculations,IDisplay
    {
        internal void salaryCalculations(List<Employee> emp)
        {
            IEnumerable<ResultData> salaryCalculations = GetTotalexpenses(emp);
            //decimal high_paying_employee = GetHighestpayingEmployee(emp);
            //decimal low_paying_employee = GetLowestPayingEmployee(emp);
            DisplayResultData(salaryCalculations);
        }
        public void DisplayResultData(IEnumerable<ResultData> data)
        {
            foreach(var item in data)
            {
                Console.WriteLine("************ " + item.department + " **********");
                Console.WriteLine("Total Expenses for " + item.department + " is " + item.totalExpenses);
                Console.WriteLine("The Highest paid Employee of the " + item.department + " is " + item.maxSalary.Name + " Salary: " + item.maxSalary.Salary);
                Console.WriteLine("The Lowest paid Employee of the " + item.department + " is " + item.minSalary.Name + " Salary: " + item.minSalary.Salary);
                Console.WriteLine("************************************************************************************");
            }
        }
    }
}
