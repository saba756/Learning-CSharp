using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_.Polymorphism
{
    public class Circle :DrawShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
}
