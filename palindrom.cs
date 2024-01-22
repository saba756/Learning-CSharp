using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_
{
    public class palindrom
         
    {
        public void Ispalindrom()
        {
            Console.WriteLine("Enter any word");
            string text = Console.ReadLine();
            string reverse= "";
            for(int i=text.Length-1; i>=0; i--)
            {
                reverse += text[i].ToString();
            }
            if(reverse == text)
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", text, reverse);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", text, reverse);
            }
        }

        }
    }

