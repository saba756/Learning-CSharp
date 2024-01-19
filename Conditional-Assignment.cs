using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PracticeC_
{

    //1- Write a program and ask the user to enter a number.The number should be between 1 to 10. 
    //    If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". 
    //    (This logic is used a lot in applications where values entered into input boxes need to be validated.)
    public class Conditional_Assignment
    {
        public void Conditional_Assignmentfunc()
        {
            Console.WriteLine("Enter a  number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 10 && num >= 1)
            {
                Console.WriteLine("Valid Number: " + num);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
           
        }


        public void displaymaxNum()
        {
            //Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.WriteLine("Enter a first number:");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second  number:");
            int secondnum = Convert.ToInt32(Console.ReadLine());
            int res = (firstnum > secondnum) ? firstnum : secondnum;
            Console.WriteLine("max number is :"  +res);
        }
        public void islandscapeImage()
        {
            //Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.
            Console.WriteLine("Enter the width of an image:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of an image:");
            int height = Convert.ToInt32(Console.ReadLine());
             if(width > height)
            {
                Console.WriteLine("Image is landscape");
            }
            else
            {
                Console.WriteLine("Image is Potrait");
            }
        }
        public void checkCarSpeed()
        {
            //Your job is to write a program for a speed camera.For simplicity, 
            // ignore the details such as camera, sensors, etc and focus purely on the logic.
            // Write a program that asks the user to enter the speed limit.Once set, 
            // the program asks for the speed of a car.If the user enters a value less than the speed limit,
            // program should display Ok on the console.If the value is above the speed limit,
            // the program should calculate the number of demerit points.For every 5km / hr above the speed limit,
            // 1 demerit points should be incurred and displayed on the console.
            // If the number of demerit points is above 12, the program should display License Suspended.

            Console.WriteLine("Enter the  speed limit:");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car:");
            int speedCar = Convert.ToInt32(Console.ReadLine());
            if(speedCar > speedLimit)
            {
                var res = speedCar - speedLimit;
                var test = res / 5;

                Console.WriteLine("demerit is:" +test);
                if (test >= 12)
                {
                    Console.WriteLine("License Suspended:");
                }
            }
            else {
                Console.WriteLine("Ok");
                    }
        }

        public void displayCount()
        {
            int count=0;
            // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            //Display the count on the console.
            for (int i = 1; i <= 100; i++) {
               if(i%3 == 0 )
                {
                    Console.WriteLine("Number is " + i);
                    count = count+ 1; 
                }
            }
            Console.WriteLine("Total Number is " + count);
        }

        public void calculateSum()
        {
            //Write a program and continuously ask the user to enter a number or "ok" to exit.
            //Calculate the sum of all the previously entered numbers and display it on the console.
            int count = 0;
            while (true)
            {
                Console.WriteLine("enter a number");
                int num = Convert.ToInt32(Console.ReadLine());
                count += 1;

                Console.WriteLine("Total number" + count);
            } 
        }

        public void calculateFactorialNum()
        {
            //Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console. 
            //For example, if the user enters 5, 
            //the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            int fact=1;
            Console.WriteLine("Enter as number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial Number is " + fact);
        }
        public void randomNum()
        {
            //Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won";
            //otherwise, display “You lost". (To make sure the program is behaving correctly,
            //you can display the secret number on the console first.)
            Random rnd = new Random();
            int randnum = rnd.Next(1, 10);
            Console.WriteLine("Random num is " + randnum);

            int num;
            int count = 4;
            
            for (int i = 1; i<=4; i++)
            {
                Console.WriteLine($"You have ({count}) choices to guess the number");
                   num = Convert.ToInt32(Console.ReadLine());
                if (num == randnum)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else
                {
                    Console.WriteLine("You lost");
                    count--;
                }

            }
        }

        public void displayMaxNum()
        {

            //Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console.
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            Console.WriteLine("Enter a series number");
            string s = Console.ReadLine();
            string[] values = s.Split(',');
            int max = 0;
            var numbers = new List<int>();
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim();
                if (int.Parse(values[i]) < max)
                {
                    max = int.Parse(values[i]);
                }
                
            }
            Console.WriteLine("Max value is {0}", +max);
        }
    }
  
   
}
