using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_.Generic
    
{
    //Here are five types of constraints.
    //Where T:IComparable => apply constraint to an interface
    //Where T:Product => sub classes
    //Where T:struct => value type
    //Where T:class
    //Where T:new()
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T(); // default constructor
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
