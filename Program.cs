using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticeC_.UnionInters;
using static PracticeC_.palindrom;
using static PracticeC_.Conditional_Assignment;
namespace PracticeC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            UnionInters unionInters = new UnionInters();
                        palindrom Palindrom = new palindrom();
                        int[] first = new int[] { 1, 2, 3 };
                        int[] second = new int[] { 2, 2, 3 };
                        List<int> unionResult = new List<int>();
                        unionResult = unionInters.arrayUnion(first, second);
                        for (int i = 0; i < unionResult.Count(); i++)
                        {
                            Console.WriteLine("Union Number = {0}", unionResult[i]);
                        }
                        List<int> IntersectionRes = new List<int>();
                        IntersectionRes = unionInters.arrayIntersection(first, second);
                        for (int i = 0; i < IntersectionRes.Count(); i++)
                        {
                            Console.WriteLine("Intersection Number = {0}", IntersectionRes[i]);
                        }
                        Console.ReadLine();*/
            palindrom Palindrom = new palindrom();
            Conditional_Assignment cond= new Conditional_Assignment();
            ArrayandListexample arrayandListexample = new ArrayandListexample();
            //Palindrom.Ispalindrom();
            // cond.displayCount();
            //cond.calculateSum();
            //cond.calculateFactorialNum()
            //cond.randomNum();
            //cond.Conditional_Assignmentfunc();
            // cond.displaymaxNum();
            //cond.islandscapeImage();
            //cond.checkCarSpeed();
            // cond.displayMaxNum();
            // arrayandListexample.displayPosts();
            //arrayandListexample.ReverseIntNum();
            //arrayandListexample.displayEvenNum();
            //arrayandListexample.reverseArray();
            //arrayandListexample.sortArray();
            arrayandListexample.displaySmallestNum();
            Console.ReadLine();
        }


    }
}
