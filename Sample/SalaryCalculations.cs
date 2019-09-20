using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sample
{
    class SalaryCalculations: IDepartment
    {
        public IEnumerable<ResultData> GetTotalexpenses(List<Employee> employee_list)
        {
            // Data source
            var groupedCustomerList = employee_list.GroupBy(item => item.DeptID).Select(emp => emp.ToList()).ToList();
            ResultData data = new ResultData();
            IEnumerable<ResultData> result = employee_list.GroupBy(emp => emp.DeptName)
                                    .Select(e => new ResultData
                                    {
                                        department = e.Key,
                                        maxSalary = e.OrderByDescending(x => x.Salary)
                                                     .FirstOrDefault(),
                                        minSalary = e.OrderBy(x => x.Salary)
                                                     .FirstOrDefault(),
                                        totalExpenses = e.Select(x => x.Salary).Sum()
                                    });
            return result;
        }

        //public decimal GetHighestpayingEmployee(List<Employee> emp)
        //{
        //    return 1000;
        //}

        //public decimal GetLowestPayingEmployee(List<Employee> emp)
        //{
        //    return 1000;
        //}
    }
}
