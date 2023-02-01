using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labexercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car= new Car();
            car.AcceptDetails();
            car.DisplayDetails();
            Console.ReadLine();
        }
    }
}
