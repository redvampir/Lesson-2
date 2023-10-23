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
            bool isOpen = true;
            
            Table[] tables = { new Table(1, 4), new Table(2, 8), new Table(3, 10) };
            
            while (isOpen)
            {
                Console.WriteLine("Администрирование кафе.\n");

               for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

               Console.Write("\nВведите номер стола: ");
                int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("\nВведите количество мест для брони: ");
                int desiredPlaces = Convert.ToInt32(Console.ReadLine());

                bool isReservationComleted = tables[wishTable].Reserve(desiredPlaces);
                if (isReservationComleted)
                {
                    Console.WriteLine("Бронь прошла успешно!");
                }
                else
                {
                    Console.WriteLine("Бронь не прошла. Недостаточно мест.");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        class Table
        {
            public int Number;
            public int MaxPlaces;
            public int FreePlaces;

            public Table(int number, int maxPlaces) 
            {
                Number = number;
                MaxPlaces = maxPlaces;
                FreePlaces = maxPlaces;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Стол: {Number}. Свободных мест: {FreePlaces} из {MaxPlaces}.");
            }

            public bool Reserve(int places)
            {
                if (FreePlaces >= places) 
                { 
                    FreePlaces -= places;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }


}