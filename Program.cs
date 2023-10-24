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
            NonPlayerCharacter[] characters =
            {
                new NonPlayerCharacter(),
                new Farmer(),
                new Knight(),
                new Child()
            };

            foreach (var character in characters)
            {
                character.ShowDescription();
                Console.WriteLine(new string('-', 40));
            }
        }

    }

    class NonPlayerCharacter
    { 
        public virtual void ShowDescription()
        {
            Console.WriteLine("Я простой NPC, умею только гулять.");
        }
    }

    class Farmer : NonPlayerCharacter
    {
        public override void ShowDescription()
        {
            base.ShowDescription();
            Console.WriteLine("А ещё я фермер и умею работать на поле.");
        }
    }

    class Knight : NonPlayerCharacter
    {
        public override void ShowDescription()
        {
            Console.WriteLine("Я рыцарь, мое дело только сражения!"); ;
        }
    }

    class Child : NonPlayerCharacter
    {

    }
}