using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_
{
    public class DesignStack
    {
        List<object> stack = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Stack can't be null");
            stack.Add(obj);
        }
        public object Pop()
        {
            if (stack == null || stack.Count ==0)
                throw new InvalidOperationException("Stack can't be null");

           var res = stack.ElementAt(stack.Count - 1);
            stack.RemoveAt(stack.Count - 1);
            return res;
            

        }
        public void clear()
        {
            stack.Clear();
        }

    }
}
