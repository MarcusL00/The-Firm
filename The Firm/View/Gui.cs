using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Firm.Model;

namespace The_Firm.View
{
    internal class Gui
    {
        public static void WriteEmployees(params Model.Employee[] employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
            Console.ReadKey();
        }
    }
   
}
