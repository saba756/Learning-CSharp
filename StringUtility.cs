using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeC_
{
    public class StringUtility
    {
        public string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength) return text;
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();
            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength) break;
            }
            return String.Join(" ", summaryWords) + "...";
        }

        //Write a program and ask the user to enter a few numbers separated by a hyphen.
        //Work out if the numbers are consecutive. 
        //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        //display a message: "Consecutive"; otherwise, display "Not Consecutive"

        public void CheckConsecutive()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen");
            string s = Console.ReadLine();
            string[] values = s.Split('-');
         
            var testNum = 0;
            bool increment = false;
            bool decrement = false;
            if (values.Length > 1 && int.Parse(values[0]) + 1 == int.Parse(values[1]))
            {
                increment = true;
            }
            else if(values.Length > 1 && int.Parse(values[0]) - 1 == int.Parse(values[1]))
            {
                decrement = true;
            }
            if (!increment && !decrement) {
                Console.WriteLine("Not Consecutive");
                return;
            }
            
            for (int i = 1; i < values.Length-1; i++)
            {
                testNum = int.Parse(values[i]);

                if (increment)
                {
                    if (testNum + 1 != int.Parse(values[i + 1]))
                    {
                        Console.WriteLine("Not Consecutive");
                        return;

                    }
                }
                else if (decrement && (testNum - 1 != int.Parse(values[i + 1])))
                {
                    Console.WriteLine("Not Consecutive");
                    return;
                }
               
            }
            // print consecutive
            Console.WriteLine("Consecutive");
        }

        //Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, 
        //without supplying an input, exit immediately; 
        //otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.

        public void checkDuplication()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen");
            string s = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(s))
                return;

           // var numbers = new List<int>();
            //foreach (var number in s.Split('-'))
            //    numbers.Add(Convert.ToInt32(number));
            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var number in s.Split('-'))
            {
                if (!uniques.Contains(int.Parse(number)))
                {
                    uniques.Add(int.Parse(number));
                }
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }
            if (includesDuplicates)
            {
                Console.WriteLine("Duplicate");
                         }
        }

        //Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00).
        //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok";otherwise, display "Invalid Time". 
        //If the user doesn't provide any values, consider it as invalid time.
        public void timeFormat()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format(e.g. 19:00)");
            string s = Console.ReadLine();
            var timeValue = s.Split(':');
            var hours = int.Parse(timeValue[0]);
            var second= int.Parse(timeValue[1]);
            if (String.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Invalid");
                return;
            }
            if((hours >= 0 && hours <= 23) || (second >= 0 && second <= 59))
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        //Write a program and ask the user to enter a few words separated by a space.
        //Use the words to create a variable name with PascalCase.For example, 
        //if the user types: "number of students", display "NumberOfStudents". 
        //Make sure that the program is not dependent on the input.So, 
        // if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
        public void displayPascalCase()
        {
            Console.WriteLine("Enter a few words separated by a space");
            string s = Console.ReadLine();
            var words = s.Split(' ');
            var varName="";
            foreach (var word in words)
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                varName += wordWithPascalCase;
            }
            Console.WriteLine(varName);
        }

        //Write a program and ask the user to enter an English word.
        //Count the number of vowels (a, e, o, u, i) in the word. 
        //So, if the user enters "inadequate", the program should display 6 on the console.
        public void countVowels()
        {
            Console.WriteLine("Enter a English word");
            string s = Console.ReadLine();
            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var item in s)
            {
                if (vowels.Contains(item))
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);
        }
    }
}
