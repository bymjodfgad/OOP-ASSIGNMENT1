using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSIGNMENT1
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("drawing figure");
        }
    }

    //this subclass will hopefully override main class
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    }
