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
            Behaviur[] behaviurs =
            {
                new Walker(),
                new Jumper()
            };

            while (true)
            {
                foreach (var behaviour in behaviurs)
                {
                    behaviour.Update();
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
       
    }

    class Behaviur
    { 
    public virtual void Update()
        {

        }
    }

    class Walker : Behaviur
    {
        public override void Update()
        {
            Console.WriteLine("Иду.");
        }
    }

    class Jumper : Behaviur
    {
        public override void Update()
        {
            Console.WriteLine("Прыгаю.");
        }
    }
}