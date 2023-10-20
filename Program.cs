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
            Queue<string> patients = new Queue<string>();

            patients.Enqueue("Василий");
            patients.Enqueue("Алексей");
            patients.Enqueue("Роман");
            patients.Enqueue("Владимир");

            Console.WriteLine("Сейчас на прием идет: " + patients.Dequeue());//ВЫводит из очереди и удаляет элемент
            Console.WriteLine("Следующий в очереди: " + patients.Peek()); //Выводит последний элемент

            foreach (var patien in patients) 
            { 
                Console.WriteLine(patien);
            }
        }
    }


}