using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PracticeC_
{
    public class FileExercise
    {
        //Write a program that reads a text file and displays the number of words.
        public void displayWords()
        {
            // Store the path of the textfile in your system 
            string file = @"C:\Users\sata\Desktop\sata\Data.txt";
            string fileData;
            Console.WriteLine("Reading File using File.ReadAllText()");
            int max = int.MinValue;
            // To read the entire file at once 
            if (File.Exists(file))
            {
                // Read all the content in one string 
                // and display the string 
                fileData = File.ReadAllText(file);
                string[] words = fileData.Split(' ');
                 int wordsCount= words.Length;
                for (int i = 0; i < words.Length; i++) {
                    words[i] = words[i].Trim();
                   
                    if(words[i].Length > max)
                    {
                        max= words[i].Length;
                       
                    }
                   
                }
                Console.WriteLine("max value: {0}", max);
                Console.WriteLine("File Data: {0}",fileData);
                Console.WriteLine("Number of words in file: {0}",wordsCount);
            }
             

        }
    }
}
