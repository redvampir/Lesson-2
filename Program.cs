﻿using System;
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
            Stack<int> numbers = new Stack<int>();


            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);

            Console.WriteLine(numbers.Peek());

            while (numbers.Count > 0)
            {
                Console.WriteLine("Следующие число в стеке: " + numbers.Pop());
            }
        }
    }


}