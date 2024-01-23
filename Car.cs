using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_
{
    public class Car: Vehicle
    {
        public Car(string registrationNumber):base(registrationNumber)
        {
            Console.WriteLine("car is being initialized. {0}", registrationNumber);
        }
    }
}
