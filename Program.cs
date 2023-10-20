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
            Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();

            countriesCapitals.Add("Австралия", "Канберра");
            countriesCapitals.Add("Турция", "Анкара");
            countriesCapitals.Add("Швейцария", "Берн");

            Console.WriteLine(countriesCapitals["Австралия"]);

            foreach (var item in countriesCapitals)
            {
                Console.WriteLine($"Страна - {item.Key} столица {item.Value}"); ;
            }
        }
    }


}