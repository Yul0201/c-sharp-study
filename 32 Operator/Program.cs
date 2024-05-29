using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car;

            car = new Car("SanTa Fe");
            Console.WriteLine(car.name);

            car = new Car("soretnto");
            Console.WriteLine(car.name);

            car = null;
            Console.WriteLine(car.name);
        }
    }
}
