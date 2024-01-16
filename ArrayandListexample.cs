using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeC_
{
    public class ArrayandListexample
    {

        public void displayEvenNum()
        {
            Console.WriteLine("Enter size of array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arraySize = new int[num];
            int[] storeNum = new int[num];
            for (int i = 0; i < arraySize.Length; i++)
            {
                Console.WriteLine("Enter values");
                arraySize[i] = Convert.ToInt32(Console.ReadLine());
                if (arraySize[i] % 2 == 0)
                {
                    arraySize[i] = 0;
                }
            }
            for (int i = 0; i < arraySize.Length; i++)
            {
                Console.WriteLine(" values are {0}", arraySize[i]);
            }
        }
        public void ReverseIntNum()
        {
            int num = 12345;

            while (num > 0)
            {
                int store = num % 10;
                num = num / 10;
                Console.WriteLine(" values are {0}", store);
            }

        }
        public void displayPosts()
        {

            //When you post a message on Facebook, depending on the number of people who like your post,
            //Facebook displays different information.
            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People]
            //others like your post.
            //Write a program and continuously ask the user to enter different names, 
            //until the user presses Enter (without supplying a name). Depending on the number of names provided,
            //display a message based on the above pattern.
            Console.WriteLine("Enter a series of names");
            string s = Console.ReadLine();
            string[] values = s.Split(',');
            var list = new List<string>();
            string storeValue = "";
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim();
                if (values.Length == 1)
                {
                    Console.WriteLine($"{values[i]} like your post");

                }
                if (values.Length == 2)
                {

                    if (i == 0)
                    {
                        storeValue = values[i];

                    }
                    if (i == 1)
                    {
                        string str = $"{storeValue} and {values[i]} like your post.";
                        Console.WriteLine(str);
                    }



                }
                if (values.Length > 2)
                {

                    if (i == 0)
                    {
                        storeValue = values[i];

                    }
                    if (i == 1)
                    {

                        storeValue = $"{storeValue} , {values[i]}";

                    }

                    if (i == 2)
                    {
                        Console.WriteLine($"{storeValue} and {values.Length - 2}  of Other People like your post");
                    }


                }


            }

        }


        public void reverseArray()
        {
            //Write a program and ask the user to enter their name.
            //Use an array to reverse the name and then store the result in a new string.
            //Display the reversed name on the console.
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            char[] stringArray = name.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);

            Console.WriteLine("NAME {0}", reversedStr);


        }
        public void sortArray()
        {
            //Write a program and ask the user to enter 5 numbers.
            //If a number has been previously entered, display an error message and ask the user to re-try.
            //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            Console.WriteLine("Enter a 5 number");
            int[] arraySize = new int[5];
            // ..int[] distinctNumbers = numbers.Distinct().ToArray();

            for (int i = 0; i < arraySize.Length; i++)
            {

                arraySize[i] = Convert.ToInt32(Console.ReadLine());
                int[] duplicateNumbers = arraySize
                 .GroupBy(x => x)
                 .Where(g => g.Count() > 1)
                 .Select(g => g.Key)
                 .ToArray();
                if (duplicateNumbers.Contains(arraySize[i]))
                {
                    Console.WriteLine("please retry number has already exist");
                    arraySize[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = arraySize.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("reverse order {0}", arraySize[i]);
            }
        }

        public void displayDuplicatesNumber()
        {
            //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            //The list of numbers may include duplicates. Display the unique numbers that the user has entered.


            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or type Quit");
                var input = Console.ReadLine();


                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var item in numbers)
            {
                if (!uniques.Contains(item))
                {
                    uniques.Add(item);
                }
            }
            Console.WriteLine("Unique number are");
            foreach (var item in uniques)
            {
                Console.WriteLine(item);
            }
        }
        public void displaySmallestNum()
        {
            //Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
            //otherwise, display the 3 smallest numbers in the list.
            Console.WriteLine("Enter your list of Number separated by commas");
            string Number = Console.ReadLine();
            string[] values = Number.Split(',');
            int min = 0;
            var test = string.Join(",", values.OrderBy(x => x).Take(3));
          
            if (values.Length == 0 || values.Length < 3)
            {
                Console.WriteLine("Invalid List please retry");
                Number = Console.ReadLine();

            }
            
           
        }


    }
}        
   

