using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data;

namespace LinqSQL
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string connectionString = "Data Source =.; Initial Catalog = TASK; Integrated Security = True;Encrypt = False;";
            var context = new DataContext(connectionString);
            var mappingSource = context.Mapping.MappingSource;

            DataClasses1DataContext db = new DataClasses1DataContext(connectionString,mappingSource);

            var employees= from emp in db.EMPLOYEEs
                           orderby emp.Department_ID
                            select emp;

            foreach (var item in  employees)
            {
                // Console.WriteLine(item);
                Console.WriteLine($"{item.Employee_ID} {item.First_Name} {item.Last_Name} {item.Department_ID}");
            }

        }
    }
}