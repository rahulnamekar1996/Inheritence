using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SalesManager salesManager = new SalesManager("rahul", 22000, 3500);
            salesManager.CalclateSallary ();
            Console.WriteLine(salesManager);

            Employee employee = new Employee("roshan", 20000);
            employee.CalclateSallary();
            Console.WriteLine(employee);
               
        }
    }
}
