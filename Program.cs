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
            var person = new Person(new DateTime(1982, 1, 1));
            var stopWatch = new DesignStopWatch();
                 Console.WriteLine("Enter S to Start and Q to stop the watch");
            string input= Console.ReadLine();
            while(!string.IsNullOrEmpty(input))
            {
                if(string.Equals("s",input) || string.Equals("S", input))
                {
                    Console.WriteLine("timer Started");
                    stopWatch.start();
                    Console.WriteLine("Enter Q to stop the watch");
                }
                else if (string.Equals("q", input) || string.Equals("Q", input))
                {
                    stopWatch.stop();
                    Console.WriteLine("Enter S to start the watch");
                }
                input = Console.ReadLine();
            }
                 // var cookie = new HttpCookie();
                 //cookie["name"] = "Saba";
                 // Console.WriteLine(person.Age);
                 //Console.WriteLine(cookie["name"]);
            Console.ReadLine();
        }


    }
}
