using System;
using System.Collections.Generic;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1 for JSON and choose 2 for Database");
            string option = Console.ReadLine().ToString();

            GetDataFromSource source = new GetDataFromSource();
            Employee emp_Details = new Employee();

            if (option == "1")
            {
                List<Employee> emp =source.GetDataFromJson();
                ProcessData data = new ProcessData();
                data.salaryCalculations(emp);
            }
            else
            {
                source.GetDataFromDB();
            }

            Console.ReadKey();
        }
    }
}
