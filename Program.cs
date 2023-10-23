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
            Car ferarri = new Car();
            

            ferarri.ShowTrchicalPasport();
        }

        class Car 
        { 
            public string Name;
            public int HorsePower;
            public int Age;
            public float MaxSpeed;
            public int Years = 4;

            public Car(string name, int horsePower, int age, float maxSpeed ) 
            { 
                Name = name;
                HorsePower = horsePower;
                Age = age;
                MaxSpeed = maxSpeed;
            }

            public Car() 
            {
                Name = "Ford";
                HorsePower = 500;
                Age = 1;
                MaxSpeed = 300;
            }

            public void ShowTrchicalPasport()
            {
                Console.WriteLine($"Название авто: {Name}\nКоличество лошадиных сил: {HorsePower}\n" +
                                  $"Возраст авто: {Age}\nМаксимальная скорость: {MaxSpeed}");
            }

            public void BecomeOlder(int Years, int runAwayHorses)
            {
                Age += this.Years + Years;
                HorsePower -= runAwayHorses;
            }
        }
    }


}