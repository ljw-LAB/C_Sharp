using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_35
{
    interface IDrawingObject
    {
        void Draw();
    }
    class Line : IDrawingObject
    {
        public void Draw(){Console.WriteLine("Line");}

    }
    class Rectangle : IDrawingObject
    {
        public void Draw(){Console.WriteLine("Rectangle");}
    } 
    class Program
    {
        static void Main(string[] args)
        {
            IDrawingObject[] instances = new IDrawingObject[]{new Line(), new Rectangle()};

            foreach(IDrawingObject item in instances)
            {
                item.Draw();
            }

            IDrawingObject instance = new Line();
            instance.Draw();
        }
    }
}
