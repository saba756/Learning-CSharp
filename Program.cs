using PracticeC_.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeC_
{
    internal class Program
    {
    
        static void Main(string[] args)
        {

            //var book = new Book { Isbn = "1111", Title = "c# advanced" };
            //var number = new GenericList<int>();
            //number.Add(10);
            //var books = new GenericList<Book>();
            //books.Add(new Book());
            //Console.ReadLine();
            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book());

            var number = new Generic.Nullable<int>();
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
            Console.ReadLine();
        }


    }
}
