using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace labexercise2
{
    internal class Car
    {
        string Engine;
        int NoOfWheels;

        public void AcceptDetails()
        {
            Console.WriteLine("Enter the Engine Model");
            Engine = Console.ReadLine();
            Console.WriteLine("Enter the number of Wheels");
            NoOfWheels = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("The Engine model is:{0}", Engine);
            Console.WriteLine("The number of wheels are:{0}", NoOfWheels);
        }
    }
}


            

