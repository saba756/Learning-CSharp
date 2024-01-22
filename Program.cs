using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            var person = new Person();
            person.BirthDate = new DateTime(1982, 1, 1);
            Console.WriteLine(person.Age);
        }


    }
}
