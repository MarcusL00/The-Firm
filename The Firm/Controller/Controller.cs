using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using The_Firm.Model;

namespace The_Firm.Controller
{
    internal class Controller
    {
        public void Ctrl()
        {
            Sweeper employee1 = new Sweeper("Marcus", "Johansen", "123456789");

            Manager manager1 = new Manager("John", "Johansen", "123456789", "13313113");

            ProjectManager projectManager1 = new ProjectManager("Emre", "larsen", "12345658", "88888888", "emrelarsen@hotmail.com");

            

            View.Gui.WriteEmployees(employee1, manager1, projectManager1);

        }

    }
}

