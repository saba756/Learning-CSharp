using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_.Polymorphism
{
    public class DrawShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Position{ get; set; }
     
        public virtual void Draw()
        {

        }
    }
}
