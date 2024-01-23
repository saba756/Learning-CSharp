using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_.Polymorphism
{
    public class Canvas
    {
        public void DrawShapes(List<DrawShape> shapes)
        {
            foreach (var shape in shapes)
            {

                shape.Draw();
            }
        }
    }

}