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
            List<int> numbers = new List<int>();

            numbers.Add(12);
            numbers.Add(5);
            numbers.Add(8);
            numbers.Add(14);
            numbers.Add(22);

            numbers.AddRange(new int[] { 3, 4, 5, 6 });

            numbers.RemoveAt(3); // удаление одного значения.

            numbers.Remove(5); // удаление по совподению.

            numbers.Insert(1, 123);

            Console.WriteLine("Число 22 находится на позиции: " + numbers.IndexOf(22)); 

           /* numbers.Clear(); //очистить лист*/


            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }


}