using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_
{
    public class Vehicle

    {
        private readonly string _registrationNumber;
        //public Vehicle()
        //{
        //    Console.WriteLine("vehicle is being initialized");

        //}
        public Vehicle(string registrationNumber)
        {
            this._registrationNumber = registrationNumber;
            Console.WriteLine("vehicle is being initialized. {0}", registrationNumber);
        }
    }
}
