using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    interface IDepartment
    {
        IEnumerable<ResultData> GetTotalexpenses(List<Employee> emp);
        //decimal GetHighestpayingEmployee(List<Employee> emp);
        //decimal GetLowestPayingEmployee(List<Employee> emp);

    }
}
