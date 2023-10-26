using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector2 position = new Vector2(10);

            Console.WriteLine(position.Y);
        }
       
    }
    
    struct Vector2
    {
        public int X, Y;

        public Vector2(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Vector2(int x) : this() 
        { 
            X = x; 
        }

    }
}