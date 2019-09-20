using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sample
{
    internal class GetDataFromSource
    {
        internal List<Employee> GetDataFromJson()
        {
            Console.WriteLine("Enter the JSON file Path");
            string path = @"C:\Users\MohanasundaramPalani\Desktop\JSON\JsonData.json";
            string json = System.IO.File.ReadAllText(path);
            var people1 = JsonConvert.DeserializeObject(json);
            var people = JsonConvert.DeserializeObject<List<Employee>>(json);
            return people;
            //var test = "adsa";
        }

        internal void GetDataFromDB()
        {
            Console.WriteLine("Enter the connection string of DB");
            string connectionString = Console.ReadLine().ToString();
        }
    }
}
